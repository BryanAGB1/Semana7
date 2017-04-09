namespace WinForm
{
    partial class Principal
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
            this.SuspendLayout();
            // 
            // Principal
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Genro;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btn_Cargar;
    }
}

