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

        Despachante sut;
        Random rdn;

        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new Despachante();
            rdn = new Random();
        }

        [Test]
        public void RunDispatcher()
        {

            sut.AlocarTrabalhador(1).EfetuarTarefa("Task11");
            sut.AlocarTrabalhador(2).EfetuarTarefa("Task21");
            Debug.WriteLine(string.Join(", ", sut.AlocarTrabalhador(2).Tarefas));
            sut.LiberarTrabalhador(2);
            sut.AlocarTrabalhador(1).EfetuarTarefa("Task12");
            Debug.WriteLine(string.Join(", ", sut.AlocarTrabalhador(1).Tarefas));
            sut.LiberarTrabalhador(1);

            Assert.That(sut.Trabalhadores.Count(), Is.EqualTo(0));
        }

        [Test]
        public void RunDispatcherMain()
        {

            Despachante.DispatcherMain(new string[] {"","" });
            

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
