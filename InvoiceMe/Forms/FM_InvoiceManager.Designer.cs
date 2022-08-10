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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_invoiceID = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_editItem = new System.Windows.Forms.Button();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.dtp_paidDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_receivedDate = new System.Windows.Forms.DateTimePicker();
            this.btn_new = new System.Windows.Forms.Button();
            this.pnl_edit = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_editof = new System.Windows.Forms.Label();
            this.lb_invoiceTotal = new System.Windows.Forms.Label();
            this.tb_invoiceNo = new System.Windows.Forms.TextBox();
            this.btn_nextInvoice = new System.Windows.Forms.Button();
            this.btn_previousInvoice = new System.Windows.Forms.Button();
            this.tickBox_editMode = new System.Windows.Forms.CheckBox();
            this.lb_paidDate = new System.Windows.Forms.Label();
            this.lb_receivedDate = new System.Windows.Forms.Label();
            this.tickbox_paid = new System.Windows.Forms.CheckBox();
            this.tickbox_Receied = new System.Windows.Forms.CheckBox();
            this.lb_producedDate = new System.Windows.Forms.Label();
            this.tb_invoiceAmount = new System.Windows.Forms.TextBox();
            this.tb_InvoiceDescription = new System.Windows.Forms.TextBox();
            this.lb_invoiceTitle = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_clientName = new System.Windows.Forms.ComboBox();
            this.lb_clientLatepaid = new System.Windows.Forms.Label();
            this.lb_clientEmail = new System.Windows.Forms.Label();
            this.lb_clientMobile = new System.Windows.Forms.Label();
            this.lb_clientTelephone = new System.Windows.Forms.Label();
            this.lb_clientAddress = new System.Windows.Forms.Label();
            this.lb_clientID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Invoice Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Invoice Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Produced Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Received";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 470);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Recevied Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 522);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Paid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 574);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Paid Date";
            // 
            // lb_invoiceID
            // 
            this.lb_invoiceID.AutoSize = true;
            this.lb_invoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoiceID.Location = new System.Drawing.Point(217, 79);
            this.lb_invoiceID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_invoiceID.Name = "lb_invoiceID";
            this.lb_invoiceID.Size = new System.Drawing.Size(25, 24);
            this.lb_invoiceID.TabIndex = 9;
            this.lb_invoiceID.Text = "...";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.splitContainer1.Panel1.Controls.Add(this.btn_editItem);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addItem);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_paidDate);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_receivedDate);
            this.splitContainer1.Panel1.Controls.Add(this.btn_new);
            this.splitContainer1.Panel1.Controls.Add(this.pnl_edit);
            this.splitContainer1.Panel1.Controls.Add(this.lb_paidDate);
            this.splitContainer1.Panel1.Controls.Add(this.lb_receivedDate);
            this.splitContainer1.Panel1.Controls.Add(this.tickbox_paid);
            this.splitContainer1.Panel1.Controls.Add(this.tickbox_Receied);
            this.splitContainer1.Panel1.Controls.Add(this.lb_producedDate);
            this.splitContainer1.Panel1.Controls.Add(this.tb_invoiceAmount);
            this.splitContainer1.Panel1.Controls.Add(this.tb_InvoiceDescription);
            this.splitContainer1.Panel1.Controls.Add(this.lb_invoiceTitle);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lb_invoiceID);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.cb_clientName);
            this.splitContainer1.Panel2.Controls.Add(this.lb_clientLatepaid);
            this.splitContainer1.Panel2.Controls.Add(this.lb_clientEmail);
            this.splitContainer1.Panel2.Controls.Add(this.lb_clientMobile);
            this.splitContainer1.Panel2.Controls.Add(this.lb_clientTelephone);
            this.splitContainer1.Panel2.Controls.Add(this.lb_clientAddress);
            this.splitContainer1.Panel2.Controls.Add(this.lb_clientID);
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(885, 690);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 10;
            // 
            // btn_editItem
            // 
            this.btn_editItem.BackColor = System.Drawing.Color.Tomato;
            this.btn_editItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editItem.Location = new System.Drawing.Point(316, 129);
            this.btn_editItem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editItem.Name = "btn_editItem";
            this.btn_editItem.Size = new System.Drawing.Size(90, 28);
            this.btn_editItem.TabIndex = 1;
            this.btn_editItem.Text = "Edit Item";
            this.btn_editItem.UseVisualStyleBackColor = false;
            this.btn_editItem.Visible = false;
            this.btn_editItem.Click += new System.EventHandler(this.btn_editItem_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_addItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.Location = new System.Drawing.Point(220, 129);
            this.btn_addItem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(90, 28);
            this.btn_addItem.TabIndex = 0;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // dtp_paidDate
            // 
            this.dtp_paidDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_paidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_paidDate.Location = new System.Drawing.Point(268, 522);
            this.dtp_paidDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_paidDate.Name = "dtp_paidDate";
            this.dtp_paidDate.Size = new System.Drawing.Size(145, 32);
            this.dtp_paidDate.TabIndex = 9;
            // 
            // dtp_receivedDate
            // 
            this.dtp_receivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_receivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_receivedDate.Location = new System.Drawing.Point(268, 418);
            this.dtp_receivedDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_receivedDate.Name = "dtp_receivedDate";
            this.dtp_receivedDate.Size = new System.Drawing.Size(145, 32);
            this.dtp_receivedDate.TabIndex = 6;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(8, 617);
            this.btn_new.Margin = new System.Windows.Forms.Padding(2);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(156, 48);
            this.btn_new.TabIndex = 11;
            this.btn_new.Text = "Create New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // pnl_edit
            // 
            this.pnl_edit.BackColor = System.Drawing.Color.Tomato;
            this.pnl_edit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_edit.Controls.Add(this.btn_delete);
            this.pnl_edit.Controls.Add(this.lb_editof);
            this.pnl_edit.Controls.Add(this.lb_invoiceTotal);
            this.pnl_edit.Controls.Add(this.tb_invoiceNo);
            this.pnl_edit.Controls.Add(this.btn_nextInvoice);
            this.pnl_edit.Controls.Add(this.btn_previousInvoice);
            this.pnl_edit.Controls.Add(this.tickBox_editMode);
            this.pnl_edit.Location = new System.Drawing.Point(171, 617);
            this.pnl_edit.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_edit.Name = "pnl_edit";
            this.pnl_edit.Size = new System.Drawing.Size(270, 49);
            this.pnl_edit.TabIndex = 24;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(233, 4);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(26, 36);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "X";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lb_editof
            // 
            this.lb_editof.AutoSize = true;
            this.lb_editof.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_editof.Location = new System.Drawing.Point(140, 10);
            this.lb_editof.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_editof.Name = "lb_editof";
            this.lb_editof.Size = new System.Drawing.Size(25, 24);
            this.lb_editof.TabIndex = 27;
            this.lb_editof.Text = "of";
            this.lb_editof.Visible = false;
            // 
            // lb_invoiceTotal
            // 
            this.lb_invoiceTotal.AutoSize = true;
            this.lb_invoiceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoiceTotal.Location = new System.Drawing.Point(164, 10);
            this.lb_invoiceTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_invoiceTotal.Name = "lb_invoiceTotal";
            this.lb_invoiceTotal.Size = new System.Drawing.Size(30, 24);
            this.lb_invoiceTotal.TabIndex = 26;
            this.lb_invoiceTotal.Text = "10";
            this.lb_invoiceTotal.Visible = false;
            // 
            // tb_invoiceNo
            // 
            this.tb_invoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_invoiceNo.Location = new System.Drawing.Point(103, 6);
            this.tb_invoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.tb_invoiceNo.Name = "tb_invoiceNo";
            this.tb_invoiceNo.Size = new System.Drawing.Size(36, 32);
            this.tb_invoiceNo.TabIndex = 15;
            this.tb_invoiceNo.TabStop = false;
            this.tb_invoiceNo.Text = "1";
            this.tb_invoiceNo.Visible = false;
            this.tb_invoiceNo.TextChanged += new System.EventHandler(this.tb_invoiceNo_TextChanged);
            this.tb_invoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_invoiceNo_KeyPress);
            // 
            // btn_nextInvoice
            // 
            this.btn_nextInvoice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_nextInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nextInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nextInvoice.Location = new System.Drawing.Point(198, 4);
            this.btn_nextInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nextInvoice.Name = "btn_nextInvoice";
            this.btn_nextInvoice.Size = new System.Drawing.Size(26, 36);
            this.btn_nextInvoice.TabIndex = 16;
            this.btn_nextInvoice.TabStop = false;
            this.btn_nextInvoice.Text = ">";
            this.btn_nextInvoice.UseVisualStyleBackColor = false;
            this.btn_nextInvoice.Visible = false;
            this.btn_nextInvoice.Click += new System.EventHandler(this.btn_nextInvoice_Click);
            // 
            // btn_previousInvoice
            // 
            this.btn_previousInvoice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_previousInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_previousInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previousInvoice.Location = new System.Drawing.Point(70, 4);
            this.btn_previousInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btn_previousInvoice.Name = "btn_previousInvoice";
            this.btn_previousInvoice.Size = new System.Drawing.Size(26, 36);
            this.btn_previousInvoice.TabIndex = 14;
            this.btn_previousInvoice.TabStop = false;
            this.btn_previousInvoice.Text = "<";
            this.btn_previousInvoice.UseVisualStyleBackColor = false;
            this.btn_previousInvoice.Visible = false;
            this.btn_previousInvoice.Click += new System.EventHandler(this.btn_previousInvoice_Click);
            // 
            // tickBox_editMode
            // 
            this.tickBox_editMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.tickBox_editMode.AutoSize = true;
            this.tickBox_editMode.BackColor = System.Drawing.Color.White;
            this.tickBox_editMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickBox_editMode.Location = new System.Drawing.Point(8, 4);
            this.tickBox_editMode.Margin = new System.Windows.Forms.Padding(2);
            this.tickBox_editMode.Name = "tickBox_editMode";
            this.tickBox_editMode.Size = new System.Drawing.Size(56, 34);
            this.tickBox_editMode.TabIndex = 12;
            this.tickBox_editMode.Text = "Edit";
            this.tickBox_editMode.UseVisualStyleBackColor = false;
            this.tickBox_editMode.CheckedChanged += new System.EventHandler(this.tickBox_editMode_CheckedChanged);
            // 
            // lb_paidDate
            // 
            this.lb_paidDate.AutoSize = true;
            this.lb_paidDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_paidDate.Location = new System.Drawing.Point(217, 579);
            this.lb_paidDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_paidDate.Name = "lb_paidDate";
            this.lb_paidDate.Size = new System.Drawing.Size(113, 24);
            this.lb_paidDate.TabIndex = 10;
            this.lb_paidDate.Text = "- - / - - / - - - -";
            // 
            // lb_receivedDate
            // 
            this.lb_receivedDate.AutoSize = true;
            this.lb_receivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_receivedDate.Location = new System.Drawing.Point(217, 475);
            this.lb_receivedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_receivedDate.Name = "lb_receivedDate";
            this.lb_receivedDate.Size = new System.Drawing.Size(113, 24);
            this.lb_receivedDate.TabIndex = 7;
            this.lb_receivedDate.Text = "- - / - - / - - - -";
            // 
            // tickbox_paid
            // 
            this.tickbox_paid.Appearance = System.Windows.Forms.Appearance.Button;
            this.tickbox_paid.BackColor = System.Drawing.Color.LightCoral;
            this.tickbox_paid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tickbox_paid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tickbox_paid.FlatAppearance.BorderSize = 5;
            this.tickbox_paid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tickbox_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickbox_paid.Location = new System.Drawing.Point(222, 522);
            this.tickbox_paid.Margin = new System.Windows.Forms.Padding(2);
            this.tickbox_paid.Name = "tickbox_paid";
            this.tickbox_paid.Size = new System.Drawing.Size(32, 31);
            this.tickbox_paid.TabIndex = 8;
            this.tickbox_paid.UseVisualStyleBackColor = false;
            this.tickbox_paid.CheckedChanged += new System.EventHandler(this.tickbox_paid_CheckedChanged);
            // 
            // tickbox_Receied
            // 
            this.tickbox_Receied.Appearance = System.Windows.Forms.Appearance.Button;
            this.tickbox_Receied.BackColor = System.Drawing.Color.LightCoral;
            this.tickbox_Receied.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tickbox_Receied.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tickbox_Receied.FlatAppearance.BorderSize = 5;
            this.tickbox_Receied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tickbox_Receied.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickbox_Receied.Location = new System.Drawing.Point(222, 418);
            this.tickbox_Receied.Margin = new System.Windows.Forms.Padding(2);
            this.tickbox_Receied.Name = "tickbox_Receied";
            this.tickbox_Receied.Size = new System.Drawing.Size(32, 31);
            this.tickbox_Receied.TabIndex = 5;
            this.tickbox_Receied.UseVisualStyleBackColor = false;
            this.tickbox_Receied.CheckedChanged += new System.EventHandler(this.tickbox_Receied_CheckedChanged);
            // 
            // lb_producedDate
            // 
            this.lb_producedDate.AutoSize = true;
            this.lb_producedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_producedDate.Location = new System.Drawing.Point(217, 371);
            this.lb_producedDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_producedDate.Name = "lb_producedDate";
            this.lb_producedDate.Size = new System.Drawing.Size(113, 24);
            this.lb_producedDate.TabIndex = 4;
            this.lb_producedDate.Text = "- - / - - / - - - -";
            // 
            // tb_invoiceAmount
            // 
            this.tb_invoiceAmount.BackColor = System.Drawing.SystemColors.Window;
            this.tb_invoiceAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_invoiceAmount.Enabled = false;
            this.tb_invoiceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_invoiceAmount.Location = new System.Drawing.Point(222, 317);
            this.tb_invoiceAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_invoiceAmount.Name = "tb_invoiceAmount";
            this.tb_invoiceAmount.ReadOnly = true;
            this.tb_invoiceAmount.Size = new System.Drawing.Size(186, 28);
            this.tb_invoiceAmount.TabIndex = 3;
            // 
            // tb_InvoiceDescription
            // 
            this.tb_InvoiceDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_InvoiceDescription.Enabled = false;
            this.tb_InvoiceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_InvoiceDescription.Location = new System.Drawing.Point(14, 168);
            this.tb_InvoiceDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tb_InvoiceDescription.Multiline = true;
            this.tb_InvoiceDescription.Name = "tb_InvoiceDescription";
            this.tb_InvoiceDescription.ReadOnly = true;
            this.tb_InvoiceDescription.Size = new System.Drawing.Size(393, 133);
            this.tb_InvoiceDescription.TabIndex = 2;
            this.tb_InvoiceDescription.TextChanged += new System.EventHandler(this.tb_InvoiceDescription_TextChanged);
            // 
            // lb_invoiceTitle
            // 
            this.lb_invoiceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_invoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoiceTitle.Location = new System.Drawing.Point(0, 0);
            this.lb_invoiceTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_invoiceTitle.Name = "lb_invoiceTitle";
            this.lb_invoiceTitle.Size = new System.Drawing.Size(441, 31);
            this.lb_invoiceTitle.TabIndex = 10;
            this.lb_invoiceTitle.Text = "New Invoice";
            this.lb_invoiceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(430, 31);
            this.label17.TabIndex = 17;
            this.label17.Text = "Selected Client";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_clientName
            // 
            this.cb_clientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_clientName.FormattingEnabled = true;
            this.cb_clientName.Location = new System.Drawing.Point(172, 72);
            this.cb_clientName.Margin = new System.Windows.Forms.Padding(2);
            this.cb_clientName.MaxDropDownItems = 100;
            this.cb_clientName.Name = "cb_clientName";
            this.cb_clientName.Size = new System.Drawing.Size(188, 30);
            this.cb_clientName.TabIndex = 0;
            this.cb_clientName.SelectedIndexChanged += new System.EventHandler(this.cb_clientName_SelectedIndexChanged);
            // 
            // lb_clientLatepaid
            // 
            this.lb_clientLatepaid.AutoSize = true;
            this.lb_clientLatepaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientLatepaid.Location = new System.Drawing.Point(168, 526);
            this.lb_clientLatepaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_clientLatepaid.Name = "lb_clientLatepaid";
            this.lb_clientLatepaid.Size = new System.Drawing.Size(25, 24);
            this.lb_clientLatepaid.TabIndex = 15;
            this.lb_clientLatepaid.Text = "...";
            // 
            // lb_clientEmail
            // 
            this.lb_clientEmail.AutoSize = true;
            this.lb_clientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientEmail.Location = new System.Drawing.Point(168, 475);
            this.lb_clientEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_clientEmail.Name = "lb_clientEmail";
            this.lb_clientEmail.Size = new System.Drawing.Size(25, 24);
            this.lb_clientEmail.TabIndex = 14;
            this.lb_clientEmail.Text = "...";
            // 
            // lb_clientMobile
            // 
            this.lb_clientMobile.AutoSize = true;
            this.lb_clientMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientMobile.Location = new System.Drawing.Point(168, 423);
            this.lb_clientMobile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_clientMobile.Name = "lb_clientMobile";
            this.lb_clientMobile.Size = new System.Drawing.Size(25, 24);
            this.lb_clientMobile.TabIndex = 13;
            this.lb_clientMobile.Text = "...";
            // 
            // lb_clientTelephone
            // 
            this.lb_clientTelephone.AutoSize = true;
            this.lb_clientTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientTelephone.Location = new System.Drawing.Point(168, 371);
            this.lb_clientTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_clientTelephone.Name = "lb_clientTelephone";
            this.lb_clientTelephone.Size = new System.Drawing.Size(25, 24);
            this.lb_clientTelephone.TabIndex = 12;
            this.lb_clientTelephone.Text = "...";
            // 
            // lb_clientAddress
            // 
            this.lb_clientAddress.AutoSize = true;
            this.lb_clientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientAddress.Location = new System.Drawing.Point(67, 228);
            this.lb_clientAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_clientAddress.Name = "lb_clientAddress";
            this.lb_clientAddress.Size = new System.Drawing.Size(148, 96);
            this.lb_clientAddress.TabIndex = 11;
            this.lb_clientAddress.Text = "-Address Line 1-\r\n-Address Line 2-\r\n-City-\r\n-Postcode-";
            // 
            // lb_clientID
            // 
            this.lb_clientID.AutoSize = true;
            this.lb_clientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clientID.Location = new System.Drawing.Point(181, 131);
            this.lb_clientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_clientID.Name = "lb_clientID";
            this.lb_clientID.Size = new System.Drawing.Size(25, 24);
            this.lb_clientID.TabIndex = 10;
            this.lb_clientID.Text = "...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 522);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 26);
            this.label16.TabIndex = 7;
            this.label16.Text = "Late Paid";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 470);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 26);
            this.label15.TabIndex = 6;
            this.label15.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 418);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 26);
            this.label14.TabIndex = 5;
            this.label14.Text = "Mobile";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 366);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 26);
            this.label13.TabIndex = 4;
            this.label13.Text = "Telephone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "Address ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 126);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Client Name";
            // 
            // FM_InvoiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 690);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(905, 739);
            this.MinimumSize = new System.Drawing.Size(905, 598);
            this.Name = "FM_InvoiceManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FM_InvoiceManager_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_edit.ResumeLayout(false);
            this.pnl_edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_invoiceID;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lb_invoiceTitle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_producedDate;
        private System.Windows.Forms.TextBox tb_InvoiceDescription;
        private System.Windows.Forms.CheckBox tickbox_Receied;
        private System.Windows.Forms.CheckBox tickbox_paid;
        private System.Windows.Forms.Label lb_paidDate;
        private System.Windows.Forms.Label lb_receivedDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_clientName;
        private System.Windows.Forms.Label lb_clientLatepaid;
        private System.Windows.Forms.Label lb_clientEmail;
        private System.Windows.Forms.Label lb_clientMobile;
        private System.Windows.Forms.Label lb_clientTelephone;
        private System.Windows.Forms.Label lb_clientAddress;
        private System.Windows.Forms.Label lb_clientID;
        private System.Windows.Forms.Panel pnl_edit;
        private System.Windows.Forms.CheckBox tickBox_editMode;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_nextInvoice;
        private System.Windows.Forms.Button btn_previousInvoice;
        private System.Windows.Forms.Label lb_editof;
        private System.Windows.Forms.Label lb_invoiceTotal;
        private System.Windows.Forms.TextBox tb_invoiceNo;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DateTimePicker dtp_paidDate;
        private System.Windows.Forms.DateTimePicker dtp_receivedDate;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.TextBox tb_invoiceAmount;
        private System.Windows.Forms.Button btn_editItem;
    }
}