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
    public partial class MysqlLoginDialog : CIPDialog
    {
        private MySql.Data.MySqlClient.MySqlConnection myconn;

        public MysqlLoginDialog(MySqlConnection conn)
        {
            this.myconn = conn;
            InitializeComponent();
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width / 2) - (Width / 2),
                (Screen.PrimaryScreen.Bounds.Height / 2) - (Height / 2));
        }

        //private void InitializeComponent()
        //{
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        MySqlCommand mycommand;

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            Usuario.MysqlUser = textBoxUser.Text;
            Usuario.MysqlSenha = textBoxSenha.Text;

            if (Usuario.MysqlUser != null && Usuario.MysqlUser.Length > 0)
            {
                if (myconn.State == ConnectionState.Closed)
                    myconn.Open();

                string sql = "select count(*) from usuarios where usuario=@usuario and senha=md5(@senha)";

                mycommand = myconn.CreateCommand();
                mycommand.Connection = myconn;
                mycommand.CommandText = sql;
                mycommand.Parameters.Clear();
                mycommand.Parameters.AddWithValue("usuario", Usuario.MysqlUser);
                mycommand.Parameters.AddWithValue("senha", Usuario.MysqlSenha);
                object reader = mycommand.ExecuteScalar();

                if (Convert.ToInt32(reader) == 1)
                {
                    Usuario.Logado = true;
                    //listBox1.Items.Add("Login feito com sucesso!");
                    //listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    //Application.DoEvents();
                }
                else
                {
                    Usuario.Logado = false;
                    //listBox1.Items.Add("Login falhou. Desconectando...");
                    //listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    myconn.Close();
                    //Application.DoEvents();
                    return;
                }

                Usuario.MysqlUser = "";
                Usuario.MysqlSenha = "";
            }

            Cursor.Current = Cursors.Default;
            Application.DoEvents();

            this.Close();
        }

        private void MysqlLoginDialog_Closing(object sender, CancelEventArgs e)
        {
            if (myconn.State == ConnectionState.Open)
                myconn.Close();
        }
    }
}