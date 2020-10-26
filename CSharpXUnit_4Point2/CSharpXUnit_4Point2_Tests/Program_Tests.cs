using CSharpXUnit_4Point2;
using Xunit;

namespace CSharpXUnit_4Point2_Tests
{
    public class Program_Tests
    {
        [Theory]
        [InlineData(2, 1)]
        public void DivideByTwo_Valid(int input, int expected)
        {
            // Arrange - Set up any data, variables, objects, etc necessary for testing.
            int output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.DivideByTwo(input);

            // Assert - Check the result to make sure it matches what's expected.
            Assert.Equal(expected, output);
        }
    }
}
