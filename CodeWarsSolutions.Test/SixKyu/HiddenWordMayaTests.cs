using CodeWarsSolutions.SixKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    class HiddenWordMayaTests
    {
        HiddenWordMaya kata = new HiddenWordMaya();

        [TestCase]
        public void BasicTest1()
        {
            Assert.AreEqual("aid", kata.hidden(637));
        }

        [TestCase]
        public void BasicTest2()
        {
            Assert.AreEqual("debt", kata.hidden(7415));
        }

        [TestCase]
        public void BasicTest3()
        {
            Assert.AreEqual("email", kata.hidden(49632));
        }

        [TestCase]
        public void BasicTest4()
        {
            Assert.AreEqual("melted", kata.hidden(942547));
        }
    }
}
