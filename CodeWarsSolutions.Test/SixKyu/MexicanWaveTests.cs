using System.Collections.Generic;
using NUnit.Framework;
using CodeWarsSolutions.SixKyu;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    class MexicanWaveTests
    {

        MexicanWave sut;

        [OneTimeSetUp]
        public void WaveSetup()
        {
            sut = new MexicanWave();
        }

        [TestCase]
        public void BasicTest1()
        {
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.AreEqual(result, sut.wave("hello"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest2()
        {
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.AreEqual(result, sut.wave("codewars"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest3()
        {
            List<string> result = new List<string> { };
            Assert.AreEqual(result, sut.wave(""), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest4()
        {
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.AreEqual(result, sut.wave("two words"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest5()
        {
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.AreEqual(result, sut.wave(" gap "), "it should return '" + result + "'");
        }

    }
}
