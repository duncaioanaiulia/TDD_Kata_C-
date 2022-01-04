using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Test_Multiples_Three()
        {
            int number = 3;
            string expected = "Fizz";
            var fizzBuzz = new FizzBuzzClass();

            // act
            string test = fizzBuzz.GetFizzBuzzList(number);

            // assert
            Assert.AreEqual(expected, test);
        }

    }
}
