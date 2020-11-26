using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = "First Name")]
    public string LastName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }
    public static List<Person> GetPeople()
    {
        Person p1 = new Person() { Id = 1, FirstName = "Bishnu", LastName = "Rawal", Address = "Kathmandu", Salary = 20000.0 };
        Person p2 = new Person() { Id = 2, FirstName = "Paras", LastName = "Tiwari", Address = "Pokhara", Salary = 2000.0 };
        Person p3 = new Person() { Id = 3, FirstName = "Cosmic", LastName = "Koirala", Address = "Butwal", Salary = 6000.0 };
        Person p4 = new Person() { Id = 4, FirstName = "Hari", LastName = "Sapkota", Address = "Pokhara", Salary = 2000.0 };
        Person p5 = new Person() { Id = 5, FirstName = "Sandesh", LastName = "Magar", Address = "Kathmandu", Salary = 5000.0 };
        Person p6 = new Person() { Id = 6, FirstName = "Kamal", LastName = "pandit", Address = "Kathmandu", Salary = 3000.0 };

        List<Person> persons = new List<Person>() { p1, p2, p3, p4, p5, p6 };
        return persons;

    }

}