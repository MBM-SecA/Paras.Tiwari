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
            foreach (var value in asianCountries)
            {
                Console.WriteLine(value.Name);
            }

            //HW1: List countries in Europe Which Have population less <10k

            var europeanCountries = from member in countries
                                    where (member.Continents == Continents.Europe)&& (member.Population < 10000)
                                    select member;

            Console.WriteLine("List of Europen countries which has population less than 10K are:");
            foreach (var value in europeanCountries)
            {
                Console.WriteLine(value.Name);
            }
            //HW2: List asian countries which are not ever invaded.
            
            
            var nonColonizedAsian = from member in countries
                                    where(member.Continents == Continents.Asia) && ( member.IndependenceDay==default)
                                    select member;
            Console.WriteLine("List asian countries which are not ever invaded:");
            foreach (var item in nonColonizedAsian)
            {
                Console.WriteLine(item.Name);
            }
            // HW - Is there any African country in your country collection
            
            var africanMember = countries.Any(x=> x.Continents==Continents.Africa);
                                
            if( africanMember)
                Console.WriteLine("List contains african member");
            else
                 Console.WriteLine("List doesn't contain african member");
        
        //Hw- Print First 2 largest asian country names.
        var areaOrderedList = countries.OrderByDescending( x => x.Area);
                                
        var firstTwoLargestCountry = areaOrderedList.Take(2);
         Console.WriteLine("Two largest members are:");
        foreach (var item in firstTwoLargestCountry)
            {
                Console.WriteLine(item.Name);
            }

          
   }
 }