

using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController: Controller
{
    
    public ActionResult Index()
    {
        var employees = Person.GetData();
        
        return View(employees);
    }
    public ActionResult Detail(string firstName)
    {  
       var  employees = Person.GetData();
        var employee= employees.FirstOrDefault(x=>x.FirstName==firstName);
        return View(employee);
        
    }

}

