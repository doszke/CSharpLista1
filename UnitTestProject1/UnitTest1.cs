using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Zad1Test
    {

        [TestMethod]
        public void CalculateTriangleFieldTest()
        {
            Zad1.Zad1 o = new Zad1.Zad1();
            int a = 3;
            int b = 4;
            int c = 5;
            int pole = a * b / 2;
            Assert.AreEqual(pole, o.CalculateTriangleField(a, b, c));
        }

        [TestMethod]
        public void CheckvaluesTest()
        {
            Zad1.Zad1 o = new Zad1.Zad1();
            double a = 2.0, b = 4.0, c = 6.0;
            Assert.IsFalse(o.CheckValues(a, b, c));
            Assert.IsFalse(o.CheckValues(b, a, c));
            Assert.IsFalse(o.CheckValues(c, a, b));
            Assert.IsFalse(o.CheckValues(b, c, a));
            Assert.IsFalse(o.CheckValues(a, c, b));
            Assert.IsFalse(o.CheckValues(c, b, a));
        }

        [TestMethod]
        public void CheckValuesTest2()
        {
            Zad1.Zad1 o = new Zad1.Zad1();
            double _a = 5.0;
            double _b = 5.0;
            double _c = 1.0;
            Assert.IsTrue(o.CheckValues(_a, _b, _c));
            Assert.IsTrue(o.CheckValues(_b, _a, _c));
            Assert.IsTrue(o.CheckValues(_c, _a, _b));
            Assert.IsTrue(o.CheckValues(_b, _c, _a));
            Assert.IsTrue(o.CheckValues(_a, _c, _b));
            Assert.IsTrue(o.CheckValues(_c, _b, _a));
        }
    }
}
