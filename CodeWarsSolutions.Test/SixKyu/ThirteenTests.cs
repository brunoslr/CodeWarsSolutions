using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Test.SixKyu
{
  
    using System;
    using NUnit.Framework;
    using CodeWarsSolutions.SixKyu;

    [TestFixture]
    public static class ThirteenTests
    {

        private static void TestingThirt(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void TestThirt()
        {
            Console.WriteLine("Testing Thirt");
            TestingThirt(Thirteen.Thirt(8529), 79);
            TestingThirt(Thirteen.Thirt(85299258), 31);
            TestingThirt(Thirteen.Thirt(5634), 57);
            TestingThirt(Thirteen.Thirt(1111111111), 71);
            TestingThirt(Thirteen.Thirt(987654321), 30);
        }
    }
}

