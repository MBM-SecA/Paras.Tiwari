using System.Linq;
using EMS.Api.Data;
using EMS.Api.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController: ControllerBase
    {
    
    public readonly EMSApiContext db;
        public EmployeesController (EMSApiContext db){
            this.db =db;
    }
    [HttpGet]

    public Employee[] Get(){
        var employees = db.Employees.ToArray();
        return employees;
    }

[HttpPost]
    public int Create(Employee employee)
    {
        db.Employees.Add(employee);
        int x = db.SaveChanges();
        return x;
    }

    }


    
   
}