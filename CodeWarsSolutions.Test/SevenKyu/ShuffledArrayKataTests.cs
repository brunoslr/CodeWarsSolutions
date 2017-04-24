using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Test.SevenKyu
{   
    [TestFixture]
    class ShuffledArrayKataTests
    {
        ShuffledArrayKata sut;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            sut = new ShuffledArrayKata();
        }     
            
        [TestCase(new int[] { 1, 12, 3, 6, 2 }, new int[] { 1, 2, 3, 6 })]
        [TestCase(new int[] { 1, -3, -5, 7, 2 }, new int[] { -5, -3, 2, 7 })]
        [TestCase(new int[] { 2, -1, 2, 2, -1 }, new int[] { -1, -1, 2, 2 })]
        [TestCase(new int[] { -3, -3 }, new int[] { -3 })]
        public void ShuffledArrayBasicTests(int[] input, int[] expected)
        {
            Assert.AreEqual(expected, sut.ShuffledArray(input));
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            sut = null;
        }
    }
}
