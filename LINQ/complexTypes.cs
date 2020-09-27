 using System;
 using System.Linq;
 using System.Collections.Generic;
public class  ComplexType
 {
 
 public  void CountryProgram(){
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
            
            
            var nonColonizedAsian = from member in countries
                                    where(member.Continents == Continents.Asia) && ( member.IndependenceDay==default)
                                    select member;
            Console.WriteLine("List asian countries which are not ever invaded:");
            foreach (var member in nonColonizedAsian)
            {
                Console.WriteLine(member.Name);
            }
   }
 }