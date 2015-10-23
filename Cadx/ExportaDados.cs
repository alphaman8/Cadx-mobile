using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Cadx
{
    public partial class ExportaDados : Form
    {
        public ExportaDados()
        {
            InitializeComponent();
            myconn = new MySqlConnection(strconn);
            myconn.StateChange += new StateChangeEventHandler(myconn_StateChange);
        }

        void myconn_StateChange(object sender, StateChangeEventArgs e)
        {
            if (myconn.State == ConnectionState.Open)
            {
                Cursor.Current = Cursors.Default;
                picConnOK.Visible = true;
                picConnOff.Visible = false;
                picConnWait.Visible = false;
                listBox1.Items.Add("Conectado.");
                //menuItem3.Enabled = true;
                btEnvia.Enabled = true;
            }
            if (myconn.State == ConnectionState.Closed)
            {
                Cursor.Current = Cursors.Default;
                picConnOK.Visible = false;
                picConnOff.Visible = true;
                picConnWait.Visible = false;
                //menuItem3.Enabled = false;
                btEnvia.Enabled = false;
                listBox1.Items.Add("Conexão fechada.");
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            if (myconn.State == ConnectionState.Connecting)
            {
                Cursor.Current = Cursors.WaitCursor;
                picConnOK.Visible = false;
                picConnOff.Visible = false;
                picConnWait.Visible = true;
                //menuItem3.Enabled = false;
                btEnvia.Enabled = false;
                listBox1.Items.Add("Conectando...");
            }
            Application.DoEvents();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportaDados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citeluzDataSet.trafo' table. You can move, or remove it, as needed.
            this.trafoTableAdapter.Fill(this.citeluzDataSet.trafo);
            this.plaquetaTableAdapter.FillAll(this.citeluzDataSet.plaqueta);

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private MySql.Data.MySqlClient.MySqlConnection myconn;
        string strconn =
            "Server=cipweb.com.br;Database=citeluz;Uid=marcelo;Pwd=0830@rnmf;pooling=false;";

        MySqlCommand mycommand;        
        MySqlTransaction mytrans;
        String insert;
        string codTrafo = "";
        string codPlaqueta = "";
        int codMaterial = 0;

        private void verificaConnMysql()
        {
            if (myconn.State == ConnectionState.Closed)
            {
                try
                {
                    myconn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void enviarButton_Click(object sender, EventArgs e)
        {
            if (myconn != null)
            {
                verificaConnMysql();
            }
            else
            {
                MessageBox.Show("Não foi possível sincronizar, sem conexão.");
                return;
            }

            //login web
            MysqlLoginDialog mld = new MysqlLoginDialog(myconn);
            mld.ShowDialog();
            if (!Usuario.Logado)
            {
                return;
            }

            //VERIFICA CONEXAO
            verificaConnMysql();


            //INSERE TRAFOS
            if (checkTodos.Checked)
            {
                trafoTableAdapter.Fill(citeluzDataSet.trafo);
            }
            else
            {
                DataRowView row =
                    (DataRowView)trafoBindingSource.Current;
                trafoTableAdapter.FillBy(citeluzDataSet.trafo, (string)row["cod_trafo"]);
            }

            //verifica duplicidade
            string duplicidade = "SELECT plaqueta_trafo, nome_lote FROM trafo " +
                "WHERE plaqueta_trafo IN (";
            string dupli_plaqueta = "SELECT plaqueta_id, nome_lote FROM plaqueta " +
                "WHERE plaqueta_id IN (";

            string dtmp = "";
            foreach (DataRow row in citeluzDataSet.trafo.Rows)
            {
                dtmp = dtmp + "'" + row["plaqueta_trafo"] + "',";
            }
            dtmp = dtmp.Remove(dtmp.Length - 1, 1); //remove a virgula no final
            duplicidade = duplicidade + dtmp + ") ";
            duplicidade = duplicidade + " AND nome_lote = '" + txtNomeLote.Text + "'";

            dtmp = "";
            foreach (DataRow row in citeluzDataSet.plaqueta.Rows)
            {
                dtmp = dtmp + "'" + row["plaqueta_id"] + "',";
            }
            dtmp = dtmp.Remove(dtmp.Length - 1, 1); //remove a virgula no final
            dupli_plaqueta = dupli_plaqueta + dtmp + ") ";
            dupli_plaqueta = dupli_plaqueta + " AND nome_lote = '" + txtNomeLote.Text + "'";

            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            //GERAR LOG DOS DUPLICADOS PARA FACILITAR CONFERENCIA
            Directory.CreateDirectory(Library.appDir + "\\log");
            Application.DoEvents();
            string logPath =
                Library.appDir + "\\log\\dupli_" + txtNomeLote.Text + ".txt";
            TextWriter id = new StreamWriter(logPath);
            id.WriteLine("Duplicidades em Trafos:");
            id.WriteLine("----------------------------------");

            mycommand = myconn.CreateCommand();
            mycommand.Connection = myconn;

            mycommand.CommandText = duplicidade;
            MySqlDataReader mydr = mycommand.ExecuteReader();
            while (mydr.Read())
            {
                string trafo = mydr.GetString("plaqueta_trafo");
                listBox1.Items.Add("Duplicidade "+trafo);
                id.WriteLine(trafo);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                Application.DoEvents();
            }
            mydr.Close();
            mycommand.CommandText = dupli_plaqueta;
            MySqlDataReader mydr_plaqueta = mycommand.ExecuteReader();
            id.WriteLine(" ");
            id.WriteLine("Duplicidades em Plaquetas:");
            id.WriteLine("----------------------------------");
            while (mydr_plaqueta.Read())
            {
                string plaqueta = mydr_plaqueta.GetString("plaqueta_id");
                listBox1.Items.Add("Duplicidade " + plaqueta);
                id.WriteLine(plaqueta);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                Application.DoEvents();
            }
            id.Flush();
            id.Close();
            if (mydr.HasRows || mydr_plaqueta.HasRows)
            {
                MessageBox.Show("Há duplicidades no arquivo que esta sendo lançado. Duplicidades salvas em \\log\\dupli_lote.txt");
                myconn.Close();
                return;
            }
            myconn.Close();
            Application.DoEvents();
            myconn.Open();
            mycommand.Transaction = mytrans;
            mytrans = myconn.BeginTransaction();

            //insere trafos
            foreach (DataRow row in citeluzDataSet.trafo.Rows)
            {
                insert = "INSERT INTO trafo (";
                foreach (DataColumn column in citeluzDataSet.trafo.Columns)
                {
                    if (column.ColumnName.Equals("user"))
                    {
                        insert = insert + "usuario_fk,";
                    }
                    else
                    {
                        insert = insert + column.ColumnName + ",";
                    }
                }
                insert = insert + "nome_lote,";
                insert = insert.Remove(insert.Length - 1, 1);
                insert = insert + ") VALUES (";

                foreach (DataColumn column in citeluzDataSet.trafo.Columns)
                {
                    object valor = row[column.ColumnName];
                    

                    if (column.ColumnName.Equals("plaqueta_trafo"))
                    {
                        codTrafo = (string)valor;
                    }

                    if (column.DataType == typeof(string))
                    {
                        valor = Library.removeCrase(valor.ToString());
                        valor = "'" + valor + "'";
                    }
                    else
                    {
                        if (valor.ToString().Length == 0)
                        {
                            valor = "null";
                        }
                    }
                    insert = insert + valor + ",";
                }
                insert = insert + "'" + txtNomeLote.Text.Trim().ToUpper() + "',";
                insert = insert.Remove(insert.Length - 1, 1);
                insert = insert + ");";

                //insere trafos
                try
                {
                    mycommand.CommandText = insert;
                    mycommand.ExecuteNonQuery();

                    listBox1.Items.Add("Projeto " + codTrafo + " enviado");
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    Application.DoEvents();

                    //INSERE PLAQUETAS
                    this.plaquetaTableAdapter.Fill(citeluzDataSet.plaqueta, codTrafo);
                    foreach (DataRow rowPlaqueta in citeluzDataSet.plaqueta.Rows)
                    {

                        insert = "INSERT INTO plaqueta (";
                        foreach (DataColumn column in citeluzDataSet.plaqueta.Columns)
                        {
                            insert = insert + column.ColumnName + ",";
                        }
                        insert = insert + "nome_lote,";
                        insert = insert.Remove(insert.Length - 1, 1);
                        insert = insert + ") VALUES (";

                        foreach (DataColumn column in citeluzDataSet.plaqueta.Columns)
                        {
                            object valor = rowPlaqueta[column.ColumnName];


                            if (column.ColumnName.Equals("plaqueta_id"))
                            {
                                codPlaqueta = (string)valor;
                            }

                            if (column.DataType == typeof(string))
                            {
                                valor = Library.removeCrase(valor.ToString());
                                valor = "'" + valor + "'";
                            }
                            else
                            {
                                if (valor.ToString().Length == 0)
                                {
                                    valor = "null";
                                }
                            }
                            insert = insert + valor + ",";
                        }
                        insert = insert + "'" + txtNomeLote.Text.Trim().ToUpper() + "',";
                        insert = insert.Remove(insert.Length - 1, 1);
                        insert = insert + ");";

                        try
                        {
                            mycommand.CommandText = insert;
                            mycommand.ExecuteNonQuery();

                            listBox1.Items.Add("Plaqueta " + codPlaqueta + " enviada");
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            Application.DoEvents();

                            //insere MATERIAL
                            this.materialTableAdapter.Fill(citeluzDataSet.material, codPlaqueta);
                            foreach (DataRow rowMaterial in citeluzDataSet.material.Rows)
                            {

                                insert = "INSERT INTO material (";
                                foreach (DataColumn column in citeluzDataSet.material.Columns)
                                {
                                    if (!column.ColumnName.Equals("id"))
                                    {
                                        insert = insert + column.ColumnName + ",";
                                    }
                                }
                                insert = insert + "nome_lote,";
                                insert = insert.Remove(insert.Length - 1, 1);
                                insert = insert + ") VALUES (";

                                foreach (DataColumn column in citeluzDataSet.material.Columns)
                                {
                                    object valor = rowMaterial[column.ColumnName];


                                    if (column.ColumnName.Equals("id"))
                                    {
                                        codMaterial = (int)valor;
                                    }

                                    if (column.DataType == typeof(string))
                                    {
                                        valor = Library.removeCrase(valor.ToString());
                                        valor = "'" + valor + "'";
                                    }
                                    else
                                    {
                                        if (valor.ToString().Length == 0)
                                        {
                                            valor = "null";
                                        }
                                    }
                                    if (!column.ColumnName.Equals("id"))
                                    {
                                        insert = insert + valor + ",";
                                    }
                                }
                                insert = insert + "'" + txtNomeLote.Text.Trim().ToUpper() + "',";
                                insert = insert.Remove(insert.Length - 1, 1);
                                insert = insert + ");";


                                try
                                {
                                    mycommand.CommandText = insert;
                                    mycommand.ExecuteNonQuery();

                                    listBox1.Items.Add("Material " + codMaterial + " enviada");
                                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                                    Application.DoEvents();
                                }
                                catch (Exception ex)
                                {
                                    mytrans.Rollback();
                                    myconn.Close();
                                    MessageBox.Show(ex.Message);
                                    listBox1.Items.Add(ex.Message);
                                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                                    trafoTableAdapter.Fill(citeluzDataSet.trafo);
                                    Cursor.Current = Cursors.Default;
                                    Application.DoEvents();
                                    return;
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            mytrans.Rollback();
                            myconn.Close();
                            MessageBox.Show(ex.Message);
                            listBox1.Items.Add(ex.Message);
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            trafoTableAdapter.Fill(citeluzDataSet.trafo);
                            Cursor.Current = Cursors.Default;
                            Application.DoEvents();
                            return;
                        }
                    }            
                }
                catch (Exception ex)
                {
                    mytrans.Rollback();
                    myconn.Close();
                    MessageBox.Show(ex.Message);
                    listBox1.Items.Add(ex.Message);
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    trafoTableAdapter.Fill(citeluzDataSet.trafo);
                    Cursor.Current = Cursors.Default;
                    Application.DoEvents();
                    return;
                }
            }

            mytrans.Commit();
            myconn.Close();
            listBox1.Items.Add("Envio completo.");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void checkTodos_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void ExportaDados_Closing(object sender, CancelEventArgs e)
        {
            if (myconn.State == ConnectionState.Open)
                myconn.Close();
        }
    }
}