using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpXUnit_4Point2.Shapes
{
    class Rectangle : Shape
    {
        /*
         Properties:
            ✅ “Length”
            ✅ “Width”
        */

        public override double Perimeter => (Length + Width) * 2;

        public override double Area => Length * Width;

        double _length;
        public double Length
        {
            get => _length;
            set
            {
                // The new Length value is shorter than the current Width value.
                if (value < Width)
                {
                    _length = Width;
                    Width = value;
                }
                else
                {
                    _length = value;
                }
            }
        }

        double _width;
        public double Width {
            get => _width;
            set
            {
                // The new Width value is longer than the current Length value.
                if (value > Length)
                {
                    _width = Length;
                    Length = value;
                }
                else
                {
                    _width = value;
                }
            }
        }

        public Rectangle() : base()
        {
            Length = 20;
            Width = 10;
        }

        public Rectangle(ColourValue colour, double length, double width) : base(colour)
        {
            Length = length;
            Width = width;
        }
    }
}
