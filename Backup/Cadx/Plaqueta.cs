using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cadx
{
    public partial class Plaqueta : CIPFormGPS
    {
        public Plaqueta()
        {
            InitializeComponent();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void Plaqueta_Load(object sender, EventArgs e)
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


            DataTable dt1 = new DataTable();
            dt1.Columns.Add("cod");
            dt1.Columns.Add("name");
            dt1.Rows.Add("", "");
            dt1.Rows.Add("BOI", "Medidor");
            dt1.Rows.Add("CM", "Chave Magnética");
            dt1.Rows.Add("TRA", "Transformador");
            tipo_alimentacaoComboBox.ValueMember = "cod";
            tipo_alimentacaoComboBox.DisplayMember = "name";
            tipo_alimentacaoComboBox.DataSource = dt1;

            DataTable dt4 = new DataTable();
            dt4.Columns.Add("cod");
            dt4.Columns.Add("name");
            dt4.Rows.Add("", "");
            dt4.Rows.Add("AC", "AÉREO CONVENCIONAL");
            dt4.Rows.Add("AM", "AÉREO MULTIPLEXADO");
            dt4.Rows.Add("DAT", "MULTIPLEXADO ( REDE DAT )");
            dt4.Rows.Add("PP", "CABO WPP");
            dt4.Rows.Add("S", "SUBTERRÂNEO");
            cod_caboComboBox.ValueMember = "cod";
            cod_caboComboBox.DisplayMember = "name";
            cod_caboComboBox.DataSource = dt4;

            //POSTE
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("cod");
            dt3.Columns.Add("name");
            dt3.Rows.Add("", "");
            dt3.Rows.Add("ABO1", "AÇO BASE OCTOGONAL ATÉ 5 M");
            dt3.Rows.Add("ABO2", "AÇO BASE OCTOGONAL DE 5 A 10 M");
            dt3.Rows.Add("ABO3", "AÇO BASE OCTOGONAL DE 11 A 14 M");
            dt3.Rows.Add("ABO4", "AÇO BASE OCTOGONAL DE 15 A 17 M");
            dt3.Rows.Add("ABR1", "AÇO BASE REDONDO ATÉ 5 M");
            dt3.Rows.Add("ABR2", "AÇO BASE REDONDO DE 5 A 10 M");
            dt3.Rows.Add("ABR3", "AÇO BASE REDONDO DE 11 A 14 M");
            dt3.Rows.Add("ABR4", "AÇO BASE REDONDO DE 15 A 17 M");
            dt3.Rows.Add("ABT1", "AÇO BASE TELECÔNICO ATÉ 5 M");
            dt3.Rows.Add("ABT2", "AÇO BASE TELECÔNICO DE 5 A 10 M");
            dt3.Rows.Add("ABT3", "AÇO BASE TELECÔNICO DE 11 A 14 M");
            dt3.Rows.Add("ABT4", "AÇO BASE TELECÔNICO DE 15 A 17 M");
            dt3.Rows.Add("AEO1", "AÇO ENGASTADO OCTOGONAL ATÉ 5 M");
            dt3.Rows.Add("AEO2", "AÇO ENGASTADO OCTOGONAL DE 5 A 10 M");
            dt3.Rows.Add("AEO3", "AÇO ENGASTADO OCTOGONAL DE 11 A 14 M");
            dt3.Rows.Add("AEO4", "AÇO ENGASTADO OCTOGONAL DE 15 A 17 M");
            dt3.Rows.Add("AEQ1", "AÇO ENGASTADO QUAD ATÉ 5 M");
            dt3.Rows.Add("AEQ2", "AÇO ENGASTADO QUAD DE 5 A 10 M");
            dt3.Rows.Add("AER1", "AÇO ENGASTADO REDONDO ATÉ 5 M");
            dt3.Rows.Add("AER2", "AÇO ENGASTADO REDONDO DE 5 A 10 M");
            dt3.Rows.Add("AER3", "AÇO ENGASTADO REDONDO DE 11 A 14 M");
            dt3.Rows.Add("AER4", "AÇO ENGASTADO REDONDO DE 15 A 17 M");
            dt3.Rows.Add("AER5", "ACERO ENGASTADO REDONDO DE 18 A 25 M");
            dt3.Rows.Add("AET1", "AÇO ENGASTADO TELECÔNICO ATÉ 5 M");
            dt3.Rows.Add("AET2", "AÇO ENGASTADO TELECÔNICO DE 5 A 10 M");
            dt3.Rows.Add("AET3", "AÇO ENGASTADO TELECÔNICO DE 11 A 14 M");
            dt3.Rows.Add("AET4", "AÇO ENGASTADO TELECÔNICO DE 15 A 17 M");
            dt3.Rows.Add("CQD2", "CONCRETO DUPLO T DE 5 A 10 M");
            dt3.Rows.Add("CQD3", "CONCRETO DUPLO T DE 11 A 14 M");
            dt3.Rows.Add("CQD4", "CONCRETO DUPLO T DE 15 A 17 M");
            dt3.Rows.Add("CRE1", "CONCRETO REDONDO ATÉ 5 M");
            dt3.Rows.Add("CRE2", "CONCRETO REDONDO DE 5 A 10 M");
            dt3.Rows.Add("CRE3", "CONCRETO REDONDO DE 11 A 14 M");
            dt3.Rows.Add("CRE4", "CONCRETO REDONDO DE 15 A 17 M");
            dt3.Rows.Add("CRE5", "CONCRETO REDONDO DE 18 A 25M");
            dt3.Rows.Add("FEF1", "FERRO FUNDIDO ATÉ 5 M");
            dt3.Rows.Add("FEF2", "FERRO FUNDIDO DE 5 A 10 M");
            dt3.Rows.Add("FEF3", "FERRO FUNDIDO DE 11 A 14 M");
            dt3.Rows.Add("FEF4", "FERRO FUNDIDO DE 15 A 17 M");
            dt3.Rows.Add("FVR1", "FIBRA DE VIDRO REDONDO ATÉ 5M");
            dt3.Rows.Add("FVR2", "FIBRA DE VIDRO REDONDO DE 5M A 10M");
            dt3.Rows.Add("FVR3", "FIBRA DE VIDRO REDONDO DE 11M A 14M");
            dt3.Rows.Add("FVR4", "FIBRA DE VIDRO REDONDO DE 15M A 17M");
            dt3.Rows.Add("MAD1", "MADEIRA ATÉ 5 M");
            dt3.Rows.Add("MAD2", "MADEIRA DE 5 A 10 M");
            dt3.Rows.Add("SPO", "SEM POSTE");
            cod_posteComboBox.ValueMember = "cod";
            cod_posteComboBox.DisplayMember = "name";
            cod_posteComboBox.DataSource = dt3;


            // TODO: This line of code loads data into the 'citeluzDataSet.plaqueta' table. You can move, or remove it, as needed.
            this.plaquetaTableAdapter.Connection.Open();
            this.plaquetaTableAdapter.Fill(this.citeluzDataSet.plaqueta, Trafo.trafo);

            ordem += maiorOrdem(this.citeluzDataSet.plaqueta);

            totalLabel.Text = "Total: " + plaquetaBindingSource.Count;

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        int ordem = 0;

        private int maiorOrdem(Cadx.db.citeluzDataSet.plaquetaDataTable table)
        {
            foreach (Cadx.db.citeluzDataSet.plaquetaRow row in table)
            {
                if (ordem < row.ordem)
                {
                    ordem = row.ordem;
                }
            }
            return ordem;
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();


            try
            {
                plaquetaBindingSource.CancelEdit();
                plaquetaBindingSource.AddNew();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            trafo_plaquetaTextBox.Focus();
            cod_caboComboBox.SelectedIndex = 0;

            cod_proprietarioComboBox.SelectedIndex = 0;
            cod_posteComboBox.SelectedIndex = 0;
            trafo_plaquetaTextBox.Text = Trafo.trafo;
            ordem = ordem+1;
            ordemTextBox.Text = "" + ordem;           

            //ConectarTrimbleSimulacao();
            ConectarTrimble();

            //BLOQUEIO DE COMPONENTES PARA EVITAR TRAVAMENTOS
            plaquetaDataGrid.Enabled = false;
            menuItem10.Enabled = false;
            tabControl1.SelectedIndex = 1;
            //-------------------

            //REPETE INFORMACOES DA ULTIMA LINHA INSERIDA
            if (rowLast != null)
            {
                bairroTextBox.Text = rowLast.bairro;
                logradouroTextBox.Text = rowLast.logradouro;

                setItem(cod_proprietarioComboBox, rowLast.cod_proprietario);
                setItem(cod_posteComboBox, rowLast.cod_poste);
                setItem(cod_caboComboBox, rowLast.cod_cabo);
                setItem(tipo_alimentacaoComboBox, rowLast.tipo_alimentacao); ;
                //cod_posteComboBox.SelectedValue = rowLast.cod_poste;
                //cod_proprietarioComboBox.SelectedValue = rowLast.cod_proprietario;
                //cod_caboComboBox.SelectedValue = rowLast.cod_cabo;
                //tipo_alimentacaoComboBox.SelectedValue = rowLast.tipo_alimentacao;
                //medidoCheck.Checked = Convert.ToBoolean(rowLast.medido);
                //medidorTextBox.Text = rowLast.medidor;
            }

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void setItem(ComboBox cb, string value)
        {
            foreach (object item in cb.Items)
            {
                DataRowView row = item as DataRowView;
                if ((String)row["cod"] == value)
                {
                    cb.SelectedItem = item;
                }
            }
        }

        DateTime gpsTime = new DateTime();
        int quantPosicoes = 5;

        public override void statusTrimble()
        {
            if (pos == null)
            {
                if (menuItem3.Enabled)
                {
                    menuItem3.Enabled = false;
                }
                return;
            }

            gpsTime = pos.GPSTime;

            lat = Convert.ToString(pos.Latitude);
            lon = Convert.ToString(pos.Longitude);

            xTextBox.Text = Convert.ToString(pos.Latitude);
            yTextBox.Text = Convert.ToString(pos.Longitude);
            txtSatelites.Text = Convert.ToString(pos.NumberOfSatellites);
            double acc = Math.Round(pos.EstimatedAccuracy, 2);
            txtAcc.Text =
                Convert.ToString(acc) + " metros";

            string status = gpsTrimbleStatus;

            if (status.Contains("tracking"))
            {
                status = "Pesquisando por satelites";
            }

            txtStatus.Text = "Situação: " + status;

            if (acc < 15)
            {
                txtStatus.Text = "Acurácia permitida";
                if (!menuItem3.Enabled)
                {
                    menuItem3.Enabled = true;
                    menuItem3.Text = "Salvar";
                    MessageBeep();
                }
            }
        }

        private db.citeluzDataSet.plaquetaRow rowLast = null;

        private void menuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                this.plaquetaBindingSource.EndEdit();
                db.citeluzDataSet changes = (db.citeluzDataSet)this.citeluzDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["plaqueta"];
                rowLast = (db.citeluzDataSet.plaquetaRow)dt.Rows[dt.Rows.Count-1];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = plaquetaTableAdapter.Update(changes);
                    this.citeluzDataSet.AcceptChanges();
                    plaquetaTableAdapter.Fill(citeluzDataSet.plaqueta, Trafo.trafo);
                    MessageBox.Show("Informações salvas com sucesso! ");
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
                //citeluz2DataSet.RejectChanges();
            }
            
            DesconectarTrimble();
            //BLOQUEIO DE COMPONENTES PARA EVITAR TRAVAMENTOS
            plaquetaDataGrid.Enabled = true;
            menuItem10.Enabled = true;
            tabControl1.SelectedIndex = 0;
            //-------------------
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            plaqueta = plaqueta_idTextBox.Text;
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            Material m = new Material();
            m.ShowDialog();
        }

        public static string plaqueta;

        private void menuItem9_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
            ConectarTrimble();
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            DataRowView row =
                (DataRowView)plaquetaBindingSource.Current;

            plaqueta = (string)row["plaqueta_id"];

            if ((MessageBox.Show("Certeza ao excluir plaqueta: " + plaqueta + "?", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK))
            {
                try
                {
                    plaquetaTableAdapter.Delete(plaqueta);
                    //projetoTableAdapter.Update(lptDataSet.projeto);
                    citeluzDataSet.AcceptChanges();
                    plaquetaTableAdapter.Fill(citeluzDataSet.plaqueta, Trafo.trafo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar: " + ex.Message);
                }
            }
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.plaquetaTableAdapter.Fill(this.citeluzDataSet.plaqueta, trafo_plaquetaTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}