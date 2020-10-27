using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpXUnit_4Point2.Shapes
{
    // Pillar: Abstraction
    abstract class Shape
    {
        /*
         Properties, public getters only that must be overridden and provided functionality by derived classes:
            ✅ “Area”
            ✅ “Perimeter”
        Traditional Properties:
            ✅ “Colour”
                String for the name of the colour is sufficient.
        Methods:
            ✅ Default and greedy constructors that are overridden and provided functionality by derived classes. 
            “Colour” should not be explicitly set in the derived classes, the base constructor should be called.
        */
        abstract public double Area { get; }

        abstract public double Perimeter { get; }

        public enum ColourValue
        {
            Red,
            Green,
            Blue
        }

        public ColourValue Colour { get; set; }

        public Shape()
        {
            Colour = ColourValue.Red;
        }

        public Shape(ColourValue colour)
        {
            Colour = colour;
        }
    }
}
