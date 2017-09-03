using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170903_ReverseWords
{
    [TestClass]
    public class ReverseWordsTests
    {
        [TestMethod]
        public void input_a_shuold_return_a()
        {
            ReverseWordsShouldBe("a", "a");
        }

        private static void ReverseWordsShouldBe(string expected, string str)
        {
            var kata = new Kata();
            var actual = kata.ReverseWords(str);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string ReverseWords(string str)
        {
            return str;
        }
    }
}
