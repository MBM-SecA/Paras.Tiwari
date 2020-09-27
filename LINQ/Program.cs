using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
             //LINQ = language Integrated Query
            int[] numbers ={ 23 ,34 , 56 ,67,89,9,0};
            
            //Using method syntax -lamda Expression
            var numbersGreaterThan50 = numbers.Where(x => x>50);
            //Using sql query syntax - querry expression
            var numbersGreaterThanFifty = from num in numbers
                                          where num > 50
                                          select num;
            String[] names = {"Paras","abc","Rajesh","Rit","Ramesh","kamal","Ramsey","rohit"}; 
             //Using method syntax -lamda Expression
             var namesStartingFromR = names.Where(x => x.ToUpper().StartsWith("R") && x.Length>3);
             //Using sql query syntax - querry expression
             var namesStartingFromR2 = from name in names
                                        where name.ToUpper().StartsWith("R") && name.Length>3
                                        select name;
            foreach( var name in namesStartingFromR2)
                    Console.WriteLine(name); 
            //listing out Asian countries
            //ComplexType complexType =new ComplexType();
              //  complexType.CountryProgram();

            //projection
            var Squares = from num in numbers
                            select num*num;

                    foreach(var square in Squares)
                    {
                        Console.WriteLine(square);
                    }
           
            //sorting
            var sorted = from num in numbers
                        orderby num
                        select num;
                    foreach(var value in sorted)
                    {
                        Console.WriteLine(value);
                    }
            //ordering Names
            var result1 = from name in names
                            orderby name
                            select name;
             foreach(var value in result1)
                    {
                        Console.WriteLine(value);
                    }
            // taking out only first five no of collection
            //partitioning
            var result2 = numbers.Skip(5).Take(5);
                foreach(var value in result2)
                    {
                        Console.WriteLine(value);
                    }



        }
    }
}


