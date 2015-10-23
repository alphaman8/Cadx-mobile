namespace Cadx
{
    partial class Material
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
            System.Windows.Forms.Label cod_bracoLabel;
            System.Windows.Forms.Label cod_reatorLabel;
            System.Windows.Forms.Label cod_lampadaLabel;
            System.Windows.Forms.Label cod_luminariaLabel;
            System.Windows.Forms.Label fasesLabel;
            System.Windows.Forms.Label plaqueta_fkLabel;
            System.Windows.Forms.Label comandoLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridTextBoxColumn fasesDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn comandoDataGridColumnStyleDataGridTextBoxColumn;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialDataGrid = new System.Windows.Forms.DataGrid();
            this.citeluzDataSet = new Cadx.db.citeluzDataSet();
            this.materialTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.totalLabel = new System.Windows.Forms.Label();
            this.multiplicadorUpDown = new System.Windows.Forms.NumericUpDown();
            this.comandoComboBox = new System.Windows.Forms.ComboBox();
            this.plaqueta_fkTextBox = new Cadx.CipTextBox();
            this.cod_bracoComboBox = new System.Windows.Forms.ComboBox();
            this.cod_reatorComboBox = new System.Windows.Forms.ComboBox();
            this.cod_lampadaComboBox = new System.Windows.Forms.ComboBox();
            this.cod_luminariaComboBox = new System.Windows.Forms.ComboBox();
            this.fasesComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.observacaoTextBox = new Cadx.CipTextBox();
            this.materialTableAdapter = new Cadx.db.citeluzDataSetTableAdapters.materialTableAdapter();
            cod_bracoLabel = new System.Windows.Forms.Label();
            cod_reatorLabel = new System.Windows.Forms.Label();
            cod_lampadaLabel = new System.Windows.Forms.Label();
            cod_luminariaLabel = new System.Windows.Forms.Label();
            fasesLabel = new System.Windows.Forms.Label();
            plaqueta_fkLabel = new System.Windows.Forms.Label();
            comandoLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            fasesDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            comandoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citeluzDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_bracoLabel
            // 
            cod_bracoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_bracoLabel.Location = new System.Drawing.Point(31, 65);
            cod_bracoLabel.Name = "cod_bracoLabel";
            cod_bracoLabel.Size = new System.Drawing.Size(53, 14);
            cod_bracoLabel.Text = "braco:";
            // 
            // cod_reatorLabel
            // 
            cod_reatorLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_reatorLabel.Location = new System.Drawing.Point(31, 177);
            cod_reatorLabel.Name = "cod_reatorLabel";
            cod_reatorLabel.Size = new System.Drawing.Size(53, 14);
            cod_reatorLabel.Text = "reator:";
            // 
            // cod_lampadaLabel
            // 
            cod_lampadaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_lampadaLabel.Location = new System.Drawing.Point(18, 149);
            cod_lampadaLabel.Name = "cod_lampadaLabel";
            cod_lampadaLabel.Size = new System.Drawing.Size(66, 14);
            cod_lampadaLabel.Text = "lampada:";
            // 
            // cod_luminariaLabel
            // 
            cod_luminariaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_luminariaLabel.Location = new System.Drawing.Point(13, 121);
            cod_luminariaLabel.Name = "cod_luminariaLabel";
            cod_luminariaLabel.Size = new System.Drawing.Size(71, 14);
            cod_luminariaLabel.Text = "luminaria:";
            // 
            // fasesLabel
            // 
            fasesLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            fasesLabel.Location = new System.Drawing.Point(42, 93);
            fasesLabel.Name = "fasesLabel";
            fasesLabel.Size = new System.Drawing.Size(42, 14);
            fasesLabel.Text = "fases:";
            // 
            // plaqueta_fkLabel
            // 
            plaqueta_fkLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            plaqueta_fkLabel.Location = new System.Drawing.Point(13, 40);
            plaqueta_fkLabel.Name = "plaqueta_fkLabel";
            plaqueta_fkLabel.Size = new System.Drawing.Size(70, 17);
            plaqueta_fkLabel.Text = "plaqueta:";
            // 
            // comandoLabel
            // 
            comandoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            comandoLabel.Location = new System.Drawing.Point(16, 203);
            comandoLabel.Name = "comandoLabel";
            comandoLabel.Size = new System.Drawing.Size(67, 14);
            comandoLabel.Text = "comando:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            observacaoLabel.Location = new System.Drawing.Point(3, 4);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(80, 14);
            observacaoLabel.Text = "observacao:";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(2, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 19);
            label1.Text = "multiplicar:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fasesDataGridColumnStyleDataGridTextBoxColumn
            // 
            fasesDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            fasesDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            fasesDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "fases";
            fasesDataGridColumnStyleDataGridTextBoxColumn.MappingName = "fases";
            fasesDataGridColumnStyleDataGridTextBoxColumn.Width = 45;
            // 
            // plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn
            // 
            plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "plaqueta";
            plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn.MappingName = "plaqueta_fk";
            plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // comandoDataGridColumnStyleDataGridTextBoxColumn
            // 
            comandoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            comandoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            comandoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "comando";
            comandoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "comando";
            comandoDataGridColumnStyleDataGridTextBoxColumn.Width = 60;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Novo";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Salvar";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 271);
            this.tabPage1.Text = "tabPage1";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.citeluzDataSet;
            // 
            // materialDataGrid
            // 
            this.materialDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.materialDataGrid.DataSource = this.materialBindingSource;
            this.materialDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialDataGrid.Location = new System.Drawing.Point(0, 0);
            this.materialDataGrid.Name = "materialDataGrid";
            this.materialDataGrid.RowHeadersVisible = false;
            this.materialDataGrid.Size = new System.Drawing.Size(240, 271);
            this.materialDataGrid.TabIndex = 1;
            this.materialDataGrid.TableStyles.Add(this.materialTableStyleDataGridTableStyle);
            // 
            // citeluzDataSet
            // 
            this.citeluzDataSet.DataSetName = "citeluzDataSet";
            this.citeluzDataSet.Prefix = "";
            this.citeluzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTableStyleDataGridTableStyle
            // 
            this.materialTableStyleDataGridTableStyle.GridColumnStyles.Add(plaqueta_fkDataGridColumnStyleDataGridTextBoxColumn);
            this.materialTableStyleDataGridTableStyle.GridColumnStyles.Add(fasesDataGridColumnStyleDataGridTextBoxColumn);
            this.materialTableStyleDataGridTableStyle.GridColumnStyles.Add(comandoDataGridColumnStyleDataGridTextBoxColumn);
            this.materialTableStyleDataGridTableStyle.MappingName = "material";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.totalLabel);
            this.tabPage2.Controls.Add(this.multiplicadorUpDown);
            this.tabPage2.Controls.Add(label1);
            this.tabPage2.Controls.Add(comandoLabel);
            this.tabPage2.Controls.Add(this.comandoComboBox);
            this.tabPage2.Controls.Add(plaqueta_fkLabel);
            this.tabPage2.Controls.Add(this.plaqueta_fkTextBox);
            this.tabPage2.Controls.Add(this.cod_bracoComboBox);
            this.tabPage2.Controls.Add(this.cod_reatorComboBox);
            this.tabPage2.Controls.Add(this.cod_lampadaComboBox);
            this.tabPage2.Controls.Add(this.cod_luminariaComboBox);
            this.tabPage2.Controls.Add(this.fasesComboBox);
            this.tabPage2.Controls.Add(cod_bracoLabel);
            this.tabPage2.Controls.Add(cod_reatorLabel);
            this.tabPage2.Controls.Add(cod_lampadaLabel);
            this.tabPage2.Controls.Add(cod_luminariaLabel);
            this.tabPage2.Controls.Add(fasesLabel);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 271);
            this.tabPage2.Text = "tabPage2";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(3, 251);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 20);
            this.totalLabel.Text = "totalLabel";
            // 
            // multiplicadorUpDown
            // 
            this.multiplicadorUpDown.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.multiplicadorUpDown.Location = new System.Drawing.Point(90, 7);
            this.multiplicadorUpDown.Name = "multiplicadorUpDown";
            this.multiplicadorUpDown.Size = new System.Drawing.Size(67, 20);
            this.multiplicadorUpDown.TabIndex = 53;
            this.multiplicadorUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comandoComboBox
            // 
            this.comandoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialBindingSource, "comando", true));
            this.comandoComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.comandoComboBox.Location = new System.Drawing.Point(90, 203);
            this.comandoComboBox.Name = "comandoComboBox";
            this.comandoComboBox.Size = new System.Drawing.Size(134, 20);
            this.comandoComboBox.TabIndex = 51;
            // 
            // plaqueta_fkTextBox
            // 
            this.plaqueta_fkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "plaqueta_fk", true));
            this.plaqueta_fkTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.plaqueta_fkTextBox.Location = new System.Drawing.Point(90, 40);
            this.plaqueta_fkTextBox.Name = "plaqueta_fkTextBox";
            this.plaqueta_fkTextBox.ReadOnly = true;
            this.plaqueta_fkTextBox.Size = new System.Drawing.Size(99, 19);
            this.plaqueta_fkTextBox.TabIndex = 50;
            // 
            // cod_bracoComboBox
            // 
            this.cod_bracoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialBindingSource, "cod_braco", true));
            this.cod_bracoComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_bracoComboBox.Location = new System.Drawing.Point(90, 65);
            this.cod_bracoComboBox.Name = "cod_bracoComboBox";
            this.cod_bracoComboBox.Size = new System.Drawing.Size(134, 20);
            this.cod_bracoComboBox.TabIndex = 44;
            // 
            // cod_reatorComboBox
            // 
            this.cod_reatorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialBindingSource, "cod_reator", true));
            this.cod_reatorComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_reatorComboBox.Location = new System.Drawing.Point(90, 177);
            this.cod_reatorComboBox.Name = "cod_reatorComboBox";
            this.cod_reatorComboBox.Size = new System.Drawing.Size(134, 20);
            this.cod_reatorComboBox.TabIndex = 43;
            // 
            // cod_lampadaComboBox
            // 
            this.cod_lampadaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialBindingSource, "cod_lampada", true));
            this.cod_lampadaComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_lampadaComboBox.Location = new System.Drawing.Point(90, 149);
            this.cod_lampadaComboBox.Name = "cod_lampadaComboBox";
            this.cod_lampadaComboBox.Size = new System.Drawing.Size(134, 20);
            this.cod_lampadaComboBox.TabIndex = 42;
            // 
            // cod_luminariaComboBox
            // 
            this.cod_luminariaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialBindingSource, "cod_luminaria", true));
            this.cod_luminariaComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_luminariaComboBox.Location = new System.Drawing.Point(90, 121);
            this.cod_luminariaComboBox.Name = "cod_luminariaComboBox";
            this.cod_luminariaComboBox.Size = new System.Drawing.Size(134, 20);
            this.cod_luminariaComboBox.TabIndex = 41;
            // 
            // fasesComboBox
            // 
            this.fasesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialBindingSource, "fases", true));
            this.fasesComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.fasesComboBox.Location = new System.Drawing.Point(90, 93);
            this.fasesComboBox.Name = "fasesComboBox";
            this.fasesComboBox.Size = new System.Drawing.Size(134, 20);
            this.fasesComboBox.TabIndex = 40;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(observacaoLabel);
            this.tabPage3.Controls.Add(this.observacaoTextBox);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 271);
            this.tabPage3.Text = "tabPage3";
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(3, 21);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(234, 54);
            this.observacaoTextBox.TabIndex = 55;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // Material
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
            this.Name = "Material";
            this.Text = "Material";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Material_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Material_Closing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citeluzDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cod_bracoComboBox;
        private System.Windows.Forms.ComboBox cod_reatorComboBox;
        private System.Windows.Forms.ComboBox cod_lampadaComboBox;
        private System.Windows.Forms.ComboBox cod_luminariaComboBox;
        private System.Windows.Forms.ComboBox fasesComboBox;
        private Cadx.db.citeluzDataSet citeluzDataSet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private Cadx.db.citeluzDataSetTableAdapters.materialTableAdapter materialTableAdapter;
        private System.Windows.Forms.ComboBox comandoComboBox;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.NumericUpDown multiplicadorUpDown;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGrid materialDataGrid;
        private System.Windows.Forms.DataGridTableStyle materialTableStyleDataGridTableStyle;
        private System.Windows.Forms.Label totalLabel;
        private CipTextBox plaqueta_fkTextBox;
        private CipTextBox observacaoTextBox;
    }
}