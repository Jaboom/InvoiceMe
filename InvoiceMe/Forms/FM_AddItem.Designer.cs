﻿namespace InvoiceMe.Forms
{
    partial class FM_AddItem
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
            this.tb_price = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.nud_unit = new System.Windows.Forms.NumericUpDown();
            this.cb_Description = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_unit)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(39, 228);
            this.tb_price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(104, 26);
            this.tb_price.TabIndex = 2;
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.Location = new System.Drawing.Point(17, 301);
            this.btn_accept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(98, 38);
            this.btn_accept.TabIndex = 3;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // nud_unit
            // 
            this.nud_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_unit.Location = new System.Drawing.Point(17, 58);
            this.nud_unit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_unit.Name = "nud_unit";
            this.nud_unit.Size = new System.Drawing.Size(90, 26);
            this.nud_unit.TabIndex = 0;
            // 
            // cb_Description
            // 
            this.cb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Description.FormattingEnabled = true;
            this.cb_Description.Items.AddRange(new object[] {
            "Hours of Work",
            "Toys",
            "Chocolate"});
            this.cb_Description.Location = new System.Drawing.Point(17, 141);
            this.cb_Description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Description.Name = "cb_Description";
            this.cb_Description.Size = new System.Drawing.Size(230, 28);
            this.cb_Description.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "What is It?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "How Much per Unit?";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Tomato;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(148, 301);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 38);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "£";
            // 
            // FM_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(276, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Description);
            this.Controls.Add(this.nud_unit);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.tb_price);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 462);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(292, 462);
            this.Name = "FM_AddItem";
            this.Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)(this.nud_unit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.NumericUpDown nud_unit;
        private System.Windows.Forms.ComboBox cb_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label4;
    }
}