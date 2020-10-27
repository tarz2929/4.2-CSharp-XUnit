using CSharpXUnit_4Point2;
using CSharpXUnit_4Point2.Shapes;
using System;
using Xunit;

namespace CSharpXUnit_4Point2_Tests
{
    // In-class practice:
    // Write tests for the Rectangle class that will test to make sure that when a length is provided that is shorter than the width, they trade values.
    // And also that when a width is provided that is longer than the length, they also trade values.
    // Example:
    // Before: Width = 10, Length = 20.
    // Value Provided: Length = 5.
    // After: Width = 5, Length = 10.

    public class Rectangle_Tests
    {
        [Theory]
        // Normal Set
        [InlineData(10, 5, 12, 12, 5)]
        [InlineData(100, 80, 90, 90, 80)]
        // Switch Set
        [InlineData(10, 5, 4, 5, 4)]
        [InlineData(100, 80, 50, 80, 50)]
        public void Length_Set(int initialLength, int initialWidth, int newLength, int expectedLength, int expectedWidth)
        {
            // Arrange
            Rectangle myRectangle = new Rectangle(Shape.ColourValue.Red, initialLength, initialWidth);

            // Act
            myRectangle.Length = newLength;

            // Assert
            Assert.Equal(expectedLength, myRectangle.Length);
            Assert.Equal(expectedWidth, myRectangle.Width);
        }

        [Theory]
        // Normal Set
        [InlineData(10, 5, 4, 10, 4)]
        [InlineData(100, 80, 50, 100, 50)]
        // Switch Set
        [InlineData(10, 5, 12, 12, 10)]
        [InlineData(100, 80, 110, 110, 100)]
        
        public void Width_Set(int initialLength, int initialWidth, int newWidth, int expectedLength, int expectedWidth)
        {
            // Arrange
            Rectangle myRectangle = new Rectangle(Shape.ColourValue.Red, initialLength, initialWidth);

            // Act
            myRectangle.Width = newWidth;

            // Assert
            Assert.Equal(expectedLength, myRectangle.Length);
            Assert.Equal(expectedWidth, myRectangle.Width);
        }

    }
}
