using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemVisual
{
    abstract class PlanetBody
    {
        private double mass;
        private double radius;
        private Color color;

        public PlanetBody(double mass, double radius, Color color)
        {
            this.mass = mass;
            this.radius = radius;
            this.color = color;
        }

        public PlanetBody(double mass)
        {
            this.mass = mass;
        }

        public PlanetBody(double radius, double mass)
        {
            this.radius = radius;
        }


        public double Mass
        {
            get => this.mass;
            set => this.mass = value;
        }

        public double Radius
        {
            get => this.radius;
            set => this.radius = value;
        }

        public Color Color
        {
            get => this.Color; 
            set => this.Color = value;
        }



        public abstract void GetDetails();



    }

    


}
