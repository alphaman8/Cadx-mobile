using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadx
{
    public partial class LoginDialog : CIPDialog
    {
        private MySql.Data.MySqlClient.MySqlConnection myconn;
        string strconn =
            "Server=cipweb.com.br;Database=citeluz;Uid=marcelo;Pwd=0830@rnmf;pooling=false;";

        public LoginDialog()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) - (Width / 2),
                (Screen.PrimaryScreen.Bounds.Height / 2) - (Height / 2));
            BackColor = Color.Green;

            myconn = new MySqlConnection(strconn);
            //myconn.StateChange += new StateChangeEventHandler(myconn_StateChange);
        }

        //private void InitializeComponent()
        //{
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario.Logado = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario.MysqlUser = textBoxUser.Text;
            Usuario.MysqlSenha = textBoxSenha.Text;

            //validar usuario mobile
            foreach (db.usersDataSet.usuariosRow row in usersDataSet.usuarios.Rows)
            {
                if (row.user.Equals(Usuario.MysqlUser) &&
                    row.password.Equals(Usuario.MysqlSenha))
                {
                    Usuario.Logado = true;
                    break;
                }
                else
                {
                    Usuario.Logado = false;
                }
            }

            if (!Usuario.Logado)
            {
                MessageBox.Show("Usuário não encontrado");
            }
            else
            {
                this.Close();
            }

        }

        MySqlCommand mycommand;

        private void button3_Click(object sender, EventArgs e)
        {
            MysqlLoginDialog mld = new MysqlLoginDialog(myconn);
            mld.ShowDialog();
            if (!Usuario.Logado)
            {
                Close();
            }

            MessageBox.Show("O sistema atualizará a tabela de usuários");

            if (myconn.State == ConnectionState.Closed)
                myconn.Open();

            string sql = "select * from usuarios";

            mycommand = myconn.CreateCommand();
            mycommand.Connection = myconn;
            mycommand.CommandText = sql;
            MySqlDataReader reader = mycommand.ExecuteReader();
            
            //INSERE OS USUARIO TRAZIDOS DA WEB
            //this.usuariosBindingSource.EndEdit();
            //db.usersDataSet changes = (db.usersDataSet)this.usersDataSet.GetChanges();

           //if (changes == null)
           // {
           //     MessageBox.Show("Não há modificações a serem salvas");
           //     return;
           // }

            //DataTable dt = changes.Tables["usuarios"];
            //db.usersDataSet.usuariosRow r = (db.usersDataSet.usuariosRow)dt.Rows[0];
            //DataRow[] badRows = dt.GetErrors();

            usersDataSet.usuarios.Rows.Clear();
            usersDataSet.AcceptChanges();

            while (reader.Read())
            {
                try
                {
                    usuariosBindingSource.CancelEdit();
                    usuariosBindingSource.AddNew();

                    DataRowView drv = (DataRowView)usuariosBindingSource.Current;
                    drv["user"] = reader.GetString("usuario");
                    drv["password"] = reader.GetString("senha_mobile");

                    this.usuariosBindingSource.EndEdit();
                    db.usersDataSet changes = (db.usersDataSet)this.usersDataSet.GetChanges();
                    int numRows = usuariosTableAdapter.Update(changes); 
                    this.usersDataSet.AcceptChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            MessageBox.Show("Usuários atualizados com sucesso");


        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.usersDataSet.usuarios);
            //MessageBox.Show(usersDataSet.usuarios.Rows.Count + "");

        }
    }
}