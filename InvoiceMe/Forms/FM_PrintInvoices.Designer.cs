namespace InvoiceMe.Forms
{
    partial class FM_PrintInvoices
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
            this.cb_clientID = new System.Windows.Forms.ComboBox();
            this.cb_invoiceNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_clientname = new System.Windows.Forms.Label();
            this.lb_clientaddress = new System.Windows.Forms.Label();
            this.lb_clientcontact = new System.Windows.Forms.Label();
            this.lb_invoicedate = new System.Windows.Forms.Label();
            this.lb_invoiceduedate = new System.Windows.Forms.Label();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_invoicedescription = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_clientID
            // 
            this.cb_clientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_clientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_clientID.FormattingEnabled = true;
            this.cb_clientID.Location = new System.Drawing.Point(650, 44);
            this.cb_clientID.Name = "cb_clientID";
            this.cb_clientID.Size = new System.Drawing.Size(121, 33);
            this.cb_clientID.TabIndex = 0;
            this.cb_clientID.SelectedIndexChanged += new System.EventHandler(this.cb_clientID_SelectedIndexChanged);
            // 
            // cb_invoiceNo
            // 
            this.cb_invoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_invoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_invoiceNo.FormattingEnabled = true;
            this.cb_invoiceNo.Location = new System.Drawing.Point(139, 44);
            this.cb_invoiceNo.Name = "cb_invoiceNo";
            this.cb_invoiceNo.Size = new System.Drawing.Size(121, 33);
            this.cb_invoiceNo.TabIndex = 1;
            this.cb_invoiceNo.SelectedIndexChanged += new System.EventHandler(this.cb_invoiceNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "InvoiceNo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "ClientID";
            // 
            // lb_clientname
            // 
            this.lb_clientname.AutoSize = true;
            this.lb_clientname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientname.Location = new System.Drawing.Point(645, 119);
            this.lb_clientname.Name = "lb_clientname";
            this.lb_clientname.Size = new System.Drawing.Size(0, 25);
            this.lb_clientname.TabIndex = 4;
            // 
            // lb_clientaddress
            // 
            this.lb_clientaddress.AutoSize = true;
            this.lb_clientaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientaddress.Location = new System.Drawing.Point(645, 156);
            this.lb_clientaddress.Name = "lb_clientaddress";
            this.lb_clientaddress.Size = new System.Drawing.Size(0, 25);
            this.lb_clientaddress.TabIndex = 5;
            // 
            // lb_clientcontact
            // 
            this.lb_clientcontact.AutoSize = true;
            this.lb_clientcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientcontact.Location = new System.Drawing.Point(645, 276);
            this.lb_clientcontact.Name = "lb_clientcontact";
            this.lb_clientcontact.Size = new System.Drawing.Size(0, 25);
            this.lb_clientcontact.TabIndex = 6;
            // 
            // lb_invoicedate
            // 
            this.lb_invoicedate.AutoSize = true;
            this.lb_invoicedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoicedate.Location = new System.Drawing.Point(176, 119);
            this.lb_invoicedate.Name = "lb_invoicedate";
            this.lb_invoicedate.Size = new System.Drawing.Size(0, 25);
            this.lb_invoicedate.TabIndex = 7;
            // 
            // lb_invoiceduedate
            // 
            this.lb_invoiceduedate.AutoSize = true;
            this.lb_invoiceduedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoiceduedate.Location = new System.Drawing.Point(176, 156);
            this.lb_invoiceduedate.Name = "lb_invoiceduedate";
            this.lb_invoiceduedate.Size = new System.Drawing.Size(0, 25);
            this.lb_invoiceduedate.TabIndex = 8;
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_amount.Location = new System.Drawing.Point(176, 193);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(0, 25);
            this.lb_amount.TabIndex = 9;
            // 
            // lb_invoicedescription
            // 
            this.lb_invoicedescription.AutoSize = true;
            this.lb_invoicedescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoicedescription.Location = new System.Drawing.Point(176, 230);
            this.lb_invoicedescription.Name = "lb_invoicedescription";
            this.lb_invoicedescription.Size = new System.Drawing.Size(0, 25);
            this.lb_invoicedescription.TabIndex = 10;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_print.Font = new System.Drawing.Font("Hobo Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(538, 435);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(181, 48);
            this.btn_print.TabIndex = 11;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Creation Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Desciption:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Contact:";
            // 
            // FM_PrintInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(928, 530);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.lb_invoicedescription);
            this.Controls.Add(this.lb_amount);
            this.Controls.Add(this.lb_invoiceduedate);
            this.Controls.Add(this.lb_invoicedate);
            this.Controls.Add(this.lb_clientcontact);
            this.Controls.Add(this.lb_clientaddress);
            this.Controls.Add(this.lb_clientname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_invoiceNo);
            this.Controls.Add(this.cb_clientID);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(946, 577);
            this.MinimumSize = new System.Drawing.Size(946, 577);
            this.Name = "FM_PrintInvoices";
            this.Text = "Print Invoices";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FM_PrintInvoices_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_clientID;
        private System.Windows.Forms.ComboBox cb_invoiceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_clientname;
        private System.Windows.Forms.Label lb_clientaddress;
        private System.Windows.Forms.Label lb_clientcontact;
        private System.Windows.Forms.Label lb_invoicedate;
        private System.Windows.Forms.Label lb_invoiceduedate;
        private System.Windows.Forms.Label lb_amount;
        private System.Windows.Forms.Label lb_invoicedescription;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}