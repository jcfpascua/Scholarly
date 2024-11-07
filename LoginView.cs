using Scholarly.Model;
using Scholarly.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scholarly.View
{
    public partial class LoginView : Form
    {
        //private TextBox Tb_StudentUsername;
        //private TextBox Tb_StudentPassword;
        //private TextBox Tb_AdminUsername;
        //private TextBox Tb_AdminPassword;
        //private Button Btn_StudentLogin;
        private StudentViewModel studentViewModel;
        private AdminViewModel adminViewModel;
        private static LoginView instance;

        public static LoginView Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new LoginView();
                }
                return instance;
            }
        }
        public LoginView()
        {
            InitializeComponent();
            studentViewModel = new StudentViewModel();
            adminViewModel = new AdminViewModel();
        }

        private void Btn_StudentLogin_Click(object sender, EventArgs e)
        {
            string studentUsername = Tb_StudentUsername.Text;
            string studentPassword = Tb_StudentPassword.Text;

            if (studentViewModel.AuthenticateStudent(studentUsername, studentPassword))
            {
                StudentView studentView = new StudentView();
                studentView.SetCurrentStudent(studentViewModel.CurrentStudent);
                studentView.UpdateStudentName();
                studentView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Btn_AdminLogin_Click(object sender, EventArgs e)
        {
            string adminUsername = Tb_AdminUsername.Text;
            string adminPassword = Tb_AdminPassword.Text;

            if (adminViewModel.AuthenticateAdmin(adminUsername, adminPassword))
            {
                AdminView adminView = new AdminView(adminViewModel.CurrentAdmin.FirstName, adminViewModel.CurrentAdmin.LastName);
                adminView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
