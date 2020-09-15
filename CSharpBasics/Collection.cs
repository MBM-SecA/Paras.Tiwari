using System;
using System.Collections.Generic;
namespace Collections
{
    public class LearnCollections
    {
        void LearnLists()
        {   
            // defining list of certian type
            List<byte> ages =new List<byte>();
            //adding item to the list
            ages.Add(1);
            ages.Add(10);
            ages.Add(100);
            ages.Add(255);
            //removing item from list
            ages.Remove(10);
            //if repated removes first oocurrence



            List<country> countries = new List<country>();
            countries.Add(new country());


        }
        public class country
        {
            public string Name{get; set;}
        }
        public void LearnDictionary()
        {
            Dictionary<string , string> countryCapitals = new Dictionary<string, string>
            {
                ["Nepal"]="kathmandu",
                ["India"]="New Dehli",
                ["Bhutan"]="Thimpu"

            };
           foreach( var country in countryCapitals)
           {
               Console.WriteLine($"Country:{country.Key} Capital city:{country.Value}");
           }
        }
    }
}