using CSharpXUnit_4Point2;
using CSharpXUnit_4Point2.Shapes;
using System;
using Xunit;

namespace CSharpXUnit_4Point2_Tests
{
    public class Drawing_Tests
    {

        [Fact]
        public void Draw_Circle()
        {
            // Arrange
            Circle myCircle = new Circle(Shape.ColourValue.Blue, 10);
            Drawing myDrawing = new Drawing();

            // Act
            myDrawing.Draw(myCircle);

            // Assert
            Assert.Contains(myCircle, myDrawing.Shapes);
        }

        [Fact]
        public void Draw_Rectangle()
        {
            // Arrange
            Rectangle myRectangle = new Rectangle(Shape.ColourValue.Blue, 15, 10);
            Drawing myDrawing = new Drawing();

            // Act
            myDrawing.Draw(myRectangle);

            // Assert
            Assert.Contains(myRectangle, myDrawing.Shapes);
        }

        [Fact]
        public void Draw_Triangle()
        {
            // Arrange
            Triangle myTriangle = new Triangle(Shape.ColourValue.Blue, 15, 10);
            Drawing myDrawing = new Drawing();

            // Act
            myDrawing.Draw(myTriangle);

            // Assert
            Assert.Contains(myTriangle, myDrawing.Shapes);
        }
    }
}
