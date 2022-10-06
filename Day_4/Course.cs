using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Course
    {
        [Key]
        public int IdCourse { get; set; }
        public string CourseName { get; set; }
        public string Detail { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
