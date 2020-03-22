using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zad4Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMulMat()
        {
            int[][] expected = {
                new int[]{ 0, 1 },
                new int[]{ 1, 1 }
            };
            int[,] output = Zad4.Program.MulMat(1);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[0].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], output[i, j], 0.0001);
                }
            }

            expected = new int[][]{
                new int[] { 0, 1, 2 },
                new int[] { 1, 1, 2 }, 
                new int[] { 2, 2, 4 }
            };
            output = Zad4.Program.MulMat(2);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[0].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], output[i, j], 0.0001);
                }
            }
        }
    }
}
