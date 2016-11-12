namespace TimeClock
{
    partial class ConfigPage
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
            this.txt_AdminPass = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txt_FromEmail = new System.Windows.Forms.TextBox();
            this.txt_FromEmailPass = new System.Windows.Forms.TextBox();
            this.txt_ToEmail = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_ConfirmPass = new System.Windows.Forms.Button();
            this.lbl_PasswordRequest = new System.Windows.Forms.Label();
            this.btn_NewPassShow = new System.Windows.Forms.Button();
            this.btn_ConfPassShow = new System.Windows.Forms.Button();
            this.btn_AdminPassShow = new System.Windows.Forms.Button();
            this.btn_FrmEmailPassShow = new System.Windows.Forms.Button();
            this.lbl_Advanced = new System.Windows.Forms.Label();
            this.txt_SMTP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_SMTPServer = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_AdminPass
            // 
            this.txt_AdminPass.Location = new System.Drawing.Point(12, 27);
            this.txt_AdminPass.Name = "txt_AdminPass";
            this.txt_AdminPass.Size = new System.Drawing.Size(260, 20);
            this.txt_AdminPass.TabIndex = 0;
            this.txt_AdminPass.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(12, 94);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "From Email Address Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "To Email Address";
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Enabled = false;
            this.txt_NewPass.Location = new System.Drawing.Point(12, 110);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.Size = new System.Drawing.Size(260, 20);
            this.txt_NewPass.TabIndex = 6;
            this.txt_NewPass.UseSystemPasswordChar = true;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Enabled = false;
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(12, 150);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(260, 20);
            this.txt_ConfirmPassword.TabIndex = 7;
            this.txt_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txt_FromEmail
            // 
            this.txt_FromEmail.Enabled = false;
            this.txt_FromEmail.Location = new System.Drawing.Point(12, 189);
            this.txt_FromEmail.Name = "txt_FromEmail";
            this.txt_FromEmail.Size = new System.Drawing.Size(260, 20);
            this.txt_FromEmail.TabIndex = 8;
            // 
            // txt_FromEmailPass
            // 
            this.txt_FromEmailPass.Enabled = false;
            this.txt_FromEmailPass.Location = new System.Drawing.Point(12, 234);
            this.txt_FromEmailPass.Name = "txt_FromEmailPass";
            this.txt_FromEmailPass.PasswordChar = '*';
            this.txt_FromEmailPass.Size = new System.Drawing.Size(260, 20);
            this.txt_FromEmailPass.TabIndex = 9;
            this.txt_FromEmailPass.UseSystemPasswordChar = true;
            // 
            // txt_ToEmail
            // 
            this.txt_ToEmail.Enabled = false;
            this.txt_ToEmail.Location = new System.Drawing.Point(12, 277);
            this.txt_ToEmail.Name = "txt_ToEmail";
            this.txt_ToEmail.Size = new System.Drawing.Size(260, 20);
            this.txt_ToEmail.TabIndex = 10;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(12, 380);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(315, 22);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "Save";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_ConfirmPass
            // 
            this.btn_ConfirmPass.Location = new System.Drawing.Point(94, 53);
            this.btn_ConfirmPass.Name = "btn_ConfirmPass";
            this.btn_ConfirmPass.Size = new System.Drawing.Size(101, 23);
            this.btn_ConfirmPass.TabIndex = 12;
            this.btn_ConfirmPass.Text = "Submit";
            this.btn_ConfirmPass.UseVisualStyleBackColor = true;
            this.btn_ConfirmPass.Click += new System.EventHandler(this.btn_ConfirmPass_Click);
            // 
            // lbl_PasswordRequest
            // 
            this.lbl_PasswordRequest.AutoSize = true;
            this.lbl_PasswordRequest.Location = new System.Drawing.Point(12, 9);
            this.lbl_PasswordRequest.Name = "lbl_PasswordRequest";
            this.lbl_PasswordRequest.Size = new System.Drawing.Size(262, 13);
            this.lbl_PasswordRequest.TabIndex = 13;
            this.lbl_PasswordRequest.Text = "Please Enter The Administrator Password To Continue";
            // 
            // btn_NewPassShow
            // 
            this.btn_NewPassShow.Location = new System.Drawing.Point(278, 107);
            this.btn_NewPassShow.Name = "btn_NewPassShow";
            this.btn_NewPassShow.Size = new System.Drawing.Size(49, 24);
            this.btn_NewPassShow.TabIndex = 14;
            this.btn_NewPassShow.Text = "Show";
            this.btn_NewPassShow.UseVisualStyleBackColor = true;
            this.btn_NewPassShow.Click += new System.EventHandler(this.btn_NewPassShow_Click);
            // 
            // btn_ConfPassShow
            // 
            this.btn_ConfPassShow.Location = new System.Drawing.Point(278, 146);
            this.btn_ConfPassShow.Name = "btn_ConfPassShow";
            this.btn_ConfPassShow.Size = new System.Drawing.Size(49, 24);
            this.btn_ConfPassShow.TabIndex = 15;
            this.btn_ConfPassShow.Text = "Show";
            this.btn_ConfPassShow.UseVisualStyleBackColor = true;
            this.btn_ConfPassShow.Click += new System.EventHandler(this.btn_ConfPassShow_Click);
            // 
            // btn_AdminPassShow
            // 
            this.btn_AdminPassShow.Location = new System.Drawing.Point(278, 24);
            this.btn_AdminPassShow.Name = "btn_AdminPassShow";
            this.btn_AdminPassShow.Size = new System.Drawing.Size(49, 24);
            this.btn_AdminPassShow.TabIndex = 16;
            this.btn_AdminPassShow.Text = "Show";
            this.btn_AdminPassShow.UseVisualStyleBackColor = true;
            this.btn_AdminPassShow.Click += new System.EventHandler(this.btn_AdminPassShow_Click);
            // 
            // btn_FrmEmailPassShow
            // 
            this.btn_FrmEmailPassShow.Location = new System.Drawing.Point(278, 231);
            this.btn_FrmEmailPassShow.Name = "btn_FrmEmailPassShow";
            this.btn_FrmEmailPassShow.Size = new System.Drawing.Size(49, 24);
            this.btn_FrmEmailPassShow.TabIndex = 17;
            this.btn_FrmEmailPassShow.Text = "Show";
            this.btn_FrmEmailPassShow.UseVisualStyleBackColor = true;
            this.btn_FrmEmailPassShow.Click += new System.EventHandler(this.btn_FrmEmailPassShow_Click);
            // 
            // lbl_Advanced
            // 
            this.lbl_Advanced.AutoSize = true;
            this.lbl_Advanced.Location = new System.Drawing.Point(127, 305);
            this.lbl_Advanced.Name = "lbl_Advanced";
            this.lbl_Advanced.Size = new System.Drawing.Size(56, 13);
            this.lbl_Advanced.TabIndex = 18;
            this.lbl_Advanced.Text = "Advanced";
            // 
            // txt_SMTP
            // 
            this.txt_SMTP.Enabled = false;
            this.txt_SMTP.Location = new System.Drawing.Point(12, 343);
            this.txt_SMTP.Name = "txt_SMTP";
            this.txt_SMTP.Size = new System.Drawing.Size(171, 20);
            this.txt_SMTP.TabIndex = 19;
            // 
            // txt_Port
            // 
            this.txt_Port.Enabled = false;
            this.txt_Port.Location = new System.Drawing.Point(224, 343);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(48, 20);
            this.txt_Port.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Advanced";
            // 
            // lbl_SMTPServer
            // 
            this.lbl_SMTPServer.AutoSize = true;
            this.lbl_SMTPServer.Location = new System.Drawing.Point(12, 327);
            this.lbl_SMTPServer.Name = "lbl_SMTPServer";
            this.lbl_SMTPServer.Size = new System.Drawing.Size(71, 13);
            this.lbl_SMTPServer.TabIndex = 22;
            this.lbl_SMTPServer.Text = "SMTP Server";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(221, 327);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(26, 13);
            this.lbl_Port.TabIndex = 23;
            this.lbl_Port.Text = "Port";
            // 
            // ConfigPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 414);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_SMTPServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_SMTP);
            this.Controls.Add(this.lbl_Advanced);
            this.Controls.Add(this.btn_FrmEmailPassShow);
            this.Controls.Add(this.btn_AdminPassShow);
            this.Controls.Add(this.btn_ConfPassShow);
            this.Controls.Add(this.btn_NewPassShow);
            this.Controls.Add(this.lbl_PasswordRequest);
            this.Controls.Add(this.btn_ConfirmPass);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_ToEmail);
            this.Controls.Add(this.txt_FromEmailPass);
            this.Controls.Add(this.txt_FromEmail);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_AdminPass);
            this.Name = "ConfigPage";
            this.Text = "ConfigPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AdminPass;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.TextBox txt_FromEmail;
        private System.Windows.Forms.TextBox txt_FromEmailPass;
        private System.Windows.Forms.TextBox txt_ToEmail;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_ConfirmPass;
        private System.Windows.Forms.Label lbl_PasswordRequest;
        private System.Windows.Forms.Button btn_NewPassShow;
        private System.Windows.Forms.Button btn_ConfPassShow;
        private System.Windows.Forms.Button btn_AdminPassShow;
        private System.Windows.Forms.Button btn_FrmEmailPassShow;
        private System.Windows.Forms.Label lbl_Advanced;
        private System.Windows.Forms.TextBox txt_SMTP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_SMTPServer;
        private System.Windows.Forms.Label lbl_Port;
    }
}