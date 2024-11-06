using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarly.Model
{
    public class AdminModel
    {
        public string AdminId { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


    //    public void AddStudent(StudentModel student)
    //    {
    //        Console.WriteLine($"Student {student.FirstName} {student.LastName} has been added.");
    //    }

    //    public void UpdateStudent(StudentModel student)
    //    {
    //        Console.WriteLine($"Student {student.StudentId} has been updated.");
    //    }

    //    public void DeleteStudent(int studentId)
    //    {
    //        Console.WriteLine($"Student with ID {studentId} has been deleted.");
    //    }

    //    public void AddCourse(CourseModel course)
    //    {
    //        Console.WriteLine($"Course {course.CourseName} has been added.");
    //    }

    //    public void UpdateCourse(CourseModel course)
    //    {
    //        Console.WriteLine($"Course {course.CourseId} has been updated.");
    //    }

    //    public void DeleteCourse(int courseId)
    //    {
    //        Console.WriteLine($"Course with ID {courseId} has been deleted.");
    //    }

    //    public void LogRegistrarAction(string action)
    //    {
    //        Console.WriteLine($"{DateTime.Now}: Registrar {FirstName} {LastName} performed action: {action}");
    //    }
    }
}
