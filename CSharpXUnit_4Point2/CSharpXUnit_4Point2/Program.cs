using CSharpXUnit_4Point2.Shapes;
using System;

namespace CSharpXUnit_4Point2
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing myDrawing = new Drawing();
            Circle myCircle = new Circle(Shape.ColourValue.Blue, 10);
            myDrawing.Draw(myCircle);
            Rectangle myRectangle = new Rectangle(Shape.ColourValue.Green, 10, 10);
            myDrawing.Draw(myRectangle);

            myRectangle.Width = 12;

            myCircle.Diameter = 25;

            // Circle: Perimeter ~64, Area ~314
            // Rect: Perimeter 40, Area 100

            Console.WriteLine(myDrawing);
            Console.WriteLine(myDrawing.LinesDrawn);
            Console.WriteLine(myDrawing.SpaceCovered);
        }
    }
}
