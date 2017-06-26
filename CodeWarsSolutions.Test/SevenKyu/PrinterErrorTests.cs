using System;
using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;


namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    class PrinterErrorTests
    {
        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing PrinterError");
            string s = "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz";
            Assert.AreEqual("3/56", PrinterErrorsClass.PrinterError(s));
        }
    }
}
