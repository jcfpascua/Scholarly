using Scholarly.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Scholarly.ViewModel
{
    public class AdminViewModel
    {
        private string connectionString;
        public AdminModel CurrentAdmin { get; set; }
        public AdminViewModel()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ScholarlyDB"].ConnectionString;
        }
        public void ConnectToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        //public void AddStudent(StudentModel student)
        //{
        //    // Call the data access layer or repository to add the student to the database
        //    Console.WriteLine($"Student {student.FirstName} {student.LastName} has been added.");
        //    LogRegistrarAction("Added student");
        //}

        //public void UpdateStudent(StudentModel student)
        //{
        //    // Call the data access layer or repository to update the student in the database
        //    Console.WriteLine($"Student {student.StudentId} has been updated.");
        //    LogRegistrarAction("Updated student");
        //}

        //public void DeleteStudent(string studentId)
        //{
        //    // Call the data access layer or repository to delete the student from the database
        //    Console.WriteLine($"Student with ID {studentId} has been deleted.");
        //    LogRegistrarAction("Deleted student");
        //}

        //public void AddCourse(CourseModel course)
        //{
        //    // Call the data access layer or repository to add the course to the database
        //    Console.WriteLine($"Course {course.CourseName} has been added.");
        //    LogRegistrarAction("Added course");
        //}

        //public void UpdateCourse(CourseModel course)
        //{
        //    // Call the data access layer or repository to update the course in the database
        //    Console.WriteLine($"Course {course.CourseId} has been updated.");
        //    LogRegistrarAction("Updated course");
        //}

        //public void DeleteCourse(string courseId)
        //{
        //    // Call the data access layer or repository to delete the course from the database
        //    Console.WriteLine($"Course with ID {courseId} has been deleted.");
        //    LogRegistrarAction("Deleted course");
        //}

        //private void LogRegistrarAction(string action)
        //{
        //    Console.WriteLine($"{DateTime.Now}: Registrar performed action: {action}");
        //}

        public bool AuthenticateAdmin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Admins WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue ("password", password);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CurrentAdmin = new AdminModel
                    {
                        AdminId = reader["AdminId"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                    };
                    return true;
                }
                return false;
            }
        }

        public void AddAdmin(AdminModel admin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string idQuery = "SELECT MAX(CAST(SUBSTRING(AdminId, 2, LEN(AdminId) - 1) AS INT)) FROM Admins";
                SqlCommand idCommand = new SqlCommand(idQuery, connection);
                object result = idCommand.ExecuteScalar();

                int newAdminId = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;

                string formattedId = $"A{newAdminId:D3}";

                string email = $"{admin.FirstName}.{admin.LastName}@mcm.edu.ph".ToLower();
                string username = $"{admin.FirstName}{admin.LastName}".ToLower();

                admin.AdminId = formattedId;
                admin.Email = email;
                admin.Username = username;
                admin.Password = "password123";

                string query = "INSERT INTO Admins (AdminId, FirstName, LastName, Email, Username, Password) " +
                               "VALUES (@AdminId, @FirstName, @LastName, @Email, @Username, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminId", admin.AdminId);
                    command.Parameters.AddWithValue("@FirstName", admin.FirstName);
                    command.Parameters.AddWithValue("@LastName", admin.LastName);
                    command.Parameters.AddWithValue("@Email", admin.Email);
                    command.Parameters.AddWithValue("@Username", admin.Username);
                    command.Parameters.AddWithValue("@Password", admin.Password);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddStudent(StudentModel student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string idQuery = "SELECT MAX(CAST(SUBSTRING(StudentId, 2, LEN(StudentId) - 1) AS INT)) FROM Students";
                SqlCommand idCommand = new SqlCommand(idQuery, connection);
                object result = idCommand.ExecuteScalar();

                int newStudentId = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;

                string formattedId = $"S{newStudentId:D3}";

                string email = $"{student.FirstName}.{student.LastName}@mcm.edu.ph".ToLower();
                string username = $"{student.FirstName}{student.LastName}".ToLower();

                student.StudentId = formattedId; 
                student.Email = email;
                student.Username = username;
                student.Password = "password123";
                student.EnrollmentDate = DateTime.Now;

                string query = "INSERT INTO Students (StudentId, FirstName, LastName, Email, Username, Password, EnrollmentDate, Program) " +
                               "VALUES (@StudentId, @FirstName, @LastName, @Email, @Username, @Password, @EnrollmentDate, @Program)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", student.StudentId);
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@Username", student.Username);
                    command.Parameters.AddWithValue("@Password", student.Password);
                    command.Parameters.AddWithValue("@EnrollmentDate", student.EnrollmentDate);
                    command.Parameters.AddWithValue("@Program", student.Program);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddCourse(CourseModel course)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string idQuery = "SELECT MAX(CAST(SUBSTRING(CourseId, 2, LEN(CourseId) - 1) AS INT)) FROM Courses";
                SqlCommand idCommand = new SqlCommand(idQuery, connection);
                object result = idCommand.ExecuteScalar();

                int newCourseId = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;

                string formattedId = $"C{newCourseId:D3}";

                //string firstInitial = admin.FirstName.Length > 0 ? admin.FirstName.Substring(0, 1) : "";
                //string email = $"{firstInitial}{admin.LastName}@mcm.edu.ph".ToLower();
                //string username = $"{firstInitial}{admin.LastName}".ToLower();
                string courseName = course.CourseName;
                string courseCode = course.CourseCode;
                string credits = course.Credits.ToString();
                string description = course.Description;

                course.CourseId = formattedId;
                
                //admin.Email = email;
                //admin.Username = username;
                //admin.Password = "password123";

                string query = "INSERT INTO Courses (CourseId, CourseName, CourseCode, Credits, Description) " +
                               "VALUES (@CourseId, @CourseName, @CourseCode, @Credits, @Description)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", course.CourseId);
                    command.Parameters.AddWithValue("@CourseName", course.CourseName);
                    command.Parameters.AddWithValue("@CourseCode", course.CourseCode);
                    command.Parameters.AddWithValue("@Credits", course.Credits);
                    command.Parameters.AddWithValue("@Description", course.Description);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddEnrollment(EnrollmentModel enrollment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string idQuery = "SELECT MAX(CAST(SUBSTRING(EnrollmentId, 2, LEN(EnrollmentId) - 1) AS INT)) FROM Enrollments";
                SqlCommand idCommand = new SqlCommand(idQuery, connection);
                object result = idCommand.ExecuteScalar();

                int newEnrollmentId = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;

                string formattedId = $"E{newEnrollmentId:D3}";

                enrollment.EnrollmentId = formattedId;
                enrollment.EnrollmentDate = DateTime.Now;

                string query = "INSERT INTO Enrollments (EnrollmentId, StudentId, CourseId, EnrollmentDate, Grade) " +
                               "VALUES (@EnrollmentId, @StudentId, @CourseId, @EnrollmentDate, @Grade)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EnrollmentId", enrollment.EnrollmentId);
                    command.Parameters.AddWithValue("@StudentId", enrollment.StudentId);  // StudentId comes from the model
                    command.Parameters.AddWithValue("@CourseId", enrollment.CourseId);    // CourseId comes from the model
                    command.Parameters.AddWithValue("@EnrollmentDate", enrollment.EnrollmentDate);
                    command.Parameters.AddWithValue("@Grade", enrollment.Grade);          // Assuming Grade is being set elsewhere

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<StudentModel> GetAllStudents()
        {
            List<StudentModel> students = new List<StudentModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT StudentId, FirstName, LastName, Email, Username, EnrollmentDate, Program FROM Students"; 
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new StudentModel
                    {
                        StudentId = reader["StudentId"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        EnrollmentDate = Convert.ToDateTime(reader["EnrollmentDate"]),
                        Program = reader["Program"].ToString()
                    });
                }
            }

            return students; 
        }

        public List<AdminModel> GetAllAdmins()
        {
            List<AdminModel> admins = new List<AdminModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT AdminId, FirstName, LastName, Email, Username FROM Admins";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    admins.Add(new AdminModel
                    {
                        AdminId = reader["AdminId"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                    });
                }
            }
            return admins;
        }

        public List<CourseModel> GetAllCourses()
        {
            List<CourseModel> courses = new List<CourseModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CourseId, CourseName, CourseCode, Credits, Description FROM Courses";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    courses.Add(new CourseModel
                    {
                        CourseId = reader["CourseId"].ToString(),
                        CourseName = reader["CourseName"].ToString(),
                        CourseCode = reader["CourseCode"].ToString(),
                        Credits = Convert.ToInt32(reader["Credits"]),
                        Description = reader["Description"].ToString(),

                    });
                }
            }
            return courses;
        }

        public List<StudentModel> SearchStudents(string searchQuery)
        {
            List<StudentModel> students = new List<StudentModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT StudentId, FirstName, LastName, Email, Username, EnrollmentDate, Program " +
                               "FROM Students " +
                               "WHERE StudentId LIKE @SearchQuery OR FirstName LIKE @SearchQuery OR LastName LIKE @SearchQuery";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new StudentModel
                    {
                        StudentId = reader["StudentId"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        EnrollmentDate = Convert.ToDateTime(reader["EnrollmentDate"]),
                        Program = reader["Program"].ToString()
                    });
                }
            }

            return students;  
        }

        public List<AdminModel> SearchAdmins(string searchQuery)
        {
            List<AdminModel> admins = new List<AdminModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT AdminId, FirstName, LastName, Email, Username " +
                               "FROM Admins " +
                               "WHERE AdminId LIKE @SearchQuery OR FirstName LIKE @SearchQuery OR LastName LIKE @SearchQuery";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    admins.Add(new AdminModel
                    {
                        AdminId = reader["AdminId"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                    });
                }
            }

            return admins;
        }

        public List<CourseModel> SearchCourses(string searchQuery)
        {
            List<CourseModel> courses = new List<CourseModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CourseId, CourseName, CourseCode, Credits, Description " +
                               "FROM Courses " +
                               "WHERE CourseId LIKE @SearchQuery OR CourseName LIKE @SearchQuery OR CourseCode LIKE @SearchQuery";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    courses.Add(new CourseModel
                    {
                        CourseId = reader["CourseId"].ToString(),
                        CourseName = reader["CourseName"].ToString(),
                        CourseCode = reader["CourseCode"].ToString(),
                        Credits = Convert.ToInt32(reader["Credits"]),
                        Description = reader["Description"].ToString(),
                    });
                }
            }

            return courses;
        }

        public bool DeleteStudent(string studentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string deleteEnrollmentsQuery = "DELETE FROM Enrollments WHERE StudentId = @StudentId";
                        using (SqlCommand cmd = new SqlCommand(deleteEnrollmentsQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@StudentId", studentId);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteStudentQuery = "DELETE FROM Students WHERE StudentId = @StudentId";
                        using (SqlCommand cmd = new SqlCommand(deleteStudentQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@StudentId", studentId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public bool DeleteAdmin(string adminId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string deleteAdminQuery = "DELETE FROM Admins WHERE AdminId = @AdminId";
                        using (SqlCommand cmd = new SqlCommand(deleteAdminQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@AdminId", adminId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool DeleteCourse(string courseId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string deleteCourseQuery = "DELETE FROM Courses WHERE CourseId = @CourseId";
                        using (SqlCommand cmd = new SqlCommand(deleteCourseQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CourseId", courseId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool UpdateStudent(string studentId, string firstName, string lastName, string program)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, Program = @Program WHERE StudentId = @StudentId";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Program", program);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateAdmin(string adminId, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Admins SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE AdminId = @AdminId";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@AdminId", adminId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateCourse(string courseId, string courseName, string courseCode, int credits, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Courses SET CourseName = @CourseName, CourseCode = @CourseCode, Credits = @Credits, Description = @Description WHERE CourseId = @CourseId";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    command.Parameters.AddWithValue("@CourseName", courseName);
                    command.Parameters.AddWithValue("@CourseCode", courseCode);
                    command.Parameters.AddWithValue("@Credits", credits);
                    command.Parameters.AddWithValue("@Description", description);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public void EnrollStudentInCourse(EnrollmentModel enrollment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Enrollments (StudentId, CourseId, EnrollmentDate) VALUES (@StudentId, @CourseId, @EnrollmentDate)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", enrollment.StudentId);
                    command.Parameters.AddWithValue("@CourseId", enrollment.CourseId);
                    command.Parameters.AddWithValue("@EnrollmentDate", enrollment.EnrollmentDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool EnrollStudentInCourse(string studentId, string courseId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Enrollments (StudentId, CourseId, EnrollmentDate) " +
                               "VALUES (@StudentId, @CourseId, @EnrollmentDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    command.Parameters.AddWithValue("@EnrollmentDate", DateTime.Now);

                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}
