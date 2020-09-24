using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //LINQ = language Integrated Query
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
                    Console.WriteLine(name); */
            //listing out Asian countries
            List<Country> countries = Country.GetCountries();
            var asianCountries = from member in countries
                                 where member.Continents == Continents.Asia
                                 select member;
            foreach (var member in asianCountries)
            {
                Console.WriteLine(member.Name);
            }

            //HW1: List countries in Europe Which Have population less <10k

            var europeanCountries = from member in countries
                                    where (member.Continents == Continents.Europe)&& (member.Population < 10000)
                                    select member;

            Console.WriteLine("List of Europen countries which has population less than 10K are:");
            foreach (var member in europeanCountries)
            {
                Console.WriteLine(member.Name);
            }
            //HW2: List asian countries which are not ever invaded.
            List<string> nonColonizedList = new List<string> {"Nepal","Bhutan","China","Japan"};
            
            var nonColonizedAsian = from member in countries
                                    where(member.Continents == Continents.Asia) && ( nonColonizedList.Contains(member.Name))
                                    select member;
            Console.WriteLine("List asian countries which are not ever invaded:");
            foreach (var member in nonColonizedAsian)
            {
                Console.WriteLine(member.Name);
            }



        }
    }
}


