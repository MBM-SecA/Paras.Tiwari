using Microsoft.EntityFrameworkCore;
using EMS.Api.Data.Models;
namespace EMS.Api.Data
{
public class EMSApiContext: DbContext
{
    public EMSApiContext(DbContextOptions<EMSApiContext> options): base(options)
    {

    }
    public DbSet<Employee> Employees{get; set;}
}
}