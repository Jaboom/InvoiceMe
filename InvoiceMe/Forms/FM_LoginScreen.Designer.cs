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
            this.TBuser.Location = new System.Drawing.Point(316, 182);
            this.TBuser.Name = "TBuser";
            this.TBuser.Size = new System.Drawing.Size(224, 38);
            this.TBuser.TabIndex = 0;
            // 
            // TBpassword
            // 
            this.TBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpassword.Location = new System.Drawing.Point(316, 258);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(224, 38);
            this.TBpassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // BTNlogin
            // 
            this.BTNlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNlogin.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNlogin.Location = new System.Drawing.Point(316, 447);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(224, 56);
            this.BTNlogin.TabIndex = 4;
            this.BTNlogin.Text = "Login";
            this.BTNlogin.UseVisualStyleBackColor = false;
            this.BTNlogin.Click += new System.EventHandler(this.BTNlogin_Click);
            // 
            // lb_headerLogin
            // 
            this.lb_headerLogin.BackColor = System.Drawing.Color.SkyBlue;
            this.lb_headerLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_headerLogin.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_headerLogin.Location = new System.Drawing.Point(33, 50);
            this.lb_headerLogin.Name = "lb_headerLogin";
            this.lb_headerLogin.Size = new System.Drawing.Size(507, 42);
            this.lb_headerLogin.TabIndex = 5;
            this.lb_headerLogin.Text = "Create Owner Account";
            this.lb_headerLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_comfirmPass
            // 
            this.lb_comfirmPass.AutoSize = true;
            this.lb_comfirmPass.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_comfirmPass.Location = new System.Drawing.Point(26, 334);
            this.lb_comfirmPass.Name = "lb_comfirmPass";
            this.lb_comfirmPass.Size = new System.Drawing.Size(270, 40);
            this.lb_comfirmPass.TabIndex = 7;
            this.lb_comfirmPass.Text = "Comfirm Password";
            // 
            // tb_comfirmPass
            // 
            this.tb_comfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comfirmPass.Location = new System.Drawing.Point(316, 334);
            this.tb_comfirmPass.Name = "tb_comfirmPass";
            this.tb_comfirmPass.PasswordChar = '*';
            this.tb_comfirmPass.Size = new System.Drawing.Size(224, 38);
            this.tb_comfirmPass.TabIndex = 6;
            // 
            // FM_LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.lb_comfirmPass);
            this.Controls.Add(this.tb_comfirmPass);
            this.Controls.Add(this.lb_headerLogin);
            this.Controls.Add(this.BTNlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBuser);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
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

