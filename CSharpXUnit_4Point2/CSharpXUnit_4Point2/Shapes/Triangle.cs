using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpXUnit_4Point2.Shapes
{
    class Triangle : Shape
    {
        /*
         Represents an equilateral or isosceles triangle, not a scalene triangle.
        Properties:
            ✅ “Base”
            ✅ “Height”
        */

        public override double Perimeter => (Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Base / 2, 2)) * 2) + Base;


        public override double Area => Base * Height / 2;

        public double Base { get; set; }

        public double Height { get; set; }

        public Triangle() : base()
        {
            Base = 20;
            Height = 10;
        }

        public Triangle(ColourValue colour, double bottom, double height) : base(colour)
        {
            Base = bottom;
            Height = height;
        }
    }
}
