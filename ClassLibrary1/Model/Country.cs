using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1.Model
{
    public class Country
    {
        static int Id;

        int _countryId=++Id;
        public int CountryId { get;}
        public string CountryName { get; set; }
        public double Area { get; set; }
        public string Anthem { get; set; }
        public Region Region { get; set; }

        public Country(string countryName, double area ,Region region)
        {
            CountryName = countryName;
            Area = area;
            Region = region;
        }


        public override string ToString()
        {
            return $"\nCountryName-{CountryName}, Area-{Area}, Region-{Region} ";
        }


    }
}
