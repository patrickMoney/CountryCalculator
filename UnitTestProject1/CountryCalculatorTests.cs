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

        [TestMethod]
        public void Example7()
        {
            int[,] map = new int[,]{
                {1,2,1,2},
                {1,1,2,1}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(6, countries);
        }

        [TestMethod]
        public void Example8()
        {
            int [,] map = new int [,]{
                {}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(0, countries);
        }


        [TestMethod]
        public void Example9()
        {
            int[,] map = new int[,] { 
                {1,1,1,1,2},
                {1,1,1,1,1}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(2, countries);
        }

        [TestMethod]
        public void Example10()
        {
            int[,] map = new int[,]{
                {1,2,3,3,1},
                {1,1,2,0,1},
                {2,2,3,3,0}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(9, countries);
        }

        [TestMethod]
        public void Example11()
        {
            int[,] map = new int[,]{
                {1,1,1,1,1},
                {1,1,2,1,1},
                {1,1,1,1,1}
            };

            int countries = CountryCalculator.CalculateCountries(map);

            Assert.AreEqual(2, countries);
        }
    }
}
