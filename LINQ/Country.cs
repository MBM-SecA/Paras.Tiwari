using System;
using System.Collections.Generic;

public enum Continents
{
    Asia, Europe, SouthAmerica, NorthAmerica, Africa, Australia
}
public class Country
{
    public string Name { get; set; }
    public Continents Continents { get; set; }
    public double Area { get; set; }
    public long Population { get; set; }

    public DateTime IndependenceDay { get; set; }

    public Country(string name, Continents continent, double area, long population, DateTime independenceDay = default)
    {
        Name = name;
        Continents = continent;
        Area = area;
        Population = population;
        IndependenceDay = independenceDay;
    }
    public static List<Country> GetCountries()
    {   
    
        List<Country> countries = new List<Country>();
        countries.Add(new Country("Nepal",Continents.Asia, 23456.556, 324589489));
        countries.Add(new Country("India", Continents.Asia, 2343456,556324589489,new DateTime(1956,3,12)));
        countries.Add(new Country("Russia", Continents.Europe, 234556156156156456,5565632458948954545,DateTime.Parse("1995/5/6")));
        countries.Add(new Country("UK", Continents.Europe, 23456,25456324589489));
        countries.Add(new Country("USA", Continents.NorthAmerica, 67567.1256, 32458944589,new DateTime(1956,3,13)));
        countries.Add(new Country("Canada", Continents.NorthAmerica, 764131515564.1256, 32454646489489677,new DateTime(1956,3,13)));
        countries.Add(new Country("Germany", Continents.Europe, 565434.1256, 324589489677,new DateTime(1956,3,13)));
        countries.Add(new Country("Japan", Continents.Asia, 2346556.1256, 324589489677));
        countries.Add(new Country("France", Continents.Europe, 2346556.1256, 324589489677));
        countries.Add(new Country("Sweeden", Continents.Europe, 2346556.1256, 324589489677,new DateTime(1956,3,13)));
        countries.Add(new Country("Brazil", Continents.SouthAmerica, 2346556.1256, 324589489677));
        countries.Add(new Country("Argentina", Continents.SouthAmerica, 2346556.1256, 324589489677));
        countries.Add(new Country("Cuba", Continents.SouthAmerica, 2346556.1256, 324589489677));
        countries.Add(new Country("Ukarine", Continents.Europe, 2346556.1256, 324589489677));
        countries.Add(new Country("Pakistan", Continents.Asia, 2346556.1256, 34546464565,new DateTime(1956,3,13)));
        countries.Add(new Country("South Korea", Continents.Asia, 2346556.1256, 34545435435,new DateTime(1956,3,13)));
        countries.Add(new Country("North Korea", Continents.Asia, 4313.1256, 45345344,new DateTime(1956,3,13)));
        countries.Add(new Country("China", Continents.Asia, 234312545456, 234345));
        countries.Add(new Country("Australia", Continents.Australia, 2346556.1256, 4534535,new DateTime(1956,3,13)));
        countries.Add(new Country("Nigeria", Continents.Africa, 73313.1256, 65646564,new DateTime(1956,3,13)));
        countries.Add(new Country("Egypt", Continents.Africa, 1321324.1256, 313344545,new DateTime(1956,3,13)));
        countries.Add(new Country("Vatican City", Continents.Europe, 23466.1256, 979,new DateTime(1956,3,13)));
        return countries;
    }

}