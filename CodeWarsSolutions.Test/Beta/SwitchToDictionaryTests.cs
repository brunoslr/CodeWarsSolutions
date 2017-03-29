using CodeWarsSolutions.Beta;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CodeWarsSolutions.Test.Beta
{


    [TestFixture]
    public class SwitchToDictionatyTests
    {
        [Test]
        public void StatusCorrect()
        {
            Assert.AreEqual("I have never been set", new SwitchToDictionary().GetStatusDescription());
            Assert.AreEqual("I am new!", new SwitchToDictionary(Status.New).GetStatusDescription());
            Assert.AreEqual("I am active", new SwitchToDictionary(Status.Active).GetStatusDescription());
            Assert.AreEqual("I have been deactivated", new SwitchToDictionary(Status.Deactivated).GetStatusDescription());
        }

        [Test]
        public void InvalidStatus()
        {
            var kata = new SwitchToDictionary((Status)4);
            Assert.Throws<InvalidOperationException>(() => kata.GetStatusDescription());
        }

        [Test]
        public void HasDictionary()
        {
            Type type = typeof(SwitchToDictionary);
            FieldInfo field = type.GetField("_statusDescriptions", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(field);
            Type fieldType = field.FieldType;
            Assert.AreEqual(fieldType, typeof(Dictionary<Status, string>));
        }

    }
}
