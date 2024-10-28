using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public class Planet
    {
        static int Id;

        int _planetId= ++Id;

        public Planet(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int PlanetId { get; }
        public string Name { get; set; }
        public double Area { get; set; }



        public override string ToString()
        {
            return $"\nName-{Name}, Area-{Area}";
        }

    }
}
