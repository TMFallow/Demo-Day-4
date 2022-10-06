using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Web_Day4.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public decimal Height { get; set; }  
        public float weight { get; set; }

        public Grade Grade { get; set; }
    }
}