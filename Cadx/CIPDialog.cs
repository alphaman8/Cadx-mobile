using System; 
using System.Drawing; 
using System.Collections; 
using System.ComponentModel; 
using System.Windows.Forms;

namespace Cadx
{
    /// <summary> 
    /// Summary description for CIPDialog.
    /// Mostrador de dialog da biblioteca CIPmobile
    /// </summary> 
    public class CIPDialog : System.Windows.Forms.Form
    {
        public CIPDialog()
        {
            InitializeComponent();
        }
        /// <summary> 
        /// Clean up any resources being used. 
        /// </summary> 
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        Microsoft.WindowsCE.Forms.InputPanel inPanel = new Microsoft.WindowsCE.Forms.InputPanel();

        private void showKeyBoard(object sender, EventArgs e)
        {
            inPanel.Enabled = true;
        }

        
        #region Windows Form Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor. 
        /// </summary> 
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CIPDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(200, 120);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CIPDialog";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CIPDialogMouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CIPDialogMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CIPDialogMouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        
        int Xdif, Ydif;
        
        protected bool moving = false;

        private void CIPDialogMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //moving = true;
            Xdif = e.X;
            Ydif = e.Y;
        }
        private void CIPDialogMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //moving = false;
        }
        private void CIPDialogMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (moving)
                Location = new Point(Location.X + e.X - Xdif, Location.Y + e.Y - Ydif);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
