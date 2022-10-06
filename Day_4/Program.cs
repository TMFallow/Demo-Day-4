// See https://aka.ms/new-console-template for more information
using Day_4;

namespace Day_4
{ 
    class program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { 
                    ID = 1, 
                    FirstName = "ABC", 
                    LastName = "CBD", 
                    Class = "10DHTH", Course =  new Course() {IdCourse = 1, CourseName = "Machin Learning", Detail = "abc" }
                };

                ctx.Students.Add(student);

                ctx.SaveChanges();
            }
        }
    }
}


