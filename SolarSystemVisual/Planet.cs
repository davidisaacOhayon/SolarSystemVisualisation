using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemVisual
{
    class Planet : PlanetBody
    {
        public Planet(double mass, double radius, Color color) : base (mass, radius, color)
        {
            this.Mass = mass;
            this.Radius = radius;
            this.Color = color;
        }




        public override void GetDetails()
        {
            Console.WriteLine("Test");
        }
    }
}
