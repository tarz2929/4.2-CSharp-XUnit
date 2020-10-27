using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpXUnit_4Point2.Shapes
{
    // Pillar: Inheritance
    class Circle : Shape
    {
        /*
         “Perimeter” is equivalent to a circumference for “Circle”.
        Properties:
            ✅ “Radius”
            ✅ “Diameter”
                ✅ Public getter that derives its value from “Radius”.

        */
        public override double Perimeter => Math.PI * Diameter;

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public double Radius { get; set; }

        public double Diameter
        {
            get => Radius * 2;
            set
            {
                Radius = value / 2;
            }
        }

        public Circle() : base()
        {
            Radius = 20;
        }

        public Circle(ColourValue colour, double radius) : base(colour)
        {
            Radius = radius;
        }
    }
}
