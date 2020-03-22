using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zad3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGeo1()
        {
            Zad3.Geometric g = new Zad3.Geometric(1.0, 0.1);
            double[] seq = g.GetGeoSequence(3).ToArray();
            double[] expected = new double[] { 1.0, 0.1, 0.01 };
            for (int i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], seq[i], 0.000001);
            g.SetA1(2);
            g.SetQ(2);
            seq = g.GetGeoSequence(4).ToArray();
            expected = new double[] { 2.0, 4.0, 8.0, 16.0 };
            for (int i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], seq[i], 0.000001);
        }

        [TestMethod]
        public void TestStaticGeo()
        {
            double[] seq = Zad3.Geometric.GetGeoSequence(1.0, 0.1, 3).ToArray();
            double[] expected = new double[] { 1.0, 0.1, 0.01 };
            for (int i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], seq[i], 0.000001);
        }
    }
}
