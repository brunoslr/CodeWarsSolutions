using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    class PrintRectanglesWithAsterisksTests
    {
        [Test]
        public void Test3x3()
        {
            string rectangle = new PrintRectanglesWithAsterisks().GetRectangleString(3, 3);
            string expected = "****\r\n" +
                              "*  *\r\n" +
                              "*  *\r\n" +
                              "****\r\n";
            Assert.AreEqual(expected, rectangle);
        }
    }
}

