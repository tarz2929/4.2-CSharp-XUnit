using CSharpXUnit_4Point2;
using CSharpXUnit_4Point2.Shapes;
using System;
using Xunit;

namespace CSharpXUnit_4Point2_Tests
{
    public class Circle_Tests
    {
        [Theory]
        [InlineData(5, 20, 10)]
        [InlineData(100, 50, 25)]
        public void Diameter_Set(int initialRadius, int newDiameter, int expectedRadius)
        {
            // Arrange
            Circle myCircle = new Circle(Shape.ColourValue.Red, initialRadius);

            // Act
            myCircle.Diameter = newDiameter;

            // Assert
            Assert.Equal(expectedRadius, myCircle.Radius);

        }
  
    }
}
