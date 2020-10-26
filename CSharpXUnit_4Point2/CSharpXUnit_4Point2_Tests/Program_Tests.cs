using CSharpXUnit_4Point2;
using Xunit;

namespace CSharpXUnit_4Point2_Tests
{
    public class Program_Tests
    {

        // A theory is meant for testing a method with a set of data. Typically you won't be able to test all permutations or possible inputs of the method (example being math operations), however it is good to test edge cases as well as areas around zero.
        // If you method works for all ints, check the max and min values, zero, -1 and 1, for example.
        [Theory]
        [InlineData(2, 1)]
        [InlineData(4, 2)]
        [InlineData(3, 1)]
        [InlineData(0, 0)]
        [InlineData(-2, -1)]
        [InlineData(int.MaxValue, 1073741823)]
        [InlineData(int.MinValue, -1073741824)]
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
