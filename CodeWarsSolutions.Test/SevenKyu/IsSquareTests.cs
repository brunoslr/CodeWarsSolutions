using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Test.SevenKyu
{
    using System;
    using NUnit.Framework;
    using CodeWarsSolutions.SevenKyu;

    [TestFixture]
    public class IsSquareTests
    {
        [TestCase(false, -1, "negative numbers aren't square numbers")]
        [TestCase(false, 3, "3 isn't a square number")]
        [TestCase(true, 4, "4 is a square number")]
        [TestCase(true, 625, "625 is a square number")]
        [TestCase(false, 26, "26 isn't a square number")]
        public static void ShouldWorkForSomeExamples(bool expect, int input, string message)
        {
            Assert.AreEqual(expect,IsSquare.IsSquareRoot(input),message);
           
        }
    }
}
