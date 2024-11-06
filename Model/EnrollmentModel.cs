using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarly.Model
{
    public class EnrollmentModel
    {
        public string EnrollmentId { get; set; }
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Grade { get; set; }
    }
}

