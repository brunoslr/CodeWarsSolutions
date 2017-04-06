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

    [TestFixture]
    public class SpacesRemoverTests
    {
        [Test]
        public void SpacesRemoverBasicTests()
        {
            Assert.AreEqual("8j8mBliB8gimjB8B8jlB", SpacesRemover.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));
            Assert.AreEqual("88Bifk8hB8BB8BBBB888chl8BhBfd", SpacesRemover.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
            Assert.AreEqual("8aaaaaddddr", SpacesRemover.NoSpace("8aaaaa dddd r     "));
        }
    }

}
