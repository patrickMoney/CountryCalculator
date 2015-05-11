using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmazonTest;

namespace UnitTestProject1
{
    [TestClass]
    public class CountryCalculatorTests
    {
        [TestMethod]
        public void Example1()
        {
            int[,] map = new int[,] { 
                {1, 1, 1},
                {2, 1, 2},
                {2, 1, 2}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(3, countries);
        }

        [TestMethod]
        public void Example2()
        {
            int[,] map = new int[,] { 
                {1, 1, 2},
                {2, 2, 2},
                {2, 1, 1}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(3, countries);
        }

        [TestMethod]
        public void Example3()
        {
            int[,] map = new int[,] { 
                {1, 1, 2},
                {2, 1, 2},
                {1, 2, 1}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(6, countries);
        }

        [TestMethod]
        public void Example4()
        {
            int[,] map = new int[,] { 
                {2, 1, 1},
                {2, 2, 2},
                {2, 1, 1}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(3, countries);
        }

        [TestMethod]
        public void Example5()
        {
            int[,] map = new int[,] { 
                {1, 1, 1, 1, 1, 1, 2},
                {1, 1, 1, 1, 2, 2, 2},
                {1, 1, 1, 2, 2, 1, 1}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(3, countries);
        }

        [TestMethod]
        public void Example6()
        {
            int[,] map = new int[,] { 
                {1, 1, 2},
                {2, 2, 1},
                {2, 1, 1}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(4, countries);
        }
    }
}
