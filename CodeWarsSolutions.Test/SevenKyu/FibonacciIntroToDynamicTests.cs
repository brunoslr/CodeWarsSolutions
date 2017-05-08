using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    class FibonacciIntroToDynamicTests
    { 
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void MyTest()
            {
                Assert.AreEqual(5, FibonacciIntroToDynamic.fib(5));
                Assert.AreEqual(55, FibonacciIntroToDynamic.fib(10));
            }
        }
    }
}
