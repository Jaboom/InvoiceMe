namespace InvoiceMe.Forms
{
    partial class FM_InvoiceManager
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
            // FM_InvoiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "FM_InvoiceManager";
            this.Text = "InvoiceManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FM_InvoiceManager_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
    }
}