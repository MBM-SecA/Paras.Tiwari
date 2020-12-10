
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class EmployeeController: Controller
{
    private readonly EMSContext db;

    public EmployeeController(EMSContext _db)
   {
        db = _db;
     ViewData["DepartmentOptions"]= db.Departments.ToList();
    }
     
    public ActionResult Index()
    {
        
        var employees = db.People.Include(x=>x.Department).ToList();
        return View(employees);
    }
    public ActionResult Detail([FromQuery]int id)
    {  
       var  employee = db.People.Find(id);
       return View(employee);
        
    }

[HttpGet]
    public ActionResult Add()
    {
        ViewData["DepartmentOptions"]= db.Departments.ToList();
        return View();
    }
[HttpPost]
    public ActionResult<string> Add([FromForm]Person person)
    {
        db.People.Add(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    public ActionResult Edit([FromQuery]int id)
    {  
        ViewData["DepartmentOptions"]= db.Departments.ToList();
       var  employee = db.People.Find(id);
       return View(employee);
        
    }
    [HttpPost]
public ActionResult Edit([FromForm]Person person)
    {  
       db.People.Attach(person);
       db.People.Update(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));

    
        
    }
[HttpGet]
 public ActionResult Delete([FromQuery]int id)
    {  
       var  employee = db.People.Find(id);
       return View(employee);
        
    }
    [HttpPost]
public ActionResult Delete([FromForm]Person person)
    {  
       db.People.Attach(person);
       db.People.Remove(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));

    
        
    }

}

