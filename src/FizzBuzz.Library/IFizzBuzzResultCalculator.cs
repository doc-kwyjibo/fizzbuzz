using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Library
{
    public interface IFizzBuzzResultCalculator
    {
        string ComputeValue(int number);
    }
}
