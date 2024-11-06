using Scholarly.Model;
using Scholarly.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scholarly.View
{
    public partial class AdminView : Form
    {
        private StudentModel studentModel;
        private AdminViewModel adminViewModel;
        public AdminView()
        {
            InitializeComponent();
            studentModel = new StudentModel();
            adminViewModel = new AdminViewModel();
        }
        public AdminView(string adminFirstName, string adminLastName)
        {
            InitializeComponent();
            studentModel = new StudentModel();
            adminViewModel = new AdminViewModel();
            Lb_AdminName.Text += $"{adminFirstName} {adminLastName}";
        }

        private void AdminView_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            LoginView.Instance.Show();
            this.Dispose();
        }

        private void Btn_AddStudent_Click(object sender, EventArgs e)
        {
            string firstName = Tb_FirstName.Text;
            string lastName = Tb_LastName.Text;
            string program = Tb_Program.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(program))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            StudentModel newStudent = new StudentModel
            {
                FirstName = firstName,
                LastName = lastName,
                Program = program
            };

            adminViewModel.AddStudent(newStudent);
            MessageBox.Show("Student added successfully.");
            Tb_FirstName.Clear();
            Tb_LastName.Clear();
            Tb_Program.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_DisplayStudents_Click(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            List<StudentModel> students = adminViewModel.GetAllStudents();
            Dg_StudentData.DataSource = students;
            Dg_StudentData.Refresh();
        }

        private void Btn_DisplayAdmin_Click(object sender, EventArgs e)
        {
            LoadAdminData();
        }

        private void LoadAdminData()
        {
            List<AdminModel> admins = adminViewModel.GetAllAdmins();
            Dg_AdminData.DataSource = admins;
            Dg_AdminData.Refresh();
        }

        private void Btn_DisplayCourse_Click(object sender, EventArgs e)
        {
            LoadCourseData();
        }

        private void LoadCourseData()
        {
            List<CourseModel> courses = adminViewModel.GetAllCourses();
            Dg_CourseData.DataSource = courses;
            Dg_CourseData.Refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string search = Tb_Search.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                SearchStudents(search);
            }
            else
            {
                MessageBox.Show("Student does not exist.");
            }

            Tb_Search.Clear();
        }
        private void SearchStudents(string searchQuery)
        {
            List<StudentModel> students = adminViewModel.SearchStudents(searchQuery); 
            Dg_StudentData.DataSource = students; 
            Dg_StudentData.Refresh(); 
        }

        private void Btn_SearchAdmin_Click(object sender, EventArgs e)
        {
            string search = Tb_SearchAdmin.Text.Trim();

            if (!string.IsNullOrEmpty (search))
            {
                SearchAdmins(search);
            }
            else
            {
                MessageBox.Show("Admin does not exist.");
            }

            Tb_SearchAdmin.Clear();
        }

        private void SearchAdmins(string searchQuery)
        {
            List<AdminModel> admins = adminViewModel.SearchAdmins(searchQuery);
            Dg_AdminData.DataSource = admins;
            Dg_AdminData.Refresh();
        }

        private void Btn_RemoveStudent_Click(object sender, EventArgs e)
        {
                if (Dg_StudentData.SelectedRows.Count > 0)
                {
                    string studentId = Dg_StudentData.SelectedRows[0].Cells["StudentId"].Value.ToString();
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this student?",
                                                     "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        bool isDeleted = adminViewModel.DeleteStudent(studentId);
                        if (isDeleted)
                        {
                            MessageBox.Show("Student deleted successfully.");
                            Dg_StudentData.Refresh();
                            LoadStudentData(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the student.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.");
                }
        }


        private void Dg_StudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_UpdateStudent_Click(object sender, EventArgs e)
        {
            if (Dg_StudentData.SelectedRows.Count > 0)
            {
                string studentId = Dg_StudentData.SelectedRows[0].Cells["StudentId"].Value.ToString();
                string firstName = Tb_UpdateFirstName.Text;
                string lastName = Tb_UpdateLastName.Text;
                string program = Tb_UpdateProgram.Text;

                bool isUpdated = adminViewModel.UpdateStudent(studentId, firstName, lastName, program);

                if (isUpdated)
                {
                    MessageBox.Show("Student updated successfully.");
                    Dg_StudentData.Refresh();
                    LoadStudentData();  
                }
                else
                {
                    MessageBox.Show("Failed to update student.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        private void Dg_StudentData_SelectionChanged(object sender, EventArgs e)
        {
            if (Dg_StudentData.SelectedRows.Count > 0)
            {
                Tb_UpdateFirstName.Text = Dg_StudentData.SelectedRows[0].Cells["FirstName"].Value?.ToString();
                Tb_UpdateLastName.Text = Dg_StudentData.SelectedRows[0].Cells["LastName"].Value?.ToString();
                Tb_UpdateProgram.Text = Dg_StudentData.SelectedRows[0].Cells["Program"].Value?.ToString();
            }
        }

        private void Tab_Courses_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AddAdmin_Click(object sender, EventArgs e)
        {
            string adminFirstName = Tb_AdminFirstName.Text;
            string adminLastName = Tb_AdminLastName.Text;

            if (string.IsNullOrEmpty(adminFirstName) || string.IsNullOrEmpty(adminLastName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            AdminModel newAdmin = new AdminModel
            {
                FirstName = adminFirstName,
                LastName = adminLastName,
            };

            adminViewModel.AddAdmin(newAdmin);
            MessageBox.Show("Admin added successfully.");
            Tb_FirstName.Clear();
            Tb_LastName.Clear();
        }

        private void Btn_RemoveAdmin_Click(object sender, EventArgs e)
        {
            if (Dg_AdminData.SelectedRows.Count > 0)
            {
                string adminId = Dg_AdminData.SelectedRows[0].Cells["AdminId"].Value.ToString();
                var confirmResult = MessageBox.Show("Are you sure you want to delete this admin?",
                                                     "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = adminViewModel.DeleteAdmin(adminId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Admin deleted successfully.");
                        Dg_AdminData.Refresh();
                        LoadStudentData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the student.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void Btn_UpdateAdmin_Click(object sender, EventArgs e)
        {
            if (Dg_AdminData.SelectedRows.Count > 0)
            {
                string adminId = Dg_AdminData.SelectedRows[0].Cells["StudentId"].Value.ToString();
                string firstName = Tb_UpdateAdminFirstName.Text;
                string lastName = Tb_UpdateAdminLastName.Text;

                bool isUpdated = adminViewModel.UpdateAdmin(adminId, firstName, lastName);

                if (isUpdated)
                {
                    MessageBox.Show("Admin updated successfully.");
                    Dg_StudentData.Refresh();
                    LoadAdminData();
                }
                else
                {
                    MessageBox.Show("Failed to update admin.");
                }
            }
            else
            {
                MessageBox.Show("Please select a admin to update.");
            }
        }

        private void Btn_RemoveCourse_Click(object sender, EventArgs e)
        {
            if (Dg_CourseData.SelectedRows.Count > 0)
            {
                string courseId = Dg_CourseData.SelectedRows[0].Cells["CourseId"].Value.ToString();
                var confirmResult = MessageBox.Show("Are you sure you want to delete this course?",
                                                     "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = adminViewModel.DeleteCourse(courseId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Course deleted successfully.");
                        Dg_CourseData.Refresh();
                        LoadCourseData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the course.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

        private void Btn_AddCourse_Click(object sender, EventArgs e)
        {
            string courseName = Tb_CourseName.Text;
            string courseCode = Tb_CourseCode.Text;
            int credits = Convert.ToInt32(Tb_Credits.Text);
            string description = Tb_Description.Text;

            if (string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(courseCode) ||
                string.IsNullOrEmpty(credits.ToString()) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            CourseModel newCourse = new CourseModel
            {
                CourseName = courseName,
                CourseCode = courseCode,
                Credits = credits,
                Description = description
            };

            adminViewModel.AddCourse(newCourse);
            MessageBox.Show("Course added successfully.");
            Tb_CourseName.Clear();
            Tb_CourseCode.Clear();
            Tb_Credits.Clear();
            Tb_Description.Clear();
        }

        private void Btn_UpdateCourse_Click(object sender, EventArgs e)
        {
            if (Dg_CourseData.SelectedRows.Count > 0)
            {
                string courseId = Dg_CourseData.SelectedRows[0].Cells["StudentId"].Value.ToString();
                string courseName = Tb_CourseName.Text;
                string courseCode = Tb_CourseCode.Text;
                int credits = Convert.ToInt32(Tb_Credits.Text);
                string description = Tb_Description.Text;

                bool isUpdated = adminViewModel.UpdateCourse(courseId, courseName, courseCode, credits, description);

                if (isUpdated)
                {
                    MessageBox.Show("Admin updated successfully.");
                    Dg_CourseData.Refresh();
                    LoadCourseData();
                }
                else
                {
                    MessageBox.Show("Failed to update admin.");
                }
            }
            else
            {
                MessageBox.Show("Please select a admin to update.");
            }
        }

        private void Dg_Students_SelectionChanged(object sender, EventArgs e)
        {
            if (Dg_StudentEnroll.SelectedRows.Count > 0)
            {
                string selectedStudentId = Dg_StudentEnroll.SelectedRows[0].Cells["StudentId"].Value.ToString();
            }
        }

        private void Dg_Courses_SelectionChanged(object sender, EventArgs e)
        {
            if (Dg_CourseEnroll.SelectedRows.Count > 0)
            {
                string selectedCourseId = Dg_CourseEnroll.SelectedRows[0].Cells["CourseId"].Value.ToString();
            }
        }

        private void Btn_EnrollStudent_Click(object sender, EventArgs e)
        {
            string selectedStudentId = Dg_StudentEnroll.SelectedRows[0].Cells["StudentId"].Value.ToString();
            string selectedCourseId = Dg_CourseEnroll.SelectedRows[0].Cells["CourseId"].Value.ToString();

            if (string.IsNullOrEmpty(selectedStudentId) || string.IsNullOrEmpty(selectedCourseId))
            {
                MessageBox.Show("Please select both a student and a course.");
                return;
            }

            bool success = adminViewModel.EnrollStudentInCourse(selectedStudentId, selectedCourseId);
            if (success)
            {
                MessageBox.Show("Enrollment successful.");
            }
            else
            {
                MessageBox.Show("Enrollment failed.");
            }
        }

        private void Btn_AddCourse_Click_1(object sender, EventArgs e)
        {
            string courseName = Tb_CourseName.Text;
            string courseCode = Tb_CourseCode.Text;
            int credits = Convert.ToInt32(Tb_Credits.Text);
            string description = Tb_Description.Text;

            if (string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(courseCode) ||
                string.IsNullOrEmpty(credits.ToString()) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            CourseModel newCourse = new CourseModel
            {
                CourseName = courseName,
                CourseCode = courseCode,
                Credits = credits,
                Description = description
            };

            adminViewModel.AddCourse(newCourse);
            MessageBox.Show("Course added successfully.");
            Tb_CourseName.Clear();
            Tb_CourseCode.Clear();
            Tb_Credits.Clear();
            Tb_Description.Clear();
        }

        private void Btn_SearchCourse_Click(object sender, EventArgs e)
        {
            string search = Tb_SearchCourse.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                SearchCourses(search);
            }
            else
            {
                MessageBox.Show("Course does not exist.");
            }

            Tb_SearchCourse.Clear();
        }

        private void SearchCourses(string searchQuery)
        {
            List<CourseModel> students = adminViewModel.SearchCourses(searchQuery);
            Dg_CourseData.DataSource = students;
            Dg_CourseData.Refresh();
        }

        //private void Dg_Students_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (Dg_StudentEnroll.SelectedRows.Count > 0)
        //    {
        //        string selectedStudentId = Dg_StudentEnroll.SelectedRows[0].Cells["StudentId"].Value.ToString();
        //    }
        //}

        //// Event handler to capture selected CourseId
        //private void Dg_Courses_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (Dg_CourseEnroll.SelectedRows.Count > 0)
        //    {
        //        string selectedCourseId = Dg_CourseEnroll.SelectedRows[0].Cells["CourseId"].Value.ToString();
        //    }
        //}

        private void Btn_EnrollStudent_Click_1(object sender, EventArgs e)
        {
            string studentId = Tb_StudentToEnroll.Text.Trim();
            string courseId = Tb_CourseToEnroll.Text.Trim();
            string grade = Tb_Grade.Text.Trim();

            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(courseId))
            {
                MessageBox.Show("Please enter both Student ID and Course ID.");
                return;
            }

            EnrollmentModel newEnrollment = new EnrollmentModel
            {
                StudentId = studentId,
                CourseId = courseId,
                Grade = grade,  
            };

            adminViewModel.AddEnrollment(newEnrollment);

            MessageBox.Show("Student enrolled successfully!");

        }

        //private void Btn_SearchStudentToEnroll_Click(object sender, EventArgs e)
        //{
        //    string search = Tb_SearchStudentToEnroll.Text.Trim();

        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        SearchStudents(search);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Course does not exist.");
        //    }

        //    Tb_SearchStudentToEnroll.Clear();
        //}

        private void SearchStudentToEnroll(string searchQuery)
        {
            List<StudentModel> students = adminViewModel.SearchStudents(searchQuery);
            Dg_StudentEnroll.DataSource = students;
            Dg_StudentEnroll.Refresh();
        }

        private void Btn_ShowStudentData_Click(object sender, EventArgs e)
        {
            LoadStudentToEnrollData();
        }

        private void LoadStudentToEnrollData()
        {
            List<StudentModel> students = adminViewModel.GetAllStudents();
            Dg_StudentEnroll.DataSource = students;
            Dg_StudentEnroll.Refresh();
        }

        private void Btn_SearchCourseToEnroll_Click(object sender, EventArgs e)
        {
            string search = Tb_SearchCourseToEnroll.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                SearchCoursesToEnroll(search);
            }
            else
            {
                MessageBox.Show("Course does not exist.");
            }

            Tb_SearchCourseToEnroll.Clear();
        }

        private void SearchCoursesToEnroll(string searchQuery)
        {
            List<CourseModel> students = adminViewModel.SearchCourses(searchQuery);
            Dg_CourseEnroll.DataSource = students;
            Dg_CourseEnroll.Refresh();
        }

        private void Btn_ShowCoursesEnrolled_Click(object sender, EventArgs e)
        {
            LoadCourseToEnrollData();
        }
        private void LoadCourseToEnrollData()
        {
            List<CourseModel> courses = adminViewModel.GetAllCourses();
            Dg_CourseEnroll.DataSource = courses;
            Dg_CourseEnroll.Refresh();
        }

        private void Btn_SearchStudentToEnroll_Click(object sender, EventArgs e)
        {
            string search = Tb_SearchStudentToEnroll.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                SearchStudentToEnroll(search);
            }
            else
            {
                MessageBox.Show("Course does not exist.");
            }

            Tb_SearchStudentToEnroll.Clear();
        }
    }
}
