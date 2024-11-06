using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarly.Model
{
    public class CourseModel
    {
        public string CourseId { get; set; }  
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
    }

}
