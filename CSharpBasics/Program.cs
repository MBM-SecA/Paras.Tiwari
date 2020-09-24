
using System;
using System.IO;
using System.Linq;


class Program
    {        static void Main()
        {
        var countriesText = File.ReadAllText("countries.txt");
        string[] countries =countriesText.Split("\r\n");
        //var countriesWithNInitial= countries.Select(x=(x where (x.StartsWith("N")));
        var countriesWithNInitial =  countries.AsEnumerable().Where(lambda => lambda.StartsWith("N"));
        Console.WriteLine("Countries starting from N are: ");
          foreach(var country in countriesWithNInitial)
              Console.WriteLine(country);

        }
    


    }

