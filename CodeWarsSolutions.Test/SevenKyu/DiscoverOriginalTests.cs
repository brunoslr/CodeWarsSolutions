using System;
using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    
    [TestFixture]
    class DiscoverOriginalTests
    {
        [Test]
        public void GivenDiscount75Rate25Returns100()
        {
            Assert.AreEqual(100.00M, DiscoverOriginal.DiscoverOriginalPrice(75M, 25M));
        }
    }
}
