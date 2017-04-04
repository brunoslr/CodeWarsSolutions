﻿using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;
using System;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    public class SortByValueIndexTests
    {   
        [Test]
        public void SortByValueIndexBasicTest()
        {
            var actual = SortByValueIndex.SortByValueAndIndex(new int[] { 1, 2, 3, 4, 5 });
            var expected = new int[] { 1, 2, 3, 4, 5 };
            var message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
            Assert.AreEqual(expected, actual, message);

            actual = SortByValueIndex.SortByValueAndIndex(new int[] { 23, 2, 3, 4, 5 });
            expected = new int[] { 2, 3, 4, 23, 5 };
            message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
            Assert.AreEqual(expected, actual, message);

            actual = SortByValueIndex.SortByValueAndIndex(new int[] { 26, 2, 3, 4, 5 });
            expected = new int[] { 2, 3, 4, 5, 26 };
            message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
            Assert.AreEqual(expected, actual, message);

            actual = SortByValueIndex.SortByValueAndIndex(new int[] { 9, 5, 1, 4, 3 });
            expected = new int[] { 1, 9, 5, 3, 4 };
            message = "Your result:\n" + ArrayToString(actual) + "\n\nExpected result:\n" + ArrayToString(expected);
            Assert.AreEqual(expected, actual, message);
        }

        private String ArrayToString(int[] array)
        {
            return String.Join(", ", array);
        }
    }
}

