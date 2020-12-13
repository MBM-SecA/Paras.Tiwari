
using Microsoft.EntityFrameworkCore;

public class EMContext: DbContext
{
    public EMContext(DbContextOptions<EMContext> options): base(options)
    {
        
    }
    public DbSet<Employee> Employees {get;set;}
    public DbSet<Department> Departments {get;set;}
    
    
}