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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            DataTable dt13 = new DataTable();
            dt13.Columns.Add("cod");
            dt13.Columns.Add("name");
            dt13.Rows.Add("0", "");
            dt13.Rows.Add("F10", "FLUORESCENTE 10 W");
            dt13.Rows.Add("F11", "FLUORESCENTE 11 W");
            dt13.Rows.Add("F110", "FLUORESCENTE 110 W");
            dt13.Rows.Add("F12", "FLUORESCENTE 12 W");
            dt13.Rows.Add("F14", "FLUORESCENTE 14 W");
            dt13.Rows.Add("F15", "FLUORESCENTE 15 W");
            dt13.Rows.Add("F16", "FLUORESCENTE 16 W");
            dt13.Rows.Add("F18", "FLUORESCENTE 18 W");
            dt13.Rows.Add("F20", "FLUORESCENTE 20 W");
            dt13.Rows.Add("F21", "FLUORESCENTE 21 W");
            dt13.Rows.Add("F23", "FLUORESCENTE 23 W");
            dt13.Rows.Add("F25", "FLUORESCENTE 25 W");
            dt13.Rows.Add("F26", "FLUORESCENTE 26 W");
            dt13.Rows.Add("F28", "FLUORESCENTE 28 W");
            dt13.Rows.Add("F30", "FLUORESCENTE 30 W");
            dt13.Rows.Add("F32", "FLUORESCENTE 32 W");
            dt13.Rows.Add("F35", "FLUORESCENTE 35 W");
            dt13.Rows.Add("F36", "FLUORESCENTE 36 W");
            dt13.Rows.Add("F40", "FLUORESCENTE 40 W");
            dt13.Rows.Add("F45", "FLUORESCENTE 45 W");
            dt13.Rows.Add("F5", "FLUORESCENTE 5 W");
            dt13.Rows.Add("F58", "FLUORESCENTE 58 W");
            dt13.Rows.Add("F65", "FLUORESCENTE 65 W");
            dt13.Rows.Add("F7", "FLUORESCENTE 7 W");
            dt13.Rows.Add("F75", "FLUORESCENTE 75 W");
            dt13.Rows.Add("FC10", "FLUOR COMPACTA 10 W");
            dt13.Rows.Add("FC11", "FLUOR COMPACTA 11W");
            dt13.Rows.Add("FC13", "FLUOR COMPACTA 13W");
            dt13.Rows.Add("FC14", "FLUOR COMPACTA 14W");
            dt13.Rows.Add("FC15", "FLUOR COMPACTA 15W");
            dt13.Rows.Add("FC16", "FLUOR COMPACTA 16W");
            dt13.Rows.Add("FC18", "FLUOR COMPACTA 18W");
            dt13.Rows.Add("FC20", "FLUOR COMPACTA 20W");
            dt13.Rows.Add("FC23", "FLUOR COMPACTA 23W");
            dt13.Rows.Add("FC26", "FLUOR COMPACTA 26W");
            dt13.Rows.Add("FC36", "FLUOR COMPACTA 36W");
            dt13.Rows.Add("FC46", "FLUOR COMPACTA 46W");
            dt13.Rows.Add("FC5", "FLUOR COMPACTA 5W");
            dt13.Rows.Add("FC55", "FLUOR COMPACTA 55W");
            dt13.Rows.Add("FC65", "FLUOR COMPACTA 65W");
            dt13.Rows.Add("FC7", "FLUOR COMPACTA 7 W");
            dt13.Rows.Add("FC9", "FLUOR COMPACTA 9W");
            dt13.Rows.Add("H100", "HALOGENA PALITO 100 W");
            dt13.Rows.Add("H1000", "HALOGENA PALITO 1000 W");
            dt13.Rows.Add("H120", "HALOGENA PALITO 120 W");
            dt13.Rows.Add("H150", "HALOGENA PALITO 150 W");
            dt13.Rows.Add("H1500", "HALOGENA PALITO 1500 W");
            dt13.Rows.Add("H200", "HALOGENA PALITO 200 W");
            dt13.Rows.Add("H2000", "HALOGENA PALITO 2000 W");
            dt13.Rows.Add("H300", "HALOGENA PALITO 300 W");
            dt13.Rows.Add("H35", "HALOGENA DICROICA 35 W");
            dt13.Rows.Add("H45", "HALOGENA DICROICA 45 W");
            dt13.Rows.Add("H50", "HALOGENA DICROICA 50 W");
            dt13.Rows.Add("H500", "HALOGENA PALITO 500 W");
            dt13.Rows.Add("H75", "HALOGENA DICROICA 75 W");
            dt13.Rows.Add("H80", "HALOGENA PALITO 80W");
            dt13.Rows.Add("I100", "INCANDESCENTE 100 W");
            dt13.Rows.Add("I15", "INCANDESCENTE 15 W");
            dt13.Rows.Add("I150", "INCANDESCENTE 150 W");
            dt13.Rows.Add("I200", "INCANDESCENTE 200 W");
            dt13.Rows.Add("I25", "INCANDESCENTE 25 W");
            dt13.Rows.Add("I250", "INCANDESCENTE 250 W");
            dt13.Rows.Add("I260", "INCANDESCENTE 260 W");
            dt13.Rows.Add("I300", "INCANDESCENTE 300 W");
            dt13.Rows.Add("I40", "INCANDESCENTE 40 W");
            dt13.Rows.Add("I400", "INCANDESCENTE 400 W");
            dt13.Rows.Add("I50", "INCANDESCENTE 50 W");
            dt13.Rows.Add("I500", "INCANDESCENTE 500 W");
            dt13.Rows.Add("I60", "INCANDESCENTE 60 W");
            dt13.Rows.Add("I70", "INCANDESCENTE 70 W");
            dt13.Rows.Add("I80", "INCANDESCENTE 80 W");
            dt13.Rows.Add("L1", "LAMP XENON 1W");
            dt13.Rows.Add("L1.5", "LED 1.5 W");
            dt13.Rows.Add("L17", "MICRO LAMP XENON 17W");
            dt13.Rows.Add("L2", "LED 2 W");
            dt13.Rows.Add("L290", "LED 290W");
            dt13.Rows.Add("L30", "LED 30 W");
            dt13.Rows.Add("L35", "LED 35W");
            dt13.Rows.Add("L5", "LAMP XENON 5W");
            dt13.Rows.Add("L50", "LED 50W");
            dt13.Rows.Add("L53", "LED 53W");
            dt13.Rows.Add("L70", "LED 70W");
            dt13.Rows.Add("L9", "LED 9 W");
            dt13.Rows.Add("LS1", "LED VERMELHO SEMAFORO");
            dt13.Rows.Add("LS2", "LED AMARELO SEMAFORO");
            dt13.Rows.Add("LS3", "LED VERDE  SEMAFORO");
            dt13.Rows.Add("M1000", "MERCURIO 1000 W");
            dt13.Rows.Add("M125", "MERCURIO 125 W");
            dt13.Rows.Add("M1500", "MERCURIO 1500 W");
            dt13.Rows.Add("M160", "MERCURIO 160 W");
            dt13.Rows.Add("M200", "MERCURIO 200 W");
            dt13.Rows.Add("M2000", "MERCURIO 2000 W");
            dt13.Rows.Add("M250", "MERCURIO 250 W");
            dt13.Rows.Add("M400", "MERCURIO 400 W");
            dt13.Rows.Add("M70", "MERCURIO 70 W");
            dt13.Rows.Add("M700", "MERCURIO 700 W");
            dt13.Rows.Add("M80", "MERCURIO 80 W");
            dt13.Rows.Add("MLP", "MASTERlinePLUS 50w");
            dt13.Rows.Add("S100", "SODIO 100 W");
            dt13.Rows.Add("S1000", "SODIO 1000 W");
            dt13.Rows.Add("S150", "SODIO 150 W");
            dt13.Rows.Add("S2000", "SODIO 2000 W");
            dt13.Rows.Add("S210", "SODIO 210 W");
            dt13.Rows.Add("S215", "SODIO 215 W");
            dt13.Rows.Add("S220", "SODIO 220 W");
            dt13.Rows.Add("S250", "SODIO 250 W");
            dt13.Rows.Add("S350", "SODIO 350 W");
            dt13.Rows.Add("S360", "SODIO 360 W");
            dt13.Rows.Add("S400", "SODIO 400 W");
            dt13.Rows.Add("S50", "SODIO 50 W");
            dt13.Rows.Add("S600", "SODIO 600 W");
            dt13.Rows.Add("S70", "SODIO 70 W");
            dt13.Rows.Add("T100", "METALICO 100 W");
            dt13.Rows.Add("T1000", "METALICO 1000 W");
            dt13.Rows.Add("T150", "METALICO 150 W");
            dt13.Rows.Add("T1500", "METALICO 1500 W");
            dt13.Rows.Add("T160", "METALICA 160 W");
            dt13.Rows.Add("T175", "METALICO 175 W");
            dt13.Rows.Add("T1800", "METALICO 1800 W");
            dt13.Rows.Add("T2000", "METALICO 2000 W");
            dt13.Rows.Add("T250", "METALICO 250 W");
            dt13.Rows.Add("T2500", "METALICO 2500 W");
            dt13.Rows.Add("T35", "METALICO 35 W");
            dt13.Rows.Add("T400", "METALICO 400 W");
            dt13.Rows.Add("T4000", "METALICO 4000 W");
            dt13.Rows.Add("T575", "METALICO 575 W");
            dt13.Rows.Add("T70", "METALICO 70 W");
            dt13.Rows.Add("T700", "METALICO 700 W");
            dt13.Rows.Add("TC100", "HALURO METAL CERÂMICO 100W");
            dt13.Rows.Add("TC150", "HALURO METAL CERÂMICO 150W");
            dt13.Rows.Add("TC250", "HALURO METAL CERÂMICO 250W");
            dt13.Rows.Add("TC70", "HALURO METAL CERÂMICO 70W");
            dt13.Rows.Add("X160", "MISTA 160 W");
            dt13.Rows.Add("X200", "MIXTA 200 W");
            dt13.Rows.Add("X250", "MISTA 250 W");
            dt13.Rows.Add("X500", "MISTA 500 W");
            cod_lampadaComboBox.ValueMember = "cod";
            cod_lampadaComboBox.DisplayMember = "name";
            cod_lampadaComboBox.DataSource = dt13;

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("cod");
            dt2.Columns.Add("name");
            dt2.Rows.Add("", "");
            dt2.Rows.Add("G", "GRUPO");
            dt2.Rows.Add("H", "HÍBRIDO");
            dt2.Rows.Add("I", "INDIVIDUAL");
            comandoComboBox.ValueMember = "cod";
            comandoComboBox.DisplayMember = "name";
            comandoComboBox.DataSource = dt2;

            DataTable dt11 = new DataTable();
            dt11.Columns.Add("cod");
            dt11.Columns.Add("name");
            dt11.Rows.Add("0", "");
            dt11.Rows.Add("AB", "ABERTA");
            dt11.Rows.Add("AG", "ABERTA COM GRADE");
            dt11.Rows.Add("AR", "ARANDELA");
            dt11.Rows.Add("BA", "BALIZADOR");
            dt11.Rows.Add("DE", "DECORATIVA");
            dt11.Rows.Add("EP", "EMBUTIDO EM PISO");
            dt11.Rows.Add("FD", "FECHADA DUPLA");
            dt11.Rows.Add("FS", "FECHADA SIMPLES");
            dt11.Rows.Add("GL", "GLOBO");
            dt11.Rows.Add("LL", "LUMINÁRIA A LED");
            dt11.Rows.Add("PR", "PROJETOR");
            dt11.Rows.Add("SM", "SEMAFORO");
            cod_luminariaComboBox.ValueMember = "cod";
            cod_luminariaComboBox.DisplayMember = "name";
            cod_luminariaComboBox.DataSource = dt11;


            DataTable dt12 = new DataTable();
            dt12.Columns.Add("cod");
            dt12.Columns.Add("name");
            dt12.Rows.Add("0", "");
            dt12.Rows.Add("C", "CURTO");
            dt12.Rows.Add("L", "LONGO");
            dt12.Rows.Add("M", "MÉDIO");
            dt12.Rows.Add("O", "ORNAMENTAL");
            dt12.Rows.Add("O30", "ORNAMENTAL 3000MM");
            dt12.Rows.Add("O45", "ORNAMENTAL 4500MM");
            dt12.Rows.Add("S", "SUPORTE");
            dt12.Rows.Add("SGB", "SEM BRAÇO");
            cod_bracoComboBox.ValueMember = "cod";
            cod_bracoComboBox.DisplayMember = "name";
            cod_bracoComboBox.DataSource = dt12;

            DataTable dt21 = new DataTable();
            dt21.Columns.Add("cod");
            dt21.Columns.Add("name");
            dt21.Rows.Add("0", "");
            dt21.Rows.Add("RC", "EMBUTIDO SOLO");
            dt21.Rows.Add("RE", "EXTERNO");
            dt21.Rows.Add("RI", "INTERNO");
            cod_reatorComboBox.ValueMember = "cod";
            cod_reatorComboBox.DisplayMember = "name";
            cod_reatorComboBox.DataSource = dt21;

            DataTable dt31 = new DataTable();
            dt31.Columns.Add("cod");
            dt31.Columns.Add("name");
            dt31.Rows.Add("0", "");
            dt31.Rows.Add("A", "A");
            dt31.Rows.Add("B", "B");
            dt31.Rows.Add("C", "C");
            dt31.Rows.Add("AB", "AB");
            dt31.Rows.Add("AC", "AC");
            dt31.Rows.Add("BC", "BC");
            dt31.Rows.Add("ABC", "ABC");
            fasesComboBox.ValueMember = "cod";
            fasesComboBox.DisplayMember = "name";
            fasesComboBox.DataSource = dt31;

            // TODO: This line of code loads data into the 'citeluzDataSet.material' table. You can move, or remove it, as needed.
            //citeluzDataSet.AcceptChanges();
            this.materialTableAdapter.Connection.Open();
            this.materialTableAdapter.Fill(this.citeluzDataSet.material, Plaqueta.plaqueta);

            totalLabel.Text = "Total: " + materialBindingSource.Count;

            Cursor.Current = Cursors.Default;
            Application.DoEvents();

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            materialTableAdapter.Connection.Close();
            Close();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                materialBindingSource.CancelEdit();
                materialBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            cod_bracoComboBox.SelectedIndex = 0;
            fasesComboBox.SelectedIndex = 0;
            cod_luminariaComboBox.SelectedIndex = 0;
            comandoComboBox.SelectedIndex = 0;
            cod_lampadaComboBox.SelectedIndex = 0;
            cod_reatorComboBox.SelectedIndex = 0;
            plaqueta_fkTextBox.Text = Plaqueta.plaqueta;
            observacaoTextBox.Text = "";

            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                this.materialBindingSource.EndEdit();
                db.citeluzDataSet changes = (db.citeluzDataSet)this.citeluzDataSet.GetChanges();

                if (changes == null)
                {
                    MessageBox.Show("Não há modificações a serem salvas");
                    return;
                }

                DataTable dt = changes.Tables["material"];
                db.citeluzDataSet.materialRow r = (db.citeluzDataSet.materialRow)dt.Rows[0];
                DataRow[] badRows = dt.GetErrors();

                if (badRows.Length == 0)
                {
                    int numRows = materialTableAdapter.Update(changes);
                    this.citeluzDataSet.AcceptChanges();

                    for (int i = 0; i < multiplicadorUpDown.Value - 1; i++)
                    {
                        try
                        {
                            materialBindingSource.CancelEdit();
                            materialBindingSource.AddNew();

                            DataRowView drv = (DataRowView)materialBindingSource.Current;
                            drv["plaqueta_fk"] = r.plaqueta_fk;
                            drv["cod_braco"] = r.cod_braco;
                            drv["cod_luminaria"] = r.cod_luminaria;
                            drv["cod_lampada"] = r.cod_lampada;
                            drv["cod_reator"] = r.cod_reator;
                            drv["fases"] = r.fases;
                            drv["comando"] = r.comando;

                            this.materialBindingSource.EndEdit();
                            changes = (db.citeluzDataSet)this.citeluzDataSet.GetChanges();
                            numRows = materialTableAdapter.Update(changes);
                            this.citeluzDataSet.AcceptChanges();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
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
        }

        private void Material_Closing(object sender, CancelEventArgs e)
        {
        }


        private void fillButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.materialTableAdapter.Fill(this.citeluzDataSet.material, plaqueta_fkTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}