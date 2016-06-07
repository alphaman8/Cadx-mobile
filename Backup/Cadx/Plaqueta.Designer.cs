namespace Cadx
{
    partial class Plaqueta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label plaqueta_idLabel;
            System.Windows.Forms.Label ordemLabel;
            System.Windows.Forms.Label n_portaLabel;
            System.Windows.Forms.Label cod_caboLabel;
            System.Windows.Forms.Label cod_proprietarioLabel;
            System.Windows.Forms.Label cod_posteLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label plaqueta_trafo_fkLabel;
            System.Windows.Forms.Label tipo_alimentacaoLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label medidorLabel;
            System.Windows.Forms.DataGridTextBoxColumn plaqueta_idDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn ordemDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn plaqueta_trafo_fkDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.citeluzDataSet = new Cadx.db.citeluzDataSet();
            this.plaquetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plaquetaTableAdapter = new Cadx.db.citeluzDataSetTableAdapters.plaquetaTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plaquetaDataGrid = new System.Windows.Forms.DataGrid();
            this.plaquetaTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trafo_plaquetaTextBox = new Cadx.CipTextBox();
            this.n_portaTextBox = new Cadx.CipTextBox();
            this.ordemTextBox = new Cadx.CipTextBox();
            this.plaqueta_idTextBox = new Cadx.CipTextBox();
            this.logradouroTextBox = new Cadx.CipTextBox();
            this.bairroTextBox = new Cadx.CipTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.medidorTextBox = new Cadx.CipTextBox();
            this.medidoCheck = new System.Windows.Forms.CheckBox();
            this.tipo_alimentacaoComboBox = new System.Windows.Forms.ComboBox();
            this.cod_caboComboBox = new System.Windows.Forms.ComboBox();
            this.cod_proprietarioComboBox = new System.Windows.Forms.ComboBox();
            this.cod_posteComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtStatus = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtSatelites = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new Cadx.CipTextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            plaqueta_idLabel = new System.Windows.Forms.Label();
            ordemLabel = new System.Windows.Forms.Label();
            n_portaLabel = new System.Windows.Forms.Label();
            cod_caboLabel = new System.Windows.Forms.Label();
            cod_proprietarioLabel = new System.Windows.Forms.Label();
            cod_posteLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            plaqueta_trafo_fkLabel = new System.Windows.Forms.Label();
            tipo_alimentacaoLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            medidorLabel = new System.Windows.Forms.Label();
            plaqueta_idDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ordemDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            plaqueta_trafo_fkDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.citeluzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plaquetaBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bairroLabel
            // 
            bairroLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            bairroLabel.Location = new System.Drawing.Point(59, 91);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(47, 14);
            bairroLabel.Text = "bairro:";
            // 
            // logradouroLabel
            // 
            logradouroLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            logradouroLabel.Location = new System.Drawing.Point(27, 118);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(79, 14);
            logradouroLabel.Text = "logradouro:";
            // 
            // plaqueta_idLabel
            // 
            plaqueta_idLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            plaqueta_idLabel.Location = new System.Drawing.Point(26, 64);
            plaqueta_idLabel.Name = "plaqueta_idLabel";
            plaqueta_idLabel.Size = new System.Drawing.Size(80, 14);
            plaqueta_idLabel.Text = "plaqueta id:";
            // 
            // ordemLabel
            // 
            ordemLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            ordemLabel.Location = new System.Drawing.Point(56, 37);
            ordemLabel.Name = "ordemLabel";
            ordemLabel.Size = new System.Drawing.Size(50, 14);
            ordemLabel.Text = "ordem:";
            // 
            // n_portaLabel
            // 
            n_portaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            n_portaLabel.Location = new System.Drawing.Point(49, 145);
            n_portaLabel.Name = "n_portaLabel";
            n_portaLabel.Size = new System.Drawing.Size(57, 14);
            n_portaLabel.Text = "n porta:";
            // 
            // cod_caboLabel
            // 
            cod_caboLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_caboLabel.Location = new System.Drawing.Point(26, 82);
            cod_caboLabel.Name = "cod_caboLabel";
            cod_caboLabel.Size = new System.Drawing.Size(66, 14);
            cod_caboLabel.Text = "cod cabo:";
            // 
            // cod_proprietarioLabel
            // 
            cod_proprietarioLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_proprietarioLabel.Location = new System.Drawing.Point(4, 54);
            cod_proprietarioLabel.Name = "cod_proprietarioLabel";
            cod_proprietarioLabel.Size = new System.Drawing.Size(88, 14);
            cod_proprietarioLabel.Text = "proprietario:";
            // 
            // cod_posteLabel
            // 
            cod_posteLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_posteLabel.Location = new System.Drawing.Point(7, 7);
            cod_posteLabel.Name = "cod_posteLabel";
            cod_posteLabel.Size = new System.Drawing.Size(49, 20);
            cod_posteLabel.Text = "poste:";
            // 
            // xLabel
            // 
            xLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            xLabel.Location = new System.Drawing.Point(69, 12);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(18, 14);
            xLabel.Text = "x:";
            // 
            // yLabel
            // 
            yLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            yLabel.Location = new System.Drawing.Point(69, 39);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(18, 14);
            yLabel.Text = "y:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            observacaoLabel.Location = new System.Drawing.Point(7, 159);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(80, 14);
            observacaoLabel.Text = "observacao:";
            // 
            // plaqueta_trafo_fkLabel
            // 
            plaqueta_trafo_fkLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            plaqueta_trafo_fkLabel.Location = new System.Drawing.Point(7, 10);
            plaqueta_trafo_fkLabel.Name = "plaqueta_trafo_fkLabel";
            plaqueta_trafo_fkLabel.Size = new System.Drawing.Size(99, 18);
            plaqueta_trafo_fkLabel.Text = "plaqueta trafo:";
            // 
            // tipo_alimentacaoLabel
            // 
            tipo_alimentacaoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            tipo_alimentacaoLabel.Location = new System.Drawing.Point(4, 108);
            tipo_alimentacaoLabel.Name = "tipo_alimentacaoLabel";
            tipo_alimentacaoLabel.Size = new System.Drawing.Size(88, 14);
            tipo_alimentacaoLabel.Text = "alimentacao:";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(23, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 14);
            label2.Text = "Satélites:";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(23, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 14);
            label1.Text = "Acurácia:";
            // 
            // medidorLabel
            // 
            medidorLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            medidorLabel.Location = new System.Drawing.Point(26, 162);
            medidorLabel.Name = "medidorLabel";
            medidorLabel.Size = new System.Drawing.Size(61, 14);
            medidorLabel.Text = "medidor:";
            // 
            // plaqueta_idDataGridColumnStyleDataGridTextBoxColumn
            // 
            plaqueta_idDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            plaqueta_idDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "plaqueta";
            plaqueta_idDataGridColumnStyleDataGridTextBoxColumn.MappingName = "plaqueta_id";
            plaqueta_idDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // ordemDataGridColumnStyleDataGridTextBoxColumn
            // 
            ordemDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            ordemDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "ordem";
            ordemDataGridColumnStyleDataGridTextBoxColumn.MappingName = "ordem";
            ordemDataGridColumnStyleDataGridTextBoxColumn.Width = 40;
            // 
            // plaqueta_trafo_fkDataGridColumnStyleDataGridTextBoxColumn
            // 
            plaqueta_trafo_fkDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            plaqueta_trafo_fkDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "plaqueta_trafo";
            plaqueta_trafo_fkDataGridColumnStyleDataGridTextBoxColumn.MappingName = "plaqueta_trafo_fk";
            plaqueta_trafo_fkDataGridColumnStyleDataGridTextBoxColumn.Width = 100;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.menuItem10);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Novo";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Salvar";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.MenuItems.Add(this.menuItem7);
            this.menuItem6.MenuItems.Add(this.menuItem8);
            this.menuItem6.MenuItems.Add(this.menuItem9);
            this.menuItem6.Text = "Mais";
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Materiais";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "-";
            // 
            // menuItem9
            // 
            this.menuItem9.Text = "Conectar Trimble";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Text = "Excluir";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Sair";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // citeluzDataSet
            // 
            this.citeluzDataSet.DataSetName = "citeluzDataSet";
            this.citeluzDataSet.Prefix = "";
            this.citeluzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plaquetaBindingSource
            // 
            this.plaquetaBindingSource.DataMember = "plaqueta";
            this.plaquetaBindingSource.DataSource = this.citeluzDataSet;
            // 
            // plaquetaTableAdapter
            // 
            this.plaquetaTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.plaquetaDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 271);
            this.tabPage1.Text = "Tabela";
            // 
            // plaquetaDataGrid
            // 
            this.plaquetaDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.plaquetaDataGrid.DataSource = this.plaquetaBindingSource;
            this.plaquetaDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plaquetaDataGrid.Location = new System.Drawing.Point(0, 0);
            this.plaquetaDataGrid.Name = "plaquetaDataGrid";
            this.plaquetaDataGrid.RowHeadersVisible = false;
            this.plaquetaDataGrid.Size = new System.Drawing.Size(240, 271);
            this.plaquetaDataGrid.TabIndex = 1;
            this.plaquetaDataGrid.TableStyles.Add(this.plaquetaTableStyleDataGridTableStyle);
            // 
            // plaquetaTableStyleDataGridTableStyle
            // 
            this.plaquetaTableStyleDataGridTableStyle.GridColumnStyles.Add(ordemDataGridColumnStyleDataGridTextBoxColumn);
            this.plaquetaTableStyleDataGridTableStyle.GridColumnStyles.Add(plaqueta_trafo_fkDataGridColumnStyleDataGridTextBoxColumn);
            this.plaquetaTableStyleDataGridTableStyle.GridColumnStyles.Add(plaqueta_idDataGridColumnStyleDataGridTextBoxColumn);
            this.plaquetaTableStyleDataGridTableStyle.MappingName = "plaqueta";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.totalLabel);
            this.tabPage2.Controls.Add(this.trafo_plaquetaTextBox);
            this.tabPage2.Controls.Add(this.n_portaTextBox);
            this.tabPage2.Controls.Add(this.ordemTextBox);
            this.tabPage2.Controls.Add(this.plaqueta_idTextBox);
            this.tabPage2.Controls.Add(this.logradouroTextBox);
            this.tabPage2.Controls.Add(this.bairroTextBox);
            this.tabPage2.Controls.Add(plaqueta_trafo_fkLabel);
            this.tabPage2.Controls.Add(n_portaLabel);
            this.tabPage2.Controls.Add(ordemLabel);
            this.tabPage2.Controls.Add(plaqueta_idLabel);
            this.tabPage2.Controls.Add(logradouroLabel);
            this.tabPage2.Controls.Add(bairroLabel);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 271);
            this.tabPage2.Text = "tabPage2";
            // 
            // trafo_plaquetaTextBox
            // 
            this.trafo_plaquetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "plaqueta_trafo_fk", true));
            this.trafo_plaquetaTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.trafo_plaquetaTextBox.Location = new System.Drawing.Point(106, 7);
            this.trafo_plaquetaTextBox.Name = "trafo_plaquetaTextBox";
            this.trafo_plaquetaTextBox.ReadOnly = true;
            this.trafo_plaquetaTextBox.Size = new System.Drawing.Size(127, 19);
            this.trafo_plaquetaTextBox.TabIndex = 18;
            // 
            // n_portaTextBox
            // 
            this.n_portaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "n_porta", true));
            this.n_portaTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.n_portaTextBox.Location = new System.Drawing.Point(106, 142);
            this.n_portaTextBox.Name = "n_portaTextBox";
            this.n_portaTextBox.Size = new System.Drawing.Size(127, 19);
            this.n_portaTextBox.TabIndex = 17;
            // 
            // ordemTextBox
            // 
            this.ordemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "ordem", true));
            this.ordemTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.ordemTextBox.Location = new System.Drawing.Point(106, 34);
            this.ordemTextBox.Name = "ordemTextBox";
            this.ordemTextBox.Size = new System.Drawing.Size(63, 19);
            this.ordemTextBox.TabIndex = 15;
            // 
            // plaqueta_idTextBox
            // 
            this.plaqueta_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "plaqueta_id", true));
            this.plaqueta_idTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.plaqueta_idTextBox.Location = new System.Drawing.Point(106, 61);
            this.plaqueta_idTextBox.Name = "plaqueta_idTextBox";
            this.plaqueta_idTextBox.Size = new System.Drawing.Size(127, 19);
            this.plaqueta_idTextBox.TabIndex = 13;
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "logradouro", true));
            this.logradouroTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.logradouroTextBox.Location = new System.Drawing.Point(106, 115);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(127, 19);
            this.logradouroTextBox.TabIndex = 7;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "bairro", true));
            this.bairroTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.bairroTextBox.Location = new System.Drawing.Point(106, 88);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(127, 19);
            this.bairroTextBox.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.medidorTextBox);
            this.tabPage3.Controls.Add(this.medidoCheck);
            this.tabPage3.Controls.Add(medidorLabel);
            this.tabPage3.Controls.Add(this.tipo_alimentacaoComboBox);
            this.tabPage3.Controls.Add(this.cod_caboComboBox);
            this.tabPage3.Controls.Add(this.cod_proprietarioComboBox);
            this.tabPage3.Controls.Add(this.cod_posteComboBox);
            this.tabPage3.Controls.Add(tipo_alimentacaoLabel);
            this.tabPage3.Controls.Add(cod_caboLabel);
            this.tabPage3.Controls.Add(cod_proprietarioLabel);
            this.tabPage3.Controls.Add(cod_posteLabel);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 271);
            this.tabPage3.Text = "tabPage3";
            // 
            // medidorTextBox
            // 
            this.medidorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "medidor", true));
            this.medidorTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.medidorTextBox.Location = new System.Drawing.Point(98, 162);
            this.medidorTextBox.Name = "medidorTextBox";
            this.medidorTextBox.Size = new System.Drawing.Size(135, 19);
            this.medidorTextBox.TabIndex = 46;
            // 
            // medidoCheck
            // 
            this.medidoCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.plaquetaBindingSource, "medido", true));
            this.medidoCheck.Location = new System.Drawing.Point(125, 136);
            this.medidoCheck.Name = "medidoCheck";
            this.medidoCheck.Size = new System.Drawing.Size(100, 20);
            this.medidoCheck.TabIndex = 47;
            this.medidoCheck.Text = "Medido";
            // 
            // tipo_alimentacaoComboBox
            // 
            this.tipo_alimentacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plaquetaBindingSource, "tipo_alimentacao", true));
            this.tipo_alimentacaoComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.tipo_alimentacaoComboBox.Location = new System.Drawing.Point(98, 108);
            this.tipo_alimentacaoComboBox.Name = "tipo_alimentacaoComboBox";
            this.tipo_alimentacaoComboBox.Size = new System.Drawing.Size(135, 20);
            this.tipo_alimentacaoComboBox.TabIndex = 39;
            // 
            // cod_caboComboBox
            // 
            this.cod_caboComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plaquetaBindingSource, "cod_cabo", true));
            this.cod_caboComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_caboComboBox.Location = new System.Drawing.Point(98, 82);
            this.cod_caboComboBox.Name = "cod_caboComboBox";
            this.cod_caboComboBox.Size = new System.Drawing.Size(135, 20);
            this.cod_caboComboBox.TabIndex = 33;
            // 
            // cod_proprietarioComboBox
            // 
            this.cod_proprietarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plaquetaBindingSource, "cod_proprietario", true));
            this.cod_proprietarioComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_proprietarioComboBox.Location = new System.Drawing.Point(98, 54);
            this.cod_proprietarioComboBox.Name = "cod_proprietarioComboBox";
            this.cod_proprietarioComboBox.Size = new System.Drawing.Size(135, 20);
            this.cod_proprietarioComboBox.TabIndex = 32;
            // 
            // cod_posteComboBox
            // 
            this.cod_posteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plaquetaBindingSource, "cod_poste", true));
            this.cod_posteComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_posteComboBox.Location = new System.Drawing.Point(7, 25);
            this.cod_posteComboBox.Name = "cod_posteComboBox";
            this.cod_posteComboBox.Size = new System.Drawing.Size(226, 20);
            this.cod_posteComboBox.TabIndex = 31;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtStatus);
            this.tabPage4.Controls.Add(this.yTextBox);
            this.tabPage4.Controls.Add(this.xTextBox);
            this.tabPage4.Controls.Add(label2);
            this.tabPage4.Controls.Add(label1);
            this.tabPage4.Controls.Add(this.txtAcc);
            this.tabPage4.Controls.Add(this.txtSatelites);
            this.tabPage4.Controls.Add(observacaoLabel);
            this.tabPage4.Controls.Add(this.observacaoTextBox);
            this.tabPage4.Controls.Add(yLabel);
            this.tabPage4.Controls.Add(xLabel);
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(240, 271);
            this.tabPage4.Text = "tabPage4";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.txtStatus.Location = new System.Drawing.Point(3, 126);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(235, 18);
            this.txtStatus.Text = "Status";
            // 
            // yTextBox
            // 
            this.yTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "y", true));
            this.yTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.yTextBox.Location = new System.Drawing.Point(93, 39);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.ReadOnly = true;
            this.yTextBox.Size = new System.Drawing.Size(140, 19);
            this.yTextBox.TabIndex = 3;
            // 
            // xTextBox
            // 
            this.xTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "x", true));
            this.xTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.xTextBox.Location = new System.Drawing.Point(93, 12);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.ReadOnly = true;
            this.xTextBox.Size = new System.Drawing.Size(140, 19);
            this.xTextBox.TabIndex = 1;
            // 
            // txtAcc
            // 
            this.txtAcc.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtAcc.Location = new System.Drawing.Point(93, 64);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.ReadOnly = true;
            this.txtAcc.Size = new System.Drawing.Size(84, 19);
            this.txtAcc.TabIndex = 46;
            // 
            // txtSatelites
            // 
            this.txtSatelites.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtSatelites.Location = new System.Drawing.Point(93, 91);
            this.txtSatelites.Name = "txtSatelites";
            this.txtSatelites.ReadOnly = true;
            this.txtSatelites.Size = new System.Drawing.Size(84, 19);
            this.txtSatelites.TabIndex = 45;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plaquetaBindingSource, "observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(7, 176);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(226, 70);
            this.observacaoTextBox.TabIndex = 5;
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(3, 251);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 20);
            this.totalLabel.Text = "totalLabel";
            // 
            // Plaqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Plaqueta";
            this.Text = "Plaqueta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Plaqueta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citeluzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plaquetaBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem5;
        private Cadx.db.citeluzDataSet citeluzDataSet;
        private System.Windows.Forms.BindingSource plaquetaBindingSource;
        private Cadx.db.citeluzDataSetTableAdapters.plaquetaTableAdapter plaquetaTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cod_caboComboBox;
        private System.Windows.Forms.ComboBox cod_proprietarioComboBox;
        private System.Windows.Forms.ComboBox cod_posteComboBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.ComboBox tipo_alimentacaoComboBox;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtSatelites;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.CheckBox medidoCheck;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.DataGrid plaquetaDataGrid;
        private System.Windows.Forms.DataGridTableStyle plaquetaTableStyleDataGridTableStyle;
        private CipTextBox logradouroTextBox;
        private CipTextBox bairroTextBox;
        private CipTextBox n_portaTextBox;
        private CipTextBox ordemTextBox;
        private CipTextBox plaqueta_idTextBox;
        private CipTextBox observacaoTextBox;
        private CipTextBox trafo_plaquetaTextBox;
        private CipTextBox medidorTextBox;
        private System.Windows.Forms.Label totalLabel;
    }
}