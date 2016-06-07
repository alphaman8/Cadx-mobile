using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace Cadx
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            LoginDialog l = new LoginDialog();
            l.ShowDialog();

            InitializeComponent();

            if (!Usuario.Logado)
            {
                this.Close();
            }
        }

        #region VERIFICA AUTENCIDADE DO SISTEMA PELO SERIAL

        private string serialPath = Library.appDir + "\\conf\\serial";
        //private string idPath = Library.appDir + "\\conf\\id.txt";

        private bool verificaSerialFile()
        {
            if (File.Exists(serialPath))
            {
                //read serial file to validation
                TextReader reader = new StreamReader(serialPath);
                string serial = reader.ReadLine();

                if (!Library.IsNullOrEmpty(serial))
                {
                    try
                    {
                        string dec = Encrypt.DecryptString(serial, "sairaf@380");
                        if (Usuario.IdDevice.Equals(dec))
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                //CIPSerialForm sf = new CIPSerialForm();
                //sf.ShowDialog();
                //sf.Dispose();
            }
            else
            {
                //CIPSerialForm sf = new CIPSerialForm();
                //sf.ShowDialog();
                //sf.Dispose();
            }

            return false;
        }

        #endregion   

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            Trafo t = new Trafo();
            t.ShowDialog();
        }

        private void Exporta_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            ExportaDados t = new ExportaDados();
            t.ShowDialog();
        }

        private void buttonImage1_Click(object sender, EventArgs e)
        {
            /*
             * Verificar se existe coluna e inserir caso n exista
             * garantir compatibilidade com bancos velhos
             */
            //CONN
            SqlCeConnection conn = 
                new SqlCeConnection("Data Source = " + Library.appDir + "\\db\\citeluz.sdf; Password=mfrn@0830$X-PRO;");            

            //coluna user     
            conn.Open();
            SqlCeCommand command = conn.CreateCommand();
            command.CommandText = "ALTER TABLE trafo ADD [user] NVARCHAR(15) DEFAULT 'TESTE';";
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Tabela trafo atualizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}