using CodeWarsSolutions.Beta;
using NUnit.Framework;
using System.Diagnostics;

namespace CodeWarsSolutions.Tests.Beta
{
    [TestFixture]
    public class GrasshopperTests
    {

        Grasshopper sut;
      
        [TestCase(5000)]
        [TestCase(50000)]
        [TestCase(500000)]
        [TestCase(5000000)]
        public void GrasshopperTests_EatAndHopLeft1b_Dictionary(int input)
        {
            int n = input;
            Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            sut = new Grasshopper(n, n - 3);
            for (int i = 0; i < n / 11; i++)
            {
                sut.EatAndHopLeft();
                sut.EatAndHopLeft();
                sut.EatAndHopLeft();
                sut.EatAndHopLeft();
                sut.EatAndHopLeft();
            }
            timer.Stop();
            bool ExecutionTimeLessThanFiveSeconds = (timer.ElapsedMilliseconds < 5000);
            Assert.IsTrue(ExecutionTimeLessThanFiveSeconds, "Should take less than five seconds");
            
        }
    }
}
