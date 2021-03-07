using Microsoft.EntityFrameworkCore;
using StudentsApi.Models;
namespace StudentsApi.Data
{
    class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }


    }
    
}