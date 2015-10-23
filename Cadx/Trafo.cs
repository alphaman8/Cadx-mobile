using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Cadx
{
    public partial class Trafo : CIPFormGPS
    {
        //public static SqlCeConnection sqlConnCiteluz = new SqlCeConnection("Data Source ="
        //+ (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        //+ "\\db\\citeluz.sdf; Password=mfrn@0830$X-PRO;"));

        public Trafo()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Trafo_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("cod");
            dt.Columns.Add("name");
            dt.Rows.Add(0, "");
            dt.Rows.Add(1, "CONCESSIONÁRIA");
            dt.Rows.Add(2, "EXCL. IP");
            cod_proprietarioComboBox.ValueMember = "cod";
            cod_proprietarioComboBox.DisplayMember = "name";
            cod_proprietarioComboBox.DataSource = dt;


            // TODO: This line of code loads data into the 'citeluzDataSet.trafo' table. You can move, or remove it, as needed.
            this.trafoTableAdapter.Fill(this.citeluzDataSet.trafo);

            totalLabel.Text = "Total trafos: " + trafoBindingSource.Count;
            totalPlaquetaLabel.Text = "Total plaquestas: " + this.plaquetaTableAdapter.Total();
            totalMaterialLabel.Text = "Total material: " + this.materialTableAdapter.Total();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                trafoBindingSource.CancelEdit();
                trafoBindingSource.AddNew();
                userTextBox.Text = Usuario.MysqlUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            plaqueta_trafoTextBox.Focus();

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                this.trafoBindingSource.EndEdit();
                db.citeluzDataSet changes = (db.citeluzDataSet)this.citeluzDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["trafo"];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = trafoTableAdapter.Update(changes);
                    this.citeluzDataSet.AcceptChanges();
                    MessageBox.Show("Informações salvas com sucesso!");
                    //this.trafoTableAdapter.Fill(citeluzDataSet.trafo);
                    //DesconectarTrimble();
                }
                else
                {
                    string errorMsg = null;
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg += row.GetColumnError(col) + "\n";
                        }
                    }
                    MessageBox.Show("Erros nos dados: " + errorMsg, "", MessageBoxButtons.OK,
                                    MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                citeluzDataSet.RejectChanges();
            }
        }

        public static string trafo;

        private void menuItem7_Click(object sender, EventArgs e)
        {
            trafo = plaqueta_trafoTextBox.Text;
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            Plaqueta p = new Plaqueta();
            p.ShowDialog();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            DataRowView row =
                (DataRowView)trafoBindingSource.Current;

            trafo = (string)row["cod_trafo"];
            string plaqueta = (string)row["plaqueta_trafo"];

            if ((MessageBox.Show("Certeza ao excluir trafo: " + trafo + "?", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK))
            {
                try
                {
                    trafoTableAdapter.Delete(trafo, plaqueta);
                    //projetoTableAdapter.Update(lptDataSet.projeto);
                    citeluzDataSet.AcceptChanges();
                    trafoTableAdapter.Fill(citeluzDataSet.trafo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar: " + ex.Message);
                }
            }
        }
    }
}