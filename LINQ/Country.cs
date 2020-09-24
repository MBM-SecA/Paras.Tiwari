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
        countries.Add(new Country("India", Continents.Asia, 2343456,556324589489));
        countries.Add(new Country("Russia", Continents.Europe, 234456,55656324589489));
        countries.Add(new Country("UK", Continents.Europe, 23456,25456324589489));
        countries.Add(new Country("USA", Continents.NorthAmerica, 67567.1256, 32458944589));
        countries.Add(new Country("Canada", Continents.NorthAmerica, 764564.1256, 324589489677));
        countries.Add(new Country("Germany", Continents.Europe, 565434.1256, 324589489677));
        countries.Add(new Country("Japan", Continents.Asia, 2346556.1256, 324589489677));
        countries.Add(new Country("France", Continents.Europe, 2346556.1256, 324589489677));
        countries.Add(new Country("Sweeden", Continents.Europe, 2346556.1256, 324589489677));
        countries.Add(new Country("Brazil", Continents.SouthAmerica, 2346556.1256, 324589489677));
        countries.Add(new Country("Argentina", Continents.SouthAmerica, 2346556.1256, 324589489677));
        countries.Add(new Country("Cuba", Continents.SouthAmerica, 2346556.1256, 324589489677));
        countries.Add(new Country("Ukarine", Continents.Europe, 2346556.1256, 324589489677));
        countries.Add(new Country("Pakistan", Continents.Asia, 2346556.1256, 34546464565));
        countries.Add(new Country("South Korea", Continents.Asia, 2346556.1256, 34545435435));
        countries.Add(new Country("North Korea", Continents.Asia, 4342.1256, 45345344));
        countries.Add(new Country("China", Continents.Asia, 2343125456, 234345));
        countries.Add(new Country("Australia", Continents.Australia, 2346556.1256, 4534535));
        countries.Add(new Country("Nigeria", Continents.Africa, 75643342.1256, 65646564));
        countries.Add(new Country("Egypt", Continents.Africa, 1321324.1256, 342344545));
        countries.Add(new Country("Vatican City", Continents.Europe, 23466.1256, 979));
        return countries;
    }

}