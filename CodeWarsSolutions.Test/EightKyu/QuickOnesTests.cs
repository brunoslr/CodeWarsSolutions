using CodeWarsSolutions.EightKyu;
using NUnit.Framework;
using System;

namespace CodeWarsSolutions.Test.EightKyu
{
    [TestFixture]
    public static class RemoveExclamationMarkTests
    {
        [TestCase("", "", "Input: Empty string")]
        [TestCase("!", "", "Input: !")]
        [TestCase("!!", "", "Input: !!")]
        [TestCase("Hi!", "Hi", "Input: Hi!")]
        [TestCase("!?!", "?", "Input: !?!")]
        [TestCase("NoExclamation", "NoExclamation", "Input: NoExclamation")]
        [Category("EightKyu")]
        public static void MyTests(string input, string expected,string message)
        {
            Assert.AreEqual(expected, RemoveExclamationMark.RemoveExclamationMarks(input), message);
        }
    }

    [TestFixture]
    public class SpacesRemoverTests
    {
        [Test]
        public void SpacesRemoverBasicTests()
        {
            Assert.AreEqual("8j8mBliB8gimjB8B8jlB", SpacesRemover.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));
            Assert.AreEqual("88Bifk8hB8BB8BBBB888chl8BhBfd", SpacesRemover.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
            Assert.AreEqual("8aaaaaddddr", SpacesRemover.NoSpace("8aaaaa dddd r     "));
        }
    }

    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(540, ArrayMath.Product(new int[] { 5, 4, 1, 3, 9 }));
            Assert.AreEqual(-672, ArrayMath.Product(new int[] { -2, 6, 7, 8 }));
            Assert.AreEqual(10, ArrayMath.Product(new int[] { 10 }));
            Assert.AreEqual(0, ArrayMath.Product(new int[] { 0, 2, 9, 7 }));
        }

        [Test]
        public void ArgumentNullTest()
        {
            Assert.Throws<ArgumentNullException>(() => ArrayMath.Product(null));
        }

        [Test]
         public void InvalidOperationTest()
        {
            Assert.Throws<InvalidOperationException>(() => ArrayMath.Product(new int[] { }));
        }

        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, SortingKata.SortByLength(new string[] { "Beg", "Life", "To", "I" }));
            Assert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, SortingKata.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
            Assert.AreEqual(new string[] { "Short", "Longer", "Longest" }, SortingKata.SortByLength(new string[] { "Longer", "Longest", "Short" }));
        }

    }

}
