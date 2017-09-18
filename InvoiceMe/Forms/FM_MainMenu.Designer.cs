namespace InvoiceMe
{
    partial class FM_MainMenu
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
            this.btn_invoicemgr = new System.Windows.Forms.Button();
            this.btn_clientmgr = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.btn_printinvoices = new System.Windows.Forms.Button();
            this.lb_userInfo = new System.Windows.Forms.Label();
            this.btn_extraOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_invoicemgr
            // 
            this.btn_invoicemgr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_invoicemgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_invoicemgr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invoicemgr.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoicemgr.ForeColor = System.Drawing.Color.Black;
            this.btn_invoicemgr.Location = new System.Drawing.Point(118, 120);
            this.btn_invoicemgr.Name = "btn_invoicemgr";
            this.btn_invoicemgr.Size = new System.Drawing.Size(295, 66);
            this.btn_invoicemgr.TabIndex = 0;
            this.btn_invoicemgr.Text = "Invoice Manager";
            this.btn_invoicemgr.UseVisualStyleBackColor = false;
            this.btn_invoicemgr.Click += new System.EventHandler(this.btn_invoicemgr_Click);
            // 
            // btn_clientmgr
            // 
            this.btn_clientmgr.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_clientmgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientmgr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clientmgr.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientmgr.ForeColor = System.Drawing.Color.Black;
            this.btn_clientmgr.Location = new System.Drawing.Point(118, 220);
            this.btn_clientmgr.Name = "btn_clientmgr";
            this.btn_clientmgr.Size = new System.Drawing.Size(295, 66);
            this.btn_clientmgr.TabIndex = 1;
            this.btn_clientmgr.Text = "Client Manager";
            this.btn_clientmgr.UseVisualStyleBackColor = false;
            this.btn_clientmgr.Click += new System.EventHandler(this.btn_clientmgr_Click);
            // 
            // btn_overview
            // 
            this.btn_overview.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_overview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_overview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_overview.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_overview.ForeColor = System.Drawing.Color.Black;
            this.btn_overview.Location = new System.Drawing.Point(118, 320);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(295, 66);
            this.btn_overview.TabIndex = 2;
            this.btn_overview.Text = "Overview";
            this.btn_overview.UseVisualStyleBackColor = false;
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // btn_printinvoices
            // 
            this.btn_printinvoices.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_printinvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_printinvoices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_printinvoices.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printinvoices.ForeColor = System.Drawing.Color.Black;
            this.btn_printinvoices.Location = new System.Drawing.Point(118, 420);
            this.btn_printinvoices.Name = "btn_printinvoices";
            this.btn_printinvoices.Size = new System.Drawing.Size(295, 66);
            this.btn_printinvoices.TabIndex = 3;
            this.btn_printinvoices.Text = "Print Invoices";
            this.btn_printinvoices.UseVisualStyleBackColor = false;
            this.btn_printinvoices.Click += new System.EventHandler(this.btn_printinvoices_Click);
            // 
            // lb_userInfo
            // 
            this.lb_userInfo.AutoSize = true;
            this.lb_userInfo.Location = new System.Drawing.Point(13, 13);
            this.lb_userInfo.Name = "lb_userInfo";
            this.lb_userInfo.Size = new System.Drawing.Size(50, 17);
            this.lb_userInfo.TabIndex = 4;
            this.lb_userInfo.Text = "User : ";
            // 
            // btn_extraOptions
            // 
            this.btn_extraOptions.BackColor = System.Drawing.SystemColors.Info;
            this.btn_extraOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_extraOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_extraOptions.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_extraOptions.ForeColor = System.Drawing.Color.Black;
            this.btn_extraOptions.Location = new System.Drawing.Point(356, 12);
            this.btn_extraOptions.Name = "btn_extraOptions";
            this.btn_extraOptions.Size = new System.Drawing.Size(177, 40);
            this.btn_extraOptions.TabIndex = 5;
            this.btn_extraOptions.UseVisualStyleBackColor = false;
            this.btn_extraOptions.Visible = false;
            this.btn_extraOptions.Click += new System.EventHandler(this.btn_extraOptions_Click);
            // 
            // FM_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(545, 549);
            this.Controls.Add(this.btn_extraOptions);
            this.Controls.Add(this.lb_userInfo);
            this.Controls.Add(this.btn_printinvoices);
            this.Controls.Add(this.btn_overview);
            this.Controls.Add(this.btn_clientmgr);
            this.Controls.Add(this.btn_invoicemgr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.Name = "FM_MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FM_MainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_invoicemgr;
        private System.Windows.Forms.Button btn_clientmgr;
        private System.Windows.Forms.Button btn_overview;
        private System.Windows.Forms.Button btn_printinvoices;
        private System.Windows.Forms.Label lb_userInfo;
        private System.Windows.Forms.Button btn_extraOptions;
    }
}