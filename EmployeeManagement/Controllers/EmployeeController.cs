using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController: Controller
{
    public ActionResult Index()
    {
   
        //object initializer syntax
        Person emp1 = new Person(){ FirstName = "Bishnu",LastName ="Rawal",Address ="Kathmandu",Salary =2000.0 };
        Person emp2 = new Person(){ FirstName = "Bishnu",LastName ="Rawal",Address ="Kathmandu",Salary =2000.0 };
        Person emp3 = new Person(){ FirstName = "Bishnu",LastName ="Rawal",Address ="Kathmandu",Salary =2000.0 };
        Person emp4 = new Person(){ FirstName = "Bishnu",LastName ="Rawal",Address ="Kathmandu",Salary =2000.0 };
        Person emp5 = new Person(){ FirstName = "Bishnu",LastName ="Rawal",Address ="Kathmandu",Salary =2000.0 };
        Person emp6 = new Person(){ FirstName = "Bishnu",LastName ="Rawal",Address ="Kathmandu",Salary =2000.0 };
        List<Person> employees = new List<Person>(){emp1,emp2,emp3,emp4,emp5,emp6};
        return View(employees);
    }

}

