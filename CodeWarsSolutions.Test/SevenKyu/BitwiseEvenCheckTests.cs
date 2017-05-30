using System.IO;
using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{

    [TestFixture]
    public class BitwiseEvenCheckTests

    {
        [Test]
        public void IsEven_SourceCode_DoesNotContainModOperator()
        {
            var text = File.ReadAllText(@"C:\Users\bruno.rocha\Desktop\ProjectsBruno\CodeWarsSolutions\CodeWarsSolutions\SevenKyu\BitwiseEvenCheck.cs");
            Assert.IsFalse(text.Contains("%"));
        }

        [TestCase(true, 2)]
        [TestCase(false, 3)]
        [TestCase(true, 14)]
        [TestCase(false, 15)]
        [TestCase(true, 26)]
        [TestCase(false, 27)]
        public void IsEven_CalledWithAnyInt_ReturnsCorrectResult(bool expected, int n)
        {
            var message = $"{n} is ";
            message += expected ? "even" : "odd";
            Assert.AreEqual(expected, BitwiseEvenCheck.IsEven(n), message);
        }
    }
}
