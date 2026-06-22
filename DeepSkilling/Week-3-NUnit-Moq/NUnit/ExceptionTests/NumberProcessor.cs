using System;

namespace NUnitDemo.ExceptionTests
{
    public class NumberProcessor
    {
        public int SquareRoot(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number cannot be negative");

            return (int)Math.Sqrt(number);
        }
    }
}
