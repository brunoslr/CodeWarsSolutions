using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

    namespace CodeWarsSolutions.Test.SevenKyu
{

    [TestFixture]
    public class WordGuesserTests
    {
        [TestCase("dog", "car", 0)]
        [TestCase("dog", "god", 1)]
        [TestCase("dog", "cog", 2)]
        [TestCase("dog", "cod", 1)]
        [TestCase("dog", "bog", 2)]
        [TestCase("dog", "dog", 3)]
        public void GuesserTest(string correctWord, string guess, int expected)
        {
            Assert.AreEqual(expected, new WordGuesser().CountCorrectCharacters(correctWord, guess));
        }
    }
}
