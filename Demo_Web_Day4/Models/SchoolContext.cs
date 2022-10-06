using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo_Web_Day4.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade>Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Map(m =>
            {
                m.Properties(p => new { p.StudentID, p.StudentName, p.DateofBirth });
                m.ToTable("StudentInfo");
            });
        }
    }
}