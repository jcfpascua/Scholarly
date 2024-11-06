namespace Scholarly.View
{
    partial class LoginView
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
            this.Tb_StudentUsername = new System.Windows.Forms.TextBox();
            this.Tb_StudentPassword = new System.Windows.Forms.TextBox();
            this.Tb_AdminUsername = new System.Windows.Forms.TextBox();
            this.Tb_AdminPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_StudentLogin = new System.Windows.Forms.Button();
            this.Btn_AdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Login";
            // 
            // Tb_StudentUsername
            // 
            this.Tb_StudentUsername.Location = new System.Drawing.Point(215, 22);
            this.Tb_StudentUsername.Name = "Tb_StudentUsername";
            this.Tb_StudentUsername.Size = new System.Drawing.Size(148, 20);
            this.Tb_StudentUsername.TabIndex = 2;
            // 
            // Tb_StudentPassword
            // 
            this.Tb_StudentPassword.Location = new System.Drawing.Point(215, 48);
            this.Tb_StudentPassword.Name = "Tb_StudentPassword";
            this.Tb_StudentPassword.PasswordChar = '*';
            this.Tb_StudentPassword.Size = new System.Drawing.Size(148, 20);
            this.Tb_StudentPassword.TabIndex = 3;
            // 
            // Tb_AdminUsername
            // 
            this.Tb_AdminUsername.Location = new System.Drawing.Point(215, 110);
            this.Tb_AdminUsername.Name = "Tb_AdminUsername";
            this.Tb_AdminUsername.Size = new System.Drawing.Size(148, 20);
            this.Tb_AdminUsername.TabIndex = 4;
            // 
            // Tb_AdminPassword
            // 
            this.Tb_AdminPassword.Location = new System.Drawing.Point(215, 136);
            this.Tb_AdminPassword.Name = "Tb_AdminPassword";
            this.Tb_AdminPassword.PasswordChar = '*';
            this.Tb_AdminPassword.Size = new System.Drawing.Size(148, 20);
            this.Tb_AdminPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password";
            // 
            // Btn_StudentLogin
            // 
            this.Btn_StudentLogin.Location = new System.Drawing.Point(369, 20);
            this.Btn_StudentLogin.Name = "Btn_StudentLogin";
            this.Btn_StudentLogin.Size = new System.Drawing.Size(95, 23);
            this.Btn_StudentLogin.TabIndex = 10;
            this.Btn_StudentLogin.Text = "Student Login";
            this.Btn_StudentLogin.UseVisualStyleBackColor = true;
            this.Btn_StudentLogin.Click += new System.EventHandler(this.Btn_StudentLogin_Click);
            // 
            // Btn_AdminLogin
            // 
            this.Btn_AdminLogin.Location = new System.Drawing.Point(369, 105);
            this.Btn_AdminLogin.Name = "Btn_AdminLogin";
            this.Btn_AdminLogin.Size = new System.Drawing.Size(95, 23);
            this.Btn_AdminLogin.TabIndex = 11;
            this.Btn_AdminLogin.Text = "Admin Login";
            this.Btn_AdminLogin.UseVisualStyleBackColor = true;
            this.Btn_AdminLogin.Click += new System.EventHandler(this.Btn_AdminLogin_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 186);
            this.Controls.Add(this.Btn_AdminLogin);
            this.Controls.Add(this.Btn_StudentLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_AdminPassword);
            this.Controls.Add(this.Tb_AdminUsername);
            this.Controls.Add(this.Tb_StudentPassword);
            this.Controls.Add(this.Tb_StudentUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_StudentUsername;
        private System.Windows.Forms.TextBox Tb_StudentPassword;
        private System.Windows.Forms.TextBox Tb_AdminUsername;
        private System.Windows.Forms.TextBox Tb_AdminPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_StudentLogin;
        private System.Windows.Forms.Button Btn_AdminLogin;
    }
}