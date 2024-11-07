using Scholarly.Model;
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
    public partial class StudentView : Form
    {
        private StudentViewModel studentViewModel;
       
        public StudentView()
        {
            InitializeComponent();
            studentViewModel = new StudentViewModel();
            SetStudentNameLabel();

            Btn_Logout.Click += Btn_Logout_Click;
        }

        public static implicit operator StudentView(StudentViewModel v)
        {
            throw new NotImplementedException();
        }
        private void SetStudentNameLabel()
        {
            Lbl_StudentName.Text = $"Student Name: {studentViewModel.GetStudentFullName()}";
        }
        private void Btn_LoadRecords_Click(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void LoadStudentRecords()
        {
            var coursesWithDates = studentViewModel.GetCoursesForStudent();
            Dg_StudentRecord.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("Course ID");
            dt.Columns.Add("Course Name");
            dt.Columns.Add("Course Code");
            dt.Columns.Add("Credits");
            dt.Columns.Add("Description");
            dt.Columns.Add("Enrollment Date");
            dt.Columns.Add("Grade");

            foreach (var item in coursesWithDates)
            {
                dt.Rows.Add(item.Course.CourseId,
                             item.Course.CourseName,
                             item.Course.CourseCode,
                             item.Course.Credits,
                             item.Course.Description,
                             item.EnrollmentDate.ToString("MMMM dd, yyyy"),
                             item.Grade); 
            }

            Dg_StudentRecord.DataSource = dt;
            Dg_StudentRecord.AllowUserToAddRows = false;
            Dg_StudentRecord.Refresh();
        }

        public void SetCurrentStudent(StudentModel student)
        {
            studentViewModel.CurrentStudent = student;
        }
        public void UpdateStudentName()
        {
            Lbl_StudentName.Text = $"Student Name: {studentViewModel.GetStudentFullName()}";
        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            LoginView.Instance.Show();
            this.Dispose();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            string filePath = $@"C:\Users\jakir\OneDrive\Desktop\OOP\Excel\{studentViewModel.CurrentStudent.LastName}_Records.xlsx";
            studentViewModel.ExportToExcelFile(Dg_StudentRecord, filePath);
            MessageBox.Show("Data exported successfully.");
        }

        private void Btn_UpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = Tb_UpdatePassword.Text;
            string confirmPassword = Tb_ConfirmPassword.Text;  

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Incomplete fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            bool match = studentViewModel.UpdatePassword(newPassword);

            if (match)
            {
                MessageBox.Show("Password updated successfully.");
                Tb_UpdatePassword.Clear();
                Tb_ConfirmPassword.Clear();
            }
            else
            {
                MessageBox.Show("Error has occured.");
            }
        }
    }
}
