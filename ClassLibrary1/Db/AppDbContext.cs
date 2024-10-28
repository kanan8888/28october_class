using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public class AppDbContext
    {
        List<Country> Countries=new List<Country>();
        List<Planet> Planets= new List<Planet>();

        public static void CreateCountry(Country country) 
        {
            Countries.Add(country);
        }
        public static void UpdateCountry(int id, Country country)
        {
            Country fcountry =   Countries.Find(x => x.CountryId == id);
            if (fcountry != null)
            {
                fcountry = country;
            }
            else
            {
                Console.WriteLine("bu id de country yoxdur");
            }
        }
        public static void RemoveCountry(int id)
        {
            Country country = Countries.Find(x => x.CountryId == id);
            if (country != null)
            {
                Planets.Remove(country);
            }
            else
            {
                Console.WriteLine(" bele bir country onsuzda yoxdur..... ");
            }
        }
        public static void GetAllCountries() 
        {
            foreach (Country country in Countries) 
            {
                Console.WriteLine(country);
            }
        }
        public static void GetCountryByRegion(Region region) 
        {
            foreach (Country country in Countries)
            {
                if (country.Region==region)
                {
                    Console.WriteLine(country);
                }
            }
        }



        public static void CreatePlanet(Planet planet) 
        {
            Planets.Add(planet);
        }
        public static void UpdatePlanet(int id, Planet planet) 
        {
            Planet fplanet = Planets.Find(x => x.PlanetId == id);
            if (fplanet != null)
            {
                fplanet = planet;
            }
            else 
            {
                Console.WriteLine("bu id de planet yoxdur");
            }
        }
        public static void RemovePlanet(int id)
        {
            Planet planet = Planets.Find(x => x.PlanetId == id);
            if (planet != null)
            {
                Planets.Remove(planet);
            }
            else 
            {
                Console.WriteLine(" bele bir planet onsuzda yoxdur..... ");
            }
        }
        public  static void GetAllPlanets() 
        {
            foreach (Planet planet in Planets) 
            {
                Console.WriteLine(planet);
            }
        }




    }
}
