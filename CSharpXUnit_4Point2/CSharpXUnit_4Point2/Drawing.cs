using CSharpOOP.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOOP
{
    class Drawing
    {
        /*
         Properties:
            ✅ “Shapes” (private getter and setter)
                ✅ Polymorphic list of “Shape”.
            ✅ “SpaceCovered” (public getter only)
                ✅ Total area of the contents of “Shapes”.
            ✅ “LinesDrawn” (public getter only).
                ✅ The total perimeter/circumference of the contents of “Shapes”.
        Methods:
            ✅ “Draw(Shape)” 
                ✅ Accepts a polymorphic “Shape” argument and adds it to the “Shapes” list.
            ✅ A ToString() override, which will output “A drawing consisting of X shapes.” where X is the number of items in “Shapes”.
            ✅ A default constructor that will initialize “Shapes”.
        */

        // Pillar: Polymorphism
        private List<Shape> Shapes { get; set; }

        public double SpaceCovered => Shapes.Select(x => x.Area).Sum();

        public double LinesDrawn => Shapes.Select(x => x.Perimeter).Sum();

        // Pillar: Encapsulation
        public void Draw(Shape shape)
        {
            Shapes.Add(shape);
        }

        public override string ToString()
        {
            return $"A drawing consisting of {Shapes.Count} shapes.";
        }

        public Drawing()
        {
            Shapes = new List<Shape>();
        }
    }
}
