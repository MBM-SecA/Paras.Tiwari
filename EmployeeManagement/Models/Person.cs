using System.Collections.Generic;
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Person> GetData()
    {//object initializer syntax
        Person emp1 = new Person() { FirstName = "Bishnu", LastName = "Rawal", Address = "Kathmandu", Salary = 20000.0 };
        Person emp2 = new Person() { FirstName = "Paras", LastName = "Tiwari", Address = "Pokhara", Salary = 2000.0 };
        Person emp3 = new Person() { FirstName = "Cosmic", LastName = "Koirala", Address = "Butwal", Salary = 6000.0 };
        Person emp4 = new Person() { FirstName = "Hari", LastName = "Sapkota", Address = "Pokhara", Salary = 2000.0 };
        Person emp5 = new Person() { FirstName = "Sandesh", LastName = "Magar", Address = "Kathmandu", Salary = 5000.0 };
        Person emp6 = new Person() { FirstName = "Kamal", LastName = "pandit", Address = "Kathmandu", Salary = 3000.0 };
        List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5, emp6 };

        return employees;
    }

}