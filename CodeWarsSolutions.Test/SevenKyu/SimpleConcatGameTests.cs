using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{

    [TestFixture]
    public class SimpleConcatGameTests
    {
        [Test]
        public void ReverLongerTest_1()
        {
            try
            {
                string input_a = "first";
                string input_b = "abcde";
                string expected = "abcdetsrifabcde";

                string actual = SimpleConcatGame.ShorterReverseLonger(input_a, input_b);

                Assert.AreEqual(expected, actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
            }
        }

        [Test]
        public void ReverLongerTest_2()
        {
            try
            {
                string input_a = "hello";
                string input_b = "bau";
                string expected = "bauollehbau";

                string actual = SimpleConcatGame.ShorterReverseLonger(input_a, input_b);

                Assert.AreEqual(expected, actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
            }
        }

        [Test]
        public void ReverLongerTest_3()
        {
            try
            {
                string input_a = "abcde";
                string input_b = "fghi";
                string expected = "fghiedcbafghi";

                string actual = SimpleConcatGame.ShorterReverseLonger(input_a, input_b);

                Assert.AreEqual(expected, actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
            }
        }
    }
}
