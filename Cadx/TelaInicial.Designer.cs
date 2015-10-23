namespace Cadx
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.Exporta = new Cadx.ButtonImage(this.components);
            this.cadButton = new Cadx.ButtonImage(this.components);
            this.buttonImage1 = new Cadx.ButtonImage(this.components);
            this.SuspendLayout();
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
            // Exporta
            // 
            this.Exporta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exporta.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.Exporta.Image = ((System.Drawing.Image)(resources.GetObject("Exporta.Image")));
            this.Exporta.Location = new System.Drawing.Point(0, 50);
            this.Exporta.Name = "Exporta";
            this.Exporta.Size = new System.Drawing.Size(240, 50);
            this.Exporta.TabIndex = 10;
            this.Exporta.Text = "Exportar";
            this.Exporta.Click += new System.EventHandler(this.Exporta_Click);
            // 
            // cadButton
            // 
            this.cadButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadButton.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.cadButton.Image = ((System.Drawing.Image)(resources.GetObject("cadButton.Image")));
            this.cadButton.Location = new System.Drawing.Point(0, 0);
            this.cadButton.Name = "cadButton";
            this.cadButton.Size = new System.Drawing.Size(240, 50);
            this.cadButton.TabIndex = 9;
            this.cadButton.Text = "Cadastro";
            this.cadButton.Click += new System.EventHandler(this.cadButton_Click);
            // 
            // buttonImage1
            // 
            this.buttonImage1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonImage1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.buttonImage1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImage1.Image")));
            this.buttonImage1.Location = new System.Drawing.Point(0, 100);
            this.buttonImage1.Name = "buttonImage1";
            this.buttonImage1.Size = new System.Drawing.Size(240, 50);
            this.buttonImage1.TabIndex = 11;
            this.buttonImage1.Text = "Atualizar Base";
            this.buttonImage1.Click += new System.EventHandler(this.buttonImage1_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.ControlBox = false;
            this.Controls.Add(this.buttonImage1);
            this.Controls.Add(this.Exporta);
            this.Controls.Add(this.cadButton);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private ButtonImage cadButton;
        private ButtonImage Exporta;
        private ButtonImage buttonImage1;
    }
}