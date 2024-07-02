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

        private double XSpeed;
        private double YSpeed;

        private int XPos;
        private int YPos;

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



        public void UpdatePosition()
        {
            this.XPos = this.XPos + (int)(this.XSpeed);
            this.YPos = this.YPos + (int)(this.YSpeed);
        }


        public abstract void GetDetails();



    }

    


}
