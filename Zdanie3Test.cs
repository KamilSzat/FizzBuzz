using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie3;

namespace Zadanie3
{
    [TestClass]
    public class Zdanie3Test
    {
        [TestMethod]
        public void FizzBuzz_DivisibleBy3_ReturnFizz()
        {
            var z = new Zadanie3();
            Assert.AreEqual("Fizz", z.FizzBuzz(9));
        }

        [TestMethod]
        public void FizzBuzz_DivisibleBy5_ReturnBuzz()
        {
            var z = new Zadanie3();
            Assert.AreEqual("Buzz", z.FizzBuzz(10));
        }

        [TestMethod]
        public void FizzBuzz_DivisibleBy3And5_ReturnFizzBuzz()
        {
            var z = new Zadanie3();
            Assert.AreEqual("FizzBuzz", z.FizzBuzz(30));
        }

        [TestMethod]
        public void FizzBuzz_NoDivisible_ReturnNumber()
        {
            var z = new Zadanie3();
            Assert.AreEqual("7", z.FizzBuzz(7));
        }

    }
}