
using System;
using System.IO;
using System.Linq;


class Program
{
    static void Main()
    {
        var countriesText = File.ReadAllText("countries.txt");
        string[] countries = countriesText.Split("\r\n");
        //var countriesWithNInitial= countries.Select(x=(x where (x.StartsWith("N")));
        var countriesWithNInitial = countries.AsEnumerable().Where(lambda => lambda.StartsWith("N"));
        Console.WriteLine("Countries starting from N are: ");
        foreach (var country in countriesWithNInitial)
            Console.WriteLine(country);

        /* MAin program for lamda expression use and reading content of file
        FileIO fileIO = new FileIO();
        fileIO.LearnFileHandling();
        fileIO.LearnFileInfo();
        fileIO.LearnDirectories();
        */

         /* MAin program inheritance.cs
        Rectangle rectangle = new Rectangle(23.5f, 56.7f);
        rectangle.Display();
        Square square = new Square(25.00f);
        square.Display();
        Circle circle = new Circle(23.5f);
        circle.Display();
        */

        


    }



}

