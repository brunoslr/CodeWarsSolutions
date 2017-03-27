using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Test.Beta
{
    using CodeWarsSolutions.Beta;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DoublyNotLessTests
    {

        [Test]
        public void BasicTests()
        {
            var kata = new DoublyNotLessKata();

            Assert.AreEqual("5316", kata.DoublyNotLess("5314"));

            Assert.AreEqual("23456", kata.DoublyNotLess("23456"));

            Assert.AreEqual("65437", kata.DoublyNotLess("65432"));

            Assert.AreEqual("9998788999", kata.DoublyNotLess("9998786543"));

            Assert.AreEqual("1", kata.DoublyNotLess("1"));

            Assert.AreEqual("1102", kata.DoublyNotLess("1101"));

            Assert.AreEqual("9999999999999999999999999", kata.DoublyNotLess("9999999999999999999999999"));

            Assert.AreEqual("99999999999999999999888888888888877777777777777777766666666666655555555555999999999999999999999", kata.DoublyNotLess("99999999999999999999888888888888877777777777777777766666666666655555555555555555444444444444444"));

            Assert.AreEqual("569735847563478256235634859346578345634895736459346778", kata.DoublyNotLess("569735847563478256235634859346578345634895736459346778"));

            Assert.AreEqual("8998989898989889898989898989989899", kata.DoublyNotLess("8998989898989889898989898989989899"));

        }

    }
}
