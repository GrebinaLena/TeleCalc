using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITUniver.TeleCalc.ConCalc;

namespace ITUniver.TeleCalc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {

            //Arrange
            var calc = new Calc();
            var x = 1;
            var y = 2;

            //Act
            var result1 = calc.Sum(x, y);
            var result2 = calc.Sum(10, 0);

            //Assert
            Assert.AreEqual(3, result1);
            Assert.AreEqual(10, result2);
        }

        [TestMethod]
        public void TestSub()
        {

            //Arrange
            var calc = new Calc();
            var x = 22;
            var y = 13;

            //Act
            var result1 = calc.Sub(x, y);
            var result2 = calc.Sub(1, 100);

            //Assert
            Assert.AreEqual(9, result1);
            Assert.AreEqual(-99, result2);

        }

        [TestMethod]
        public void TestMul()
        {

            //Arrange
            var calc = new Calc();
            var x = 35;
            var y = 0;

            //Act
            var result1 = calc.Mul(x, y);
            var result2 = calc.Mul(-4, 8);

            //Assert
            Assert.AreEqual(0, result1);
            Assert.AreEqual(-32, result2);

        }

        [TestMethod]
        public void TestDiv()
        {

            //Arrange
            var calc = new Calc();
            var x = 48;
            var y = 6;

            //Act
            var result1 = calc.Div(x, y);
            var result2 = calc.Div(100, -12.5);

            //Assert
            Assert.AreEqual(8, result1);
            Assert.AreEqual(-8, result2);

        }

        [TestMethod]
        public void TestPow()
        {

            //Arrange
            var calc = new Calc();
            var x = 67;
            var y = 0;

            //Act
            var result1 = calc.Pow(x, y);
            var result2 = calc.Pow(3, 2);

            //Assert
            Assert.AreEqual(1, result1);
            Assert.AreEqual(9, result2);

        }

    }
}
