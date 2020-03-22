using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zad5Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String input = "Witam, nazywam się Kuba. "; //9 samogłosek
            String input2 = "aeiouyąę"; //8
            String input3 = "AEIOUYĄĘ"; //8
            String input4 = "azaxacavabanam"; //7
            String input5 = "zxcvbnmqwrtpsdfghjkl[];'./,<>?:{ }_+1234567890!@#$%^&*()`~"; //0
            String[] inputs = { input, input2, input3, input4, input5 };
            int[] expected = { 9, 8, 8, 7, 0 };
            for (int i = 0; i < expected.Length; i++)
            {
                int count = Zad5.Program.CountVowels(inputs[i]);
                Assert.AreEqual(expected[i], count, 0.0001);
            }
        }
    }
}
