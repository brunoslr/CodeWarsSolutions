using CodeWarsSolutions.EightKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.EightKyu
{
    [TestFixture]
    public static class RemoveExclamationMarkTests
    {
        [TestCase("", "", "Input: Empty string")]
        [TestCase("!", "", "Input: !")]
        [TestCase("!!", "", "Input: !!")]
        [TestCase("Hi!", "Hi", "Input: Hi!")]
        [TestCase("!?!", "?", "Input: !?!")]
        [TestCase("NoExclamation", "NoExclamation", "Input: NoExclamation")]
        [Category("EightKyu")]
        public static void MyTests(string input, string expected,string message)
        {
            Assert.AreEqual(expected, RemoveExclamationMark.RemoveExclamationMarks(input), message);
        }
    }
}
