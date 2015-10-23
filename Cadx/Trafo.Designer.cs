namespace Cadx
{
    partial class Trafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Label cod_trafoLabel;
            System.Windows.Forms.Label plaqueta_trafoLabel;
            System.Windows.Forms.Label potenciaLabel;
            System.Windows.Forms.Label cod_proprietarioLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.DataGridTextBoxColumn cod_trafoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.Label userLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trafoDataGrid = new System.Windows.Forms.DataGrid();
            this.trafoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citeluzDataSet = new Cadx.db.citeluzDataSet();
            this.trafoTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.totalMaterialLabel = new System.Windows.Forms.Label();
            this.totalPlaquetaLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new Cadx.CipTextBox();
            this.cod_proprietarioComboBox = new System.Windows.Forms.ComboBox();
            this.potenciaTextBox = new Cadx.CipTextBox();
            this.plaqueta_trafoTextBox = new Cadx.CipTextBox();
            this.cod_trafoTextBox = new Cadx.CipTextBox();
            this.plaquetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trafoTableAdapter = new Cadx.db.citeluzDataSetTableAdapters.trafoTableAdapter();
            this.plaquetaTableAdapter = new Cadx.db.citeluzDataSetTableAdapters.plaquetaTableAdapter();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new Cadx.db.citeluzDataSetTableAdapters.materialTableAdapter();
            cod_trafoLabel = new System.Windows.Forms.Label();
            plaqueta_trafoLabel = new System.Windows.Forms.Label();
            potenciaLabel = new System.Windows.Forms.Label();
            cod_proprietarioLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            userLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citeluzDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plaquetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_trafoLabel
            // 
            cod_trafoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_trafoLabel.Location = new System.Drawing.Point(47, 12);
            cod_trafoLabel.Name = "cod_trafoLabel";
            cod_trafoLabel.Size = new System.Drawing.Size(68, 14);
            cod_trafoLabel.Text = "cod trafo:";
            // 
            // plaqueta_trafoLabel
            // 
            plaqueta_trafoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            plaqueta_trafoLabel.Location = new System.Drawing.Point(15, 39);
            plaqueta_trafoLabel.Name = "plaqueta_trafoLabel";
            plaqueta_trafoLabel.Size = new System.Drawing.Size(100, 14);
            plaqueta_trafoLabel.Text = "plaqueta trafo:";
            // 
            // potenciaLabel
            // 
            potenciaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            potenciaLabel.Location = new System.Drawing.Point(51, 66);
            potenciaLabel.Name = "potenciaLabel";
            potenciaLabel.Size = new System.Drawing.Size(64, 14);
            potenciaLabel.Text = "potencia:";
            // 
            // cod_proprietarioLabel
            // 
            cod_proprietarioLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            cod_proprietarioLabel.Location = new System.Drawing.Point(5, 90);
            cod_proprietarioLabel.Name = "cod_proprietarioLabel";
            cod_proprietarioLabel.Size = new System.Drawing.Size(110, 14);
            cod_proprietarioLabel.Text = "cod proprietario:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            observacaoLabel.Location = new System.Drawing.Point(5, 108);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(80, 14);
            observacaoLabel.Text = "observacao:";
            // 
            // cod_trafoDataGridColumnStyleDataGridTextBoxColumn
            // 
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cod_trafo";
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cod_trafo";
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn.Width = 80;
            // 
            // plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn
            // 
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "plaqueta_trafo";
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "plaqueta_trafo";
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn.Width = 100;
            // 
            // userLabel
            // 
            userLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            userLabel.Location = new System.Drawing.Point(70, 185);
            userLabel.Name = "userLabel";
            userLabel.Size = new System.Drawing.Size(37, 14);
            userLabel.Text = "user:";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem5);
            this.menuItem1.MenuItems.Add(this.menuItem6);
            this.menuItem1.MenuItems.Add(this.menuItem8);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Novo";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Salvar";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.MenuItems.Add(this.menuItem7);
            this.menuItem6.Text = "Mais";
            // 
            // menuItem7
            // 
            this.menuItem7.Text = "Plaquetas";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "Excluir";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "-";
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trafoDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 271);
            this.tabPage1.Text = "Tabela";
            // 
            // trafoDataGrid
            // 
            this.trafoDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trafoDataGrid.DataSource = this.trafoBindingSource;
            this.trafoDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trafoDataGrid.Location = new System.Drawing.Point(0, 0);
            this.trafoDataGrid.Name = "trafoDataGrid";
            this.trafoDataGrid.RowHeadersVisible = false;
            this.trafoDataGrid.Size = new System.Drawing.Size(240, 271);
            this.trafoDataGrid.TabIndex = 0;
            this.trafoDataGrid.TableStyles.Add(this.trafoTableStyleDataGridTableStyle);
            // 
            // trafoBindingSource
            // 
            this.trafoBindingSource.DataMember = "trafo";
            this.trafoBindingSource.DataSource = this.citeluzDataSet;
            // 
            // citeluzDataSet
            // 
            this.citeluzDataSet.DataSetName = "citeluzDataSet";
            this.citeluzDataSet.Prefix = "";
            this.citeluzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trafoTableStyleDataGridTableStyle
            // 
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(cod_trafoDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.MappingName = "trafo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.totalMaterialLabel);
            this.tabPage2.Controls.Add(this.totalPlaquetaLabel);
            this.tabPage2.Controls.Add(this.totalLabel);
            this.tabPage2.Controls.Add(userLabel);
            this.tabPage2.Controls.Add(this.userTextBox);
            this.tabPage2.Controls.Add(observacaoLabel);
            this.tabPage2.Controls.Add(this.observacaoTextBox);
            this.tabPage2.Controls.Add(this.cod_proprietarioComboBox);
            this.tabPage2.Controls.Add(this.potenciaTextBox);
            this.tabPage2.Controls.Add(this.plaqueta_trafoTextBox);
            this.tabPage2.Controls.Add(this.cod_trafoTextBox);
            this.tabPage2.Controls.Add(cod_proprietarioLabel);
            this.tabPage2.Controls.Add(potenciaLabel);
            this.tabPage2.Controls.Add(plaqueta_trafoLabel);
            this.tabPage2.Controls.Add(cod_trafoLabel);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(240, 271);
            this.tabPage2.Text = "tabPage2";
            // 
            // totalMaterialLabel
            // 
            this.totalMaterialLabel.Location = new System.Drawing.Point(5, 250);
            this.totalMaterialLabel.Name = "totalMaterialLabel";
            this.totalMaterialLabel.Size = new System.Drawing.Size(130, 20);
            this.totalMaterialLabel.Text = "label2";
            // 
            // totalPlaquetaLabel
            // 
            this.totalPlaquetaLabel.Location = new System.Drawing.Point(5, 230);
            this.totalPlaquetaLabel.Name = "totalPlaquetaLabel";
            this.totalPlaquetaLabel.Size = new System.Drawing.Size(130, 20);
            this.totalPlaquetaLabel.Text = "label1";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(5, 210);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(130, 20);
            this.totalLabel.Text = "totalLabel";
            // 
            // userTextBox
            // 
            this.userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "user", true));
            this.userTextBox.Location = new System.Drawing.Point(114, 182);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.ReadOnly = true;
            this.userTextBox.Size = new System.Drawing.Size(119, 21);
            this.userTextBox.TabIndex = 14;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "observacao", true));
            this.observacaoTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.observacaoTextBox.Location = new System.Drawing.Point(5, 125);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(226, 51);
            this.observacaoTextBox.TabIndex = 9;
            // 
            // cod_proprietarioComboBox
            // 
            this.cod_proprietarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trafoBindingSource, "cod_proprietario", true));
            this.cod_proprietarioComboBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_proprietarioComboBox.Location = new System.Drawing.Point(114, 88);
            this.cod_proprietarioComboBox.Name = "cod_proprietarioComboBox";
            this.cod_proprietarioComboBox.Size = new System.Drawing.Size(119, 20);
            this.cod_proprietarioComboBox.TabIndex = 7;
            // 
            // potenciaTextBox
            // 
            this.potenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "potencia", true));
            this.potenciaTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.potenciaTextBox.Location = new System.Drawing.Point(114, 61);
            this.potenciaTextBox.Name = "potenciaTextBox";
            this.potenciaTextBox.Size = new System.Drawing.Size(119, 19);
            this.potenciaTextBox.TabIndex = 5;
            // 
            // plaqueta_trafoTextBox
            // 
            this.plaqueta_trafoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "plaqueta_trafo", true));
            this.plaqueta_trafoTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.plaqueta_trafoTextBox.Location = new System.Drawing.Point(114, 34);
            this.plaqueta_trafoTextBox.Name = "plaqueta_trafoTextBox";
            this.plaqueta_trafoTextBox.Size = new System.Drawing.Size(119, 19);
            this.plaqueta_trafoTextBox.TabIndex = 3;
            // 
            // cod_trafoTextBox
            // 
            this.cod_trafoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trafoBindingSource, "cod_trafo", true));
            this.cod_trafoTextBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cod_trafoTextBox.Location = new System.Drawing.Point(114, 7);
            this.cod_trafoTextBox.Name = "cod_trafoTextBox";
            this.cod_trafoTextBox.Size = new System.Drawing.Size(119, 19);
            this.cod_trafoTextBox.TabIndex = 1;
            // 
            // plaquetaBindingSource
            // 
            this.plaquetaBindingSource.DataMember = "plaqueta";
            this.plaquetaBindingSource.DataSource = this.citeluzDataSet;
            // 
            // trafoTableAdapter
            // 
            this.trafoTableAdapter.ClearBeforeFill = true;
            // 
            // plaquetaTableAdapter
            // 
            this.plaquetaTableAdapter.ClearBeforeFill = true;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.citeluzDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // Trafo
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
            this.Name = "Trafo";
            this.Text = "Trafo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Trafo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citeluzDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plaquetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Cadx.db.citeluzDataSet citeluzDataSet;
        private System.Windows.Forms.BindingSource trafoBindingSource;
        private Cadx.db.citeluzDataSetTableAdapters.trafoTableAdapter trafoTableAdapter;
        private System.Windows.Forms.ComboBox cod_proprietarioComboBox;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.DataGrid trafoDataGrid;
        private System.Windows.Forms.DataGridTableStyle trafoTableStyleDataGridTableStyle;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.TextBox userTextBox;
        private CipTextBox observacaoTextBox;
        private CipTextBox potenciaTextBox;
        private CipTextBox plaqueta_trafoTextBox;
        private CipTextBox cod_trafoTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.BindingSource plaquetaBindingSource;
        private Cadx.db.citeluzDataSetTableAdapters.plaquetaTableAdapter plaquetaTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private Cadx.db.citeluzDataSetTableAdapters.materialTableAdapter materialTableAdapter;
        private System.Windows.Forms.Label totalMaterialLabel;
        private System.Windows.Forms.Label totalPlaquetaLabel;
    }
}