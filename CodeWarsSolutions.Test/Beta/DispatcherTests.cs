using CodeWarsSolutions.Beta;
using NUnit.Framework;
using System;
using System.Linq;
using System.Diagnostics;

namespace CodeWarsSolutions.Tests.Beta
{
    [TestFixture]
    public class DispatcherTests
    {

        Dispatcher sut;
        Random rdn;

        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new Dispatcher();
            rdn = new Random();
        }

        [Test]
        public void RunDispatcher()
        {

            sut.AcquireWorker(1).PerformTask("Task11");
            sut.AcquireWorker(2).PerformTask("Task21");
            Debug.WriteLine(string.Join(", ", sut.AcquireWorker(2).Tasks));
            sut.ReleaseWorker(2);
            sut.AcquireWorker(1).PerformTask("Task12");
            Debug.WriteLine(string.Join(", ", sut.AcquireWorker(1).Tasks));
            sut.ReleaseWorker(1);

            Assert.That(sut.Workers.Count(), Is.EqualTo(0));
        }

        [Test]
        public void RunDispatcherMain()
        {

            Dispatcher.DispatcherMain(new string[] {"","" });
            

            Assert.True(true);
        }


        [OneTimeTearDown]
        public void TestTearDown()
        {
            sut = null;
            rdn = null;
        }
    }
}
