using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjectTask0PT
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cal1 = new Class1();
            Assert.AreEqual(cal1.add(1,2),3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var cal2 = new Class1();
            Assert.AreEqual(cal2.substract(4,2),2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var cal3 = new Class1();
            Assert.AreEqual(cal3.divide(6,2),3);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var cal4 = new Class1();
            Assert.AreEqual(cal4.multiply(2,2),4);
        }
    }
}