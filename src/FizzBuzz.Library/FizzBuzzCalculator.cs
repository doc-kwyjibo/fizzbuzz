using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Library
{
    public class FizzBuzzCalculator : IFizzBuzzResultCalculator
    {
        public string ComputeValue(int number)
        {
            var isDivisibleby3 = number % 3 == 0;
            var isDivisibleby5 = number % 5 == 0;
            if (isDivisibleby3 && isDivisibleby5)
            {
                return "FizzBuzz";
            }
            if (isDivisibleby3)
            {
                return "Fizz";
            }
            if (isDivisibleby5)
            {
                return "Buzz";
            }
            // not divisible, so return the number
            return number.ToString();
        }
    }
}
