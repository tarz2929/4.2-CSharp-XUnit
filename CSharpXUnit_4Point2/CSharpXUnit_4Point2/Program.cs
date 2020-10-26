using System;

namespace CSharpXUnit_4Point2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int DivideByTwo(int number)
        {
            return number / 2;
        }
        // In-class practice:
        // Write the method to determine if a number is a perfect square. Should return true if so, and false if not.
        // Write tests for the edge cases and any other significant values.
        // If you can't get the method working after 5 minutes, write the tests and come back.
        public static bool PerfectSquare(int number)
        {
            return Math.Sqrt(number) == Math.Ceiling(Math.Sqrt(number));
        }

        public static void ThrowsFormatException()
        {
            int.Parse("Hello");
        }
    }
}
