using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=dbOBS;integrated security=true;");
        }

        public DbSet<Student> Students{ get; set; }
        public DbSet<Lecturer> Lecturers{ get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Exam> Exams{ get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
