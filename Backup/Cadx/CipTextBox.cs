using System;

namespace Cadx
{
    class CipTextBox : System.Windows.Forms.TextBox
    {
        private Microsoft.WindowsCE.Forms.InputPanel inputPanel1;
        private System.ComponentModel.IContainer components;


        public CipTextBox()
        {
            InitializeComponent();
        }

        protected override void OnKeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyUp(e);

            //bloqueia um monte de tecla que os caras insistem em utilizar e da merda na hora
            //de exportar para o mysql
            if (e.KeyValue == 222 || e.KeyValue == 188 || e.KeyValue == 191
                || e.KeyValue == 192 || e.KeyValue == 220)
            {
                int pos = this.SelectionStart;
                this.Text = this.Text.Remove(this.SelectionStart - 1, 1);
                this.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }

        override protected void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (Char.IsLetter(e.KeyChar))
            {
                int pos = this.SelectionStart;
                this.Text = this.Text.Insert(this.SelectionStart,
                    Char.ToUpper(e.KeyChar).ToString());
                this.SelectionStart = pos + 1;
                e.Handled = true;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputPanel1 = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        protected void SetKeyboardVisible(bool isVisible)
        {
            inputPanel1.Enabled = isVisible;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            SetKeyboardVisible(true);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            SetKeyboardVisible(false);
        }
    }
}
