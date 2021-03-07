using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;
[Route("students")]
[ApiController]
public class StudentController:ControllerBase
{
    [HttpGet]
    [Route("all")]
   public ActionResult GetAllStudents()

   {
       string[] students = {"Ram","Shyam","Hari","Geeta"}; //demo string array

    if (students== null)
    {
        return NotFound();
    }
           return Ok(students);
   }

   [HttpGet]
   [Route("{name}")]
   public ActionResult GetStudentByName(string name)
   {
       string[] students = {"Ram","Shyam","Hari","Geeta"}; //demo string array
        var result = students.Where(x=> x == name).FirstOrDefault();
    if (result==null)
        return BadRequest();
    
    return Ok(result);
   }

   [HttpPost]
   [Route("Add")]
    public ActionResult CreateStudent(Student student)
   {
       if(student==null)
       return BadRequest();
       
       return Created("",student);

   }
   [HttpPut]
   [Route("Update")]
    public ActionResult UpdateStudent(Student student)
   {
       if(student==null)
       return BadRequest();
       
       return Created("Updated student",student);

   }

   [HttpDelete]
   [Route("Delete")]
    public ActionResult RemoveStudent(Student student)
   {
       if(student==null)
       return  BadRequest();
    var result=$"Removed {student.Name}";

    
       return Ok(result);

   }

   }

   