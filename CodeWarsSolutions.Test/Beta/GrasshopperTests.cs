using CodeWarsSolutions.Beta;
using NUnit.Framework;
using System;

namespace CodeWarsSolutions.Tests.Beta
{
    [TestFixture]
    public class GrasshopperTests
    {

        Grasshopper sut;
      
        [Test]
        [Ignore("Not Fully implemented")]
        public void GrasshopperTests_EatAndHopLeft1b_Dictionary()
        {
            int n = 10000000;
            sut = new Grasshopper(n, n - 3);
            Console.WriteLine(sut.WhereAmI());


            for (int i = 0; i < n / 11; i++)
            {
                sut.EatAndHopLeft();
                sut.EatAndHopLeft();
                sut.EatAndHopLeft();
                sut.EatAndHopLeft();
                sut.EatAndHopLeft();
                //Console.WriteLine(g.WhereAmI());
            }
            Assert.AreNotEqual(null, sut.WhereAmI());
            
        }
    }
}
