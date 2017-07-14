using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
   
    [TestFixture]
    public class TacofyTests
    {
        [Test]
        public void TacofyBasicTest()
        {
            var kata = new TacofyClass();

            Assert.AreEqual(new string[] { "shell", "shell" }, kata.Tacofy(""));
            Assert.AreEqual(new string[] { "shell", "beef", "shell" }, kata.Tacofy("a"));
            Assert.AreEqual(new string[] { "shell", "guacamole", "guacamole", "guacamole", "shell" }, kata.Tacofy("ggg"));
            Assert.AreEqual(new string[] { "shell", "beef", "guacamole", "lettuce", "shell" }, kata.Tacofy("ogl"));
            Assert.AreEqual(new string[] { "shell", "tomato", "beef", "shell" }, kata.Tacofy("ydjkpwqrzto"));
        }
    }
}
