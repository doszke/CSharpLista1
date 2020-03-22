using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zad2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FibonacciTest()
        {
            Zad2.Zad2 zad2 = new Zad2.Zad2();
            int x = 2;
            int y = 3;
            int n = 4;
            int[] output;
            int[] expected = {2, 3, 5, 8};
            output = zad2.Fibonacci(x, y, n);
            for(int i = 0; i < 4; i++)
                Assert.AreEqual(expected[i], output[i]);
            
        }

        [TestMethod]
        public void FibonacciTest2()
        {
            Zad2.Zad2 zad2 = new Zad2.Zad2();
            int x = 8;
            int y = 100;
            int n = 7;
            int[] output;
            int[] expected = { 8, 100, 108, 208, 316, 524, 840 };
            output = zad2.Fibonacci(x, y, n);
            for (int i = 0; i < 4; i++)
                Assert.AreEqual(expected[i], output[i]);

        }
    }
}
