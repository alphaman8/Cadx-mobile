namespace Cadx
{
    partial class ExportaDados
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
            System.Windows.Forms.DataGridTextBoxColumn cod_trafoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn potenciaDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn cod_proprietarioDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn observacaoDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportaDados));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.trafoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citeluzDataSet = new Cadx.db.citeluzDataSet();
            this.trafoDataGrid = new System.Windows.Forms.DataGrid();
            this.trafoTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.plaquetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plaquetaTableAdapter = new Cadx.db.citeluzDataSetTableAdapters.plaquetaTableAdapter();
            this.trafoTableAdapter = new Cadx.db.citeluzDataSetTableAdapters.trafoTableAdapter();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new Cadx.db.citeluzDataSetTableAdapters.materialTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.picConnOK = new System.Windows.Forms.PictureBox();
            this.picConnOff = new System.Windows.Forms.PictureBox();
            this.picConnWait = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEnvia = new Cadx.ButtonImage(this.components);
            this.txtNomeLote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            potenciaDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            cod_proprietarioDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            observacaoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citeluzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plaquetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_trafoDataGridColumnStyleDataGridTextBoxColumn
            // 
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cod_trafo";
            cod_trafoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cod_trafo";
            // 
            // potenciaDataGridColumnStyleDataGridTextBoxColumn
            // 
            potenciaDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            potenciaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            potenciaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "potencia";
            potenciaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "potencia";
            // 
            // cod_proprietarioDataGridColumnStyleDataGridTextBoxColumn
            // 
            cod_proprietarioDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            cod_proprietarioDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            cod_proprietarioDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "cod_proprietario";
            cod_proprietarioDataGridColumnStyleDataGridTextBoxColumn.MappingName = "cod_proprietario";
            // 
            // observacaoDataGridColumnStyleDataGridTextBoxColumn
            // 
            observacaoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            observacaoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            observacaoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "observacao";
            observacaoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "observacao";
            // 
            // plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn
            // 
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "plaqueta_trafo";
            plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "plaqueta_trafo";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Sair";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
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
            // trafoDataGrid
            // 
            this.trafoDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trafoDataGrid.DataSource = this.trafoBindingSource;
            this.trafoDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trafoDataGrid.Location = new System.Drawing.Point(0, 168);
            this.trafoDataGrid.Name = "trafoDataGrid";
            this.trafoDataGrid.Size = new System.Drawing.Size(240, 126);
            this.trafoDataGrid.TabIndex = 11;
            this.trafoDataGrid.TableStyles.Add(this.trafoTableStyleDataGridTableStyle);
            // 
            // trafoTableStyleDataGridTableStyle
            // 
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(cod_trafoDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(potenciaDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(cod_proprietarioDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(observacaoDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.GridColumnStyles.Add(plaqueta_trafoDataGridColumnStyleDataGridTextBoxColumn);
            this.trafoTableStyleDataGridTableStyle.MappingName = "trafo";
            // 
            // checkTodos
            // 
            this.checkTodos.Checked = true;
            this.checkTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTodos.Location = new System.Drawing.Point(3, 83);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(100, 20);
            this.checkTodos.TabIndex = 81;
            this.checkTodos.Text = "Enviar tudo";
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
            // trafoTableAdapter
            // 
            this.trafoTableAdapter.ClearBeforeFill = true;
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
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Regular);
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.Location = new System.Drawing.Point(3, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 57);
            this.listBox1.TabIndex = 82;
            // 
            // picConnOK
            // 
            this.picConnOK.Image = ((System.Drawing.Image)(resources.GetObject("picConnOK.Image")));
            this.picConnOK.Location = new System.Drawing.Point(200, 84);
            this.picConnOK.Name = "picConnOK";
            this.picConnOK.Size = new System.Drawing.Size(16, 16);
            this.picConnOK.Visible = false;
            // 
            // picConnOff
            // 
            this.picConnOff.Image = ((System.Drawing.Image)(resources.GetObject("picConnOff.Image")));
            this.picConnOff.Location = new System.Drawing.Point(200, 84);
            this.picConnOff.Name = "picConnOff";
            this.picConnOff.Size = new System.Drawing.Size(16, 16);
            // 
            // picConnWait
            // 
            this.picConnWait.Image = ((System.Drawing.Image)(resources.GetObject("picConnWait.Image")));
            this.picConnWait.Location = new System.Drawing.Point(200, 84);
            this.picConnWait.Name = "picConnWait";
            this.picConnWait.Size = new System.Drawing.Size(16, 16);
            this.picConnWait.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(138, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.Text = "Conexão:";
            // 
            // btEnvia
            // 
            this.btEnvia.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.btEnvia.Image = ((System.Drawing.Image)(resources.GetObject("btEnvia.Image")));
            this.btEnvia.Location = new System.Drawing.Point(3, 3);
            this.btEnvia.Name = "btEnvia";
            this.btEnvia.Size = new System.Drawing.Size(234, 43);
            this.btEnvia.TabIndex = 11;
            this.btEnvia.Text = "Enviar";
            this.btEnvia.Click += new System.EventHandler(this.enviarButton_Click);
            // 
            // txtNomeLote
            // 
            this.txtNomeLote.Location = new System.Drawing.Point(98, 52);
            this.txtNomeLote.Name = "txtNomeLote";
            this.txtNomeLote.Size = new System.Drawing.Size(139, 21);
            this.txtNomeLote.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Nome do Lote:";
            // 
            // ExportaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.txtNomeLote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picConnOK);
            this.Controls.Add(this.picConnOff);
            this.Controls.Add(this.picConnWait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkTodos);
            this.Controls.Add(this.trafoDataGrid);
            this.Controls.Add(this.btEnvia);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "ExportaDados";
            this.Text = "ExportaDados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExportaDados_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ExportaDados_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.trafoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citeluzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plaquetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private ButtonImage btEnvia;
        private System.Windows.Forms.BindingSource plaquetaBindingSource;
        private Cadx.db.citeluzDataSet citeluzDataSet;
        private Cadx.db.citeluzDataSetTableAdapters.plaquetaTableAdapter plaquetaTableAdapter;
        private System.Windows.Forms.BindingSource trafoBindingSource;
        private Cadx.db.citeluzDataSetTableAdapters.trafoTableAdapter trafoTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private Cadx.db.citeluzDataSetTableAdapters.materialTableAdapter materialTableAdapter;
        private System.Windows.Forms.DataGrid trafoDataGrid;
        private System.Windows.Forms.DataGridTableStyle trafoTableStyleDataGridTableStyle;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox picConnOK;
        private System.Windows.Forms.PictureBox picConnOff;
        private System.Windows.Forms.PictureBox picConnWait;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeLote;
        private System.Windows.Forms.Label label1;
    }
}