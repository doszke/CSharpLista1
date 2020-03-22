using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zad6Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindDuplicatesTest()
        {
            HashSet<String> set1 = new HashSet<String>(new String[] { "doniczka", "bułka", "alek", "ma", "pies"});
            HashSet<String> set2 = new HashSet<String>(new String[] { "cegła", "bułka", "ma", "kot", "alek"});
            String[] expected = { "alek", "bułka", "ma" };
            String[] output = Zad6.Program.FindDuplicates(set1, set2).ToArray();
            for (int i = 0; i < expected.Length; i++) Assert.AreEqual(expected[i], output[i]);
        }
    }
}
