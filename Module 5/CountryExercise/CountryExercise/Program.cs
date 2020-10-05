using System;
using System.Net;
using WorldNamespace;


namespace CountryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();
            CountryLanguage countryLanguages = new CountryLanguage();


            countryLanguages.FirstLanguage = Languages.English.ToString();
            countryLanguages.SecondLanguage = Languages.French.ToString();
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName="Ireland";
            countryOneInstance.CountryLanguages = countryLanguages;
            countryOneInstance.Continent = Continents.Europe;
            countryOneInstance.Currency = Currencies.PoundSterling;

            countryOneInstance.SayHi();
            countryOneInstance.SayHi(countryOneInstance.CountryName);
            Console.WriteLine($"Planet is {countryOneInstance.PlanetName} and Country is {countryOneInstance.CountryName} Continent is {countryOneInstance.Continent} currency is {countryOneInstance.Currency} "); 
   


        }
    }
}
