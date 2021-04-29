using FizzBuzz.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Tests
{
    [TestFixture]
    class FizzBuzzCalculatorTest
    {
        IFizzBuzzResultCalculator Calculator;

        [OneTimeSetUp]
        public void Setup()
        {
            Calculator = new FizzBuzzCalculator();
        }

        [Test]
        public void ReturnsFizzForMultiplesOfThree([ValueSource(nameof(MultiplesOfThreeAndNotFive))] int value)
        {
            int number = 3 * value;
            var result = Calculator.ComputeValue(number);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void ReturnsBuzzForMultiplesOfFive([ValueSource(nameof(MultiplesOfNotThreeAndFive))] int value)
        {
            int number = 5 * value;
            var result = Calculator.ComputeValue(number);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void ReturnsFizzBuzzForMultiplesOf15([ValueSource(nameof(MultiplesOfThreeAndFive))] int value)
        {
            int number = 15 * value;
            var result = Calculator.ComputeValue(number);
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void ReturnsValueForNonMultiplesOf3And5([ValueSource(nameof(MultiplesOfNotThreeAndNotFive))] int value)
        {
            int number = value;
            var result = Calculator.ComputeValue(number);
            Assert.AreEqual(number.ToString(), result);
        }

        [Test]
        public void IntentionallyBreakingTest()
        {
            var result = Calculator.ComputeValue(1);
            Assert.AreEqual("Fizz", result);
        }

        public static readonly IEnumerable<int> MultiplesOfThreeAndNotFive = Enumerable.Range(1, 500)
                                                                            .Where(n => n % 3 == 0 && n % 5 > 0)
                                                                            .Take(50);
        public static readonly IEnumerable<int> MultiplesOfNotThreeAndFive = Enumerable.Range(1, 500)
                                                                            .Where(n => n % 3 > 0 && n % 5 > 0)
                                                                            .Take(50);
        public static readonly IEnumerable<int> MultiplesOfThreeAndFive = Enumerable.Range(1, 500)
                                                                            .Where(n => n % 3 > 0 && n % 5 > 0)
                                                                            .Take(50);

        public static readonly IEnumerable<int> MultiplesOfNotThreeAndNotFive = Enumerable.Range(1, 500)
                                                                            .Where(n => n % 3 > 0 && n % 5 > 0)
                                                                            .Take(50);
    }
}
