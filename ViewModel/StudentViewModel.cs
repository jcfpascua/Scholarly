using Scholarly.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


public class StudentViewModel
{
    //private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=scholarly_student;Integrated Security=True;";
    private string connectionString;
    public StudentModel CurrentStudent { get; set; }

    public StudentViewModel()
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

    public bool AuthenticateStudent(string username, string password)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Students WHERE Username = @Username AND Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                CurrentStudent = new StudentModel
                {
                    StudentId = reader["StudentId"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),
                    EnrollmentDate = DateTime.Parse(reader["EnrollmentDate"].ToString()),
                    Program = reader["Program"].ToString()
                };
                return true;
            }
            return false;
        }
    }

    public List<(CourseModel Course, DateTime EnrollmentDate)> GetCoursesForStudent()
    {
        if (CurrentStudent == null)
            return new List<(CourseModel, DateTime)>();

        List<(CourseModel, DateTime)> coursesWithDates = new List<(CourseModel, DateTime)>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT c.CourseId, c.CourseName, c.CourseCode, c.Credits, c.Description, e.EnrollmentDate " +
                           "FROM Courses c " +
                           "JOIN Enrollments e ON c.CourseId = e.CourseId " +
                           "WHERE e.StudentId = @StudentId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentId", CurrentStudent.StudentId);
            Console.WriteLine($"Executing query for StudentId: {CurrentStudent.StudentId}");
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var course = new CourseModel
                {
                    CourseId = reader["CourseId"].ToString(),
                    CourseName = reader["CourseName"].ToString(),
                    CourseCode = reader["CourseCode"].ToString(),
                    Credits = int.Parse(reader["Credits"].ToString()),
                    Description = reader["Description"].ToString(),
                };

                var enrollmentDate = Convert.ToDateTime(reader["EnrollmentDate"]);
                coursesWithDates.Add((course, enrollmentDate));
            }
        }
        return coursesWithDates;
    }

    public string GetStudentFullName()
    {
        if (CurrentStudent != null)
        {
            return $"{CurrentStudent.FirstName} {CurrentStudent.LastName}";
        }
        return string.Empty;
    }

    public void ExportToExcelFile(DataGridView dataGridView, string filePath)
    {
        var excelApp = new Excel.Application();
        excelApp.Workbooks.Add();
        Excel._Worksheet worksheet = excelApp.ActiveSheet;

        for (int i = 0; i < dataGridView.Columns.Count; i++)
        {
            worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;

            for (int j = 0; j < dataGridView.Rows.Count; j++)
            {
                worksheet.Cells[j + 2, i + 1] = dataGridView.Rows[j].Cells[i].Value?.ToString() ?? "";
            }
        }

        worksheet.SaveAs(filePath);
        excelApp.Quit();
    }

    public bool UpdatePassword(string newPassword)
    {
        if (CurrentStudent == null)
        {
            return false;
        }

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Students SET Password = @Password WHERE StudentId = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@StudentId", CurrentStudent.StudentId);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            return false;
        }
    }

}
