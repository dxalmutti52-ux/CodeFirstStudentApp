using System.Data.Entity;
using CodeFirstStudentApp.Models;

namespace CodeFirstStudentApp
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDBConnection")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
