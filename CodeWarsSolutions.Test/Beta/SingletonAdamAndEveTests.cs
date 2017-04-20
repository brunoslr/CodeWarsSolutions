using CodeWarsSolutions.Beta;
using NUnit.Framework;
using System;
using System.Linq;

namespace CodeWarsSolutions.Test.Beta
{
     
    [TestFixture]
    public class SingletonAdamAndEveTests
        {
        [Test]
        public void Adam_is_unique()
        {
            Adam adam = Adam.GetInstance();
            Adam anotherAdam = Adam.GetInstance();
            Assert.AreEqual(adam, anotherAdam);
        }

        // Implement all the tests below one by one!


        public void Adam_has_no_public_constructor()
        {
            Assert.IsFalse(typeof(Adam).GetConstructors().Any(x => x.IsPublic));
        }

        public void Adam_cannot_be_overriden()
        {
            Assert.IsTrue(typeof(Adam).IsSealed);
        }

        [Test]
        public void Adam_is_a_human()
        {
            Assert.IsTrue(Adam.GetInstance() is Human);
        }

        [Test]
        public void Adam_is_a_male()
        {
            Assert.IsTrue(Adam.GetInstance() is Male);
        }

        [Test]
        public void Eve_is_unique()
        {
            Adam adam = Adam.GetInstance();
            Eve eve = Eve.GetInstance(adam);
            Eve anotherEve = Eve.GetInstance(adam);
            Assert.AreEqual(eve, anotherEve);

            // Eve has no public constructor nor can Eve be overriden
            Assert.IsFalse(typeof(Eve).GetConstructors().Any(x => x.IsPublic));
            Assert.IsTrue(typeof(Eve).IsSealed);
        }

        [Test]
        public void Eve_is_a_human()
        {
            Assert.IsTrue(Eve.GetInstance(Adam.GetInstance()) is Human);
        }

        [Test]
        public void Eve_is_a_female()
        {
            Assert.IsTrue(Eve.GetInstance(Adam.GetInstance()) is Female); ;
        }

        [Test]
        public void Reproduction_always_result_in_a_male_or_female()
        {
            Assert.IsTrue(typeof(Human).IsAbstract);
        }

        [Test]
        public void Human_can_reproduce_when_they_have_a_mother_and_father_and_have_a_name()
        {
            var adam = Adam.GetInstance();
            var eve = Eve.GetInstance(adam);
            var seth = new Male("Seth", eve, adam);
            var azura = new Female("Azura", eve, adam);
            var enos = new Male("Enos", azura, seth);

            Assert.AreEqual("Eve", eve.Name);
            Assert.AreEqual("Adam", adam.Name);
            Assert.AreEqual("Seth", seth.Name);
            Assert.AreEqual("Azura", azura.Name);
            Assert.AreEqual("Enos", ((Human)enos).Name);
            Assert.AreEqual(seth, ((Human)enos).Father);
            Assert.AreEqual(azura, ((Human)enos).Mother);
        }

        [Test]
        public void Father_and_mother_are_essential_for_reproduction()
        {
            // There is just 1 way to reproduce 
            Assert.AreEqual(1, typeof(Male).GetConstructors().Where(x => x.IsPublic).Count());
            Assert.AreEqual(1, typeof(Female).GetConstructors().Where(x => x.IsPublic).Count());

            var adam = Adam.GetInstance();
            var eve = Eve.GetInstance(adam);
            Assert.Throws<ArgumentNullException>(() => new Male("Seth", null, null));
            Assert.Throws<ArgumentNullException>(() => new Male("Abel", eve, null));
            Assert.Throws<ArgumentNullException>(() => new Male("Seth", null, adam));
            Assert.Throws<ArgumentNullException>(() => new Female("Azura", null, null));
            Assert.Throws<ArgumentNullException>(() => new Female("Awan", eve, null));
            Assert.Throws<ArgumentNullException>(() => new Female("Dina", null, adam));
            Assert.Throws<ArgumentNullException>(() => new Female("Eve", null, null));
            Assert.Throws<ArgumentNullException>(() => new Male("Adam", null, null));
        }

    }
}
