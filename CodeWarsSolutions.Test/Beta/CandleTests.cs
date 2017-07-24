using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeWarsSolutions.Beta;
using NUnit;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.Beta
{
    [TestFixture]
    class CandleTests
    {
        [Test]
        public void CandleBasicTest()
        {
            Assert.AreEqual(9, CandleKata.Candles(5, 2));

            Assert.AreEqual(1, CandleKata.Candles(1, 2));

            Assert.AreEqual(4, CandleKata.Candles(3, 3));

            Assert.AreEqual(16, CandleKata.Candles(11, 3));

        }
    }
}

