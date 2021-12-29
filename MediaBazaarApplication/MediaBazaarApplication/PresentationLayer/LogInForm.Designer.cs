namespace MediaBazaarApplication
{
    partial class LogInForm
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
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.btnSetPass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowNewPassword = new System.Windows.Forms.Button();
            this.btnShowOldPassword = new System.Windows.Forms.Button();
            this.btnWin1 = new System.Windows.Forms.Button();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.btnWin2 = new System.Windows.Forms.Button();
            this.pnlLogIn.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.btnViewPassword);
            this.pnlLogIn.Controls.Add(this.btnWin2);
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.label3);
            this.pnlLogIn.Controls.Add(this.tbPassword);
            this.pnlLogIn.Controls.Add(this.label2);
            this.pnlLogIn.Controls.Add(this.tbEmail);
            this.pnlLogIn.Controls.Add(this.label1);
            this.pnlLogIn.Location = new System.Drawing.Point(9, 10);
            this.pnlLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(354, 492);
            this.pnlLogIn.TabIndex = 0;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(20, 378);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(181, 90);
            this.btnLogIn.TabIndex = 11;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(20, 306);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(265, 34);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(20, 223);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(314, 34);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 43.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 83);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOG IN";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btnShowNewPassword);
            this.pnlRegister.Controls.Add(this.btnShowOldPassword);
            this.pnlRegister.Controls.Add(this.btnWin1);
            this.pnlRegister.Controls.Add(this.label7);
            this.pnlRegister.Controls.Add(this.tbNewPassword);
            this.pnlRegister.Controls.Add(this.btnSetPass);
            this.pnlRegister.Controls.Add(this.label4);
            this.pnlRegister.Controls.Add(this.tbOldPassword);
            this.pnlRegister.Controls.Add(this.label5);
            this.pnlRegister.Controls.Add(this.tbEmail2);
            this.pnlRegister.Controls.Add(this.label6);
            this.pnlRegister.Location = new System.Drawing.Point(12, 12);
            this.pnlRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(354, 492);
            this.pnlRegister.TabIndex = 12;
            this.pnlRegister.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "New Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(17, 306);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(265, 34);
            this.tbNewPassword.TabIndex = 12;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNewPassword_KeyDown);
            // 
            // btnSetPass
            // 
            this.btnSetPass.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPass.ForeColor = System.Drawing.Color.White;
            this.btnSetPass.Location = new System.Drawing.Point(17, 389);
            this.btnSetPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetPass.Name = "btnSetPass";
            this.btnSetPass.Size = new System.Drawing.Size(181, 79);
            this.btnSetPass.TabIndex = 11;
            this.btnSetPass.Text = "Set Password";
            this.btnSetPass.UseVisualStyleBackColor = false;
            this.btnSetPass.Click += new System.EventHandler(this.btnSetPass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Old Password";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPassword.Location = new System.Drawing.Point(17, 223);
            this.tbOldPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.Size = new System.Drawing.Size(265, 34);
            this.tbOldPassword.TabIndex = 9;
            this.tbOldPassword.UseSystemPasswordChar = true;
            this.tbOldPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOldPassword_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // tbEmail2
            // 
            this.tbEmail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail2.Location = new System.Drawing.Point(17, 140);
            this.tbEmail2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail2.Name = "tbEmail2";
            this.tbEmail2.Size = new System.Drawing.Size(316, 34);
            this.tbEmail2.TabIndex = 7;
            this.tbEmail2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail2_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 44);
            this.label6.TabIndex = 6;
            this.label6.Text = "SET PASSWORD";
            // 
            // btnShowNewPassword
            // 
            this.btnShowNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowNewPassword.BackgroundImage = global::MediaBazaarApplication.Properties.Resources.view__1_;
            this.btnShowNewPassword.FlatAppearance.BorderSize = 0;
            this.btnShowNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNewPassword.Location = new System.Drawing.Point(290, 302);
            this.btnShowNewPassword.Name = "btnShowNewPassword";
            this.btnShowNewPassword.Size = new System.Drawing.Size(43, 36);
            this.btnShowNewPassword.TabIndex = 16;
            this.btnShowNewPassword.UseVisualStyleBackColor = false;
            this.btnShowNewPassword.MouseLeave += new System.EventHandler(this.btnShowNewPassword_MouseLeave);
            this.btnShowNewPassword.MouseHover += new System.EventHandler(this.btnShowNewPassword_MouseHover);
            // 
            // btnShowOldPassword
            // 
            this.btnShowOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowOldPassword.BackgroundImage = global::MediaBazaarApplication.Properties.Resources.view__1_;
            this.btnShowOldPassword.FlatAppearance.BorderSize = 0;
            this.btnShowOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOldPassword.Location = new System.Drawing.Point(290, 221);
            this.btnShowOldPassword.Name = "btnShowOldPassword";
            this.btnShowOldPassword.Size = new System.Drawing.Size(43, 36);
            this.btnShowOldPassword.TabIndex = 15;
            this.btnShowOldPassword.UseVisualStyleBackColor = false;
            this.btnShowOldPassword.MouseLeave += new System.EventHandler(this.btnShowOldPassword_MouseLeave);
            this.btnShowOldPassword.MouseHover += new System.EventHandler(this.btnShowOldPassword_MouseHover);
            // 
            // btnWin1
            // 
            this.btnWin1.FlatAppearance.BorderSize = 0;
            this.btnWin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWin1.ForeColor = System.Drawing.Color.White;
            this.btnWin1.Image = global::MediaBazaarApplication.Properties.Resources.refreshingcurvearrows_121971__1_;
            this.btnWin1.Location = new System.Drawing.Point(224, 387);
            this.btnWin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWin1.Name = "btnWin1";
            this.btnWin1.Size = new System.Drawing.Size(109, 79);
            this.btnWin1.TabIndex = 14;
            this.btnWin1.Text = "LogIn";
            this.btnWin1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWin1.UseVisualStyleBackColor = true;
            this.btnWin1.Click += new System.EventHandler(this.btnWin1_Click);
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewPassword.BackgroundImage = global::MediaBazaarApplication.Properties.Resources.view__1_;
            this.btnViewPassword.FlatAppearance.BorderSize = 0;
            this.btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPassword.Location = new System.Drawing.Point(291, 304);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(43, 36);
            this.btnViewPassword.TabIndex = 13;
            this.btnViewPassword.UseVisualStyleBackColor = false;
            this.btnViewPassword.MouseLeave += new System.EventHandler(this.btnViewPassword_MouseLeave);
            this.btnViewPassword.MouseHover += new System.EventHandler(this.btnViewPassword_MouseHover);
            // 
            // btnWin2
            // 
            this.btnWin2.FlatAppearance.BorderSize = 0;
            this.btnWin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWin2.ForeColor = System.Drawing.Color.White;
            this.btnWin2.Image = global::MediaBazaarApplication.Properties.Resources.refreshingcurvearrows_121971__1_;
            this.btnWin2.Location = new System.Drawing.Point(208, 378);
            this.btnWin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWin2.Name = "btnWin2";
            this.btnWin2.Size = new System.Drawing.Size(128, 92);
            this.btnWin2.TabIndex = 12;
            this.btnWin2.Text = "Set Password";
            this.btnWin2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWin2.UseVisualStyleBackColor = true;
            this.btnWin2.Click += new System.EventHandler(this.btnWin2_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(359, 514);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.pnlRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogInForm_FormClosed);
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Button btnWin2;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Button btnSetPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEmail2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWin1;
        private System.Windows.Forms.Button btnViewPassword;
        private System.Windows.Forms.Button btnShowNewPassword;
        private System.Windows.Forms.Button btnShowOldPassword;
    }
}