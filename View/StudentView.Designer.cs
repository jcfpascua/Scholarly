namespace Scholarly.View
{
    partial class StudentView
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
            this.Dg_StudentRecord = new System.Windows.Forms.DataGridView();
            this.Btn_LoadRecords = new System.Windows.Forms.Button();
            this.Lbl_StudentName = new System.Windows.Forms.Label();
            this.Btn_Logout = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Tb_UpdatePassword = new System.Windows.Forms.TextBox();
            this.Tb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Btn_UpdatePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_StudentRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg_StudentRecord
            // 
            this.Dg_StudentRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dg_StudentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_StudentRecord.Location = new System.Drawing.Point(12, 51);
            this.Dg_StudentRecord.Name = "Dg_StudentRecord";
            this.Dg_StudentRecord.ReadOnly = true;
            this.Dg_StudentRecord.RowHeadersWidth = 51;
            this.Dg_StudentRecord.Size = new System.Drawing.Size(864, 330);
            this.Dg_StudentRecord.TabIndex = 0;
            // 
            // Btn_LoadRecords
            // 
            this.Btn_LoadRecords.Location = new System.Drawing.Point(181, 17);
            this.Btn_LoadRecords.Name = "Btn_LoadRecords";
            this.Btn_LoadRecords.Size = new System.Drawing.Size(100, 23);
            this.Btn_LoadRecords.TabIndex = 2;
            this.Btn_LoadRecords.Text = "Load Records";
            this.Btn_LoadRecords.UseVisualStyleBackColor = true;
            this.Btn_LoadRecords.Click += new System.EventHandler(this.Btn_LoadRecords_Click);
            // 
            // Lbl_StudentName
            // 
            this.Lbl_StudentName.AutoSize = true;
            this.Lbl_StudentName.Location = new System.Drawing.Point(12, 22);
            this.Lbl_StudentName.Name = "Lbl_StudentName";
            this.Lbl_StudentName.Size = new System.Drawing.Size(0, 13);
            this.Lbl_StudentName.TabIndex = 3;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Logout.Location = new System.Drawing.Point(287, 17);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(100, 23);
            this.Btn_Logout.TabIndex = 4;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.UseVisualStyleBackColor = true;
            this.Btn_Logout.Click += new System.EventHandler(this.Btn_Logout_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Print.Location = new System.Drawing.Point(776, 17);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(100, 23);
            this.Btn_Print.TabIndex = 5;
            this.Btn_Print.Text = "Print Records";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Tb_UpdatePassword
            // 
            this.Tb_UpdatePassword.Location = new System.Drawing.Point(116, 387);
            this.Tb_UpdatePassword.Name = "Tb_UpdatePassword";
            this.Tb_UpdatePassword.PasswordChar = '*';
            this.Tb_UpdatePassword.Size = new System.Drawing.Size(207, 20);
            this.Tb_UpdatePassword.TabIndex = 6;
            // 
            // Tb_ConfirmPassword
            // 
            this.Tb_ConfirmPassword.Location = new System.Drawing.Point(116, 413);
            this.Tb_ConfirmPassword.Name = "Tb_ConfirmPassword";
            this.Tb_ConfirmPassword.PasswordChar = '*';
            this.Tb_ConfirmPassword.Size = new System.Drawing.Size(207, 20);
            this.Tb_ConfirmPassword.TabIndex = 7;
            // 
            // Btn_UpdatePassword
            // 
            this.Btn_UpdatePassword.Location = new System.Drawing.Point(341, 410);
            this.Btn_UpdatePassword.Name = "Btn_UpdatePassword";
            this.Btn_UpdatePassword.Size = new System.Drawing.Size(100, 23);
            this.Btn_UpdatePassword.TabIndex = 8;
            this.Btn_UpdatePassword.Text = "Update Password";
            this.Btn_UpdatePassword.UseVisualStyleBackColor = true;
            this.Btn_UpdatePassword.Click += new System.EventHandler(this.Btn_UpdatePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirm Password:";
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_UpdatePassword);
            this.Controls.Add(this.Tb_ConfirmPassword);
            this.Controls.Add(this.Tb_UpdatePassword);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.Lbl_StudentName);
            this.Controls.Add(this.Btn_LoadRecords);
            this.Controls.Add(this.Dg_StudentRecord);
            this.Name = "StudentView";
            this.Text = "StudentView";
            ((System.ComponentModel.ISupportInitialize)(this.Dg_StudentRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_StudentRecord;
        private System.Windows.Forms.Button Btn_LoadRecords;
        private System.Windows.Forms.Label Lbl_StudentName;
        private System.Windows.Forms.Button Btn_Logout;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.TextBox Tb_UpdatePassword;
        private System.Windows.Forms.TextBox Tb_ConfirmPassword;
        private System.Windows.Forms.Button Btn_UpdatePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}