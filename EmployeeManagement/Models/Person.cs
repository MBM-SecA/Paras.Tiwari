
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } 
    public double Salary { get; set; }
    [Required]
    public Department Department { get; set; }
    public int DepartmentId { get; set; }
  
}