using CodeWarsSolutions.Beta;
using NUnit.Framework;
using System.Diagnostics;

namespace CodeWarsSolutions.Tests.Beta
{
    [TestFixture]
    public class GriloTests
    {

        Grilo _sut;
      
        [TestCase(5000)]
        [TestCase(50000)]
        [TestCase(500000)]
        [TestCase(5000000)]
        public void EatAndHopLeft1b_Dictionary(int input)
        {
            int n = input;
            Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            _sut = new Grilo(n, n - 3);
            for (int i = 0; i < n / 11; i++)
            {
                _sut.ComerEPularEsquerda();
                _sut.ComerEPularEsquerda();
                _sut.ComerEPularEsquerda();
                _sut.ComerEPularEsquerda();
                _sut.ComerEPularEsquerda();
            }
            timer.Stop();
            bool executionTimeLessThanFiveSeconds = (timer.ElapsedMilliseconds < 5000);
            Assert.IsTrue(executionTimeLessThanFiveSeconds, "Should take less than five seconds");
            
        }

        [Test]
         public void Grilo_WhereAmI()
        {
            _sut = new Grilo(20, 10);
                _sut.ComerEPularEsquerda();
                _sut.ComerEPularEsquerda();
                _sut.ComerEPularDireita();
                _sut.ComerEPularEsquerda();
                _sut.ComerEPularEsquerda();
            Assert.AreEqual(3,_sut.OndeEstou() ,"Should take less than five seconds");

        }

    }
}
