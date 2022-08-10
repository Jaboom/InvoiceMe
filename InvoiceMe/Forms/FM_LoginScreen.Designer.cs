namespace InvoiceMe
{
    partial class FM_LoginScreen
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
            this.TBuser = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNlogin = new System.Windows.Forms.Button();
            this.lb_headerLogin = new System.Windows.Forms.Label();
            this.lb_comfirmPass = new System.Windows.Forms.Label();
            this.tb_comfirmPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBuser
            // 
            this.TBuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBuser.Location = new System.Drawing.Point(237, 148);
            this.TBuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBuser.Name = "TBuser";
            this.TBuser.Size = new System.Drawing.Size(169, 32);
            this.TBuser.TabIndex = 0;
            // 
            // TBpassword
            // 
            this.TBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpassword.Location = new System.Drawing.Point(237, 210);
            this.TBpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(169, 32);
            this.TBpassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // BTNlogin
            // 
            this.BTNlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNlogin.Location = new System.Drawing.Point(237, 363);
            this.BTNlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(168, 46);
            this.BTNlogin.TabIndex = 3;
            this.BTNlogin.Text = "Login";
            this.BTNlogin.UseVisualStyleBackColor = false;
            this.BTNlogin.Click += new System.EventHandler(this.BTNlogin_Click);
            // 
            // lb_headerLogin
            // 
            this.lb_headerLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.lb_headerLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_headerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_headerLogin.Location = new System.Drawing.Point(25, 41);
            this.lb_headerLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_headerLogin.Name = "lb_headerLogin";
            this.lb_headerLogin.Size = new System.Drawing.Size(380, 34);
            this.lb_headerLogin.TabIndex = 5;
            this.lb_headerLogin.Text = "Create Owner Account";
            this.lb_headerLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_comfirmPass
            // 
            this.lb_comfirmPass.AutoSize = true;
            this.lb_comfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_comfirmPass.Location = new System.Drawing.Point(20, 271);
            this.lb_comfirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_comfirmPass.Name = "lb_comfirmPass";
            this.lb_comfirmPass.Size = new System.Drawing.Size(214, 26);
            this.lb_comfirmPass.TabIndex = 7;
            this.lb_comfirmPass.Text = "Comfirm Password";
            // 
            // tb_comfirmPass
            // 
            this.tb_comfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comfirmPass.Location = new System.Drawing.Point(237, 271);
            this.tb_comfirmPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_comfirmPass.Name = "tb_comfirmPass";
            this.tb_comfirmPass.PasswordChar = '*';
            this.tb_comfirmPass.Size = new System.Drawing.Size(169, 32);
            this.tb_comfirmPass.TabIndex = 2;
            // 
            // FM_LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(438, 456);
            this.Controls.Add(this.lb_comfirmPass);
            this.Controls.Add(this.tb_comfirmPass);
            this.Controls.Add(this.lb_headerLogin);
            this.Controls.Add(this.BTNlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBuser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 495);
            this.MinimumSize = new System.Drawing.Size(454, 495);
            this.Name = "FM_LoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBuser;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNlogin;
        private System.Windows.Forms.Label lb_headerLogin;
        private System.Windows.Forms.Label lb_comfirmPass;
        private System.Windows.Forms.TextBox tb_comfirmPass;
    }
}

