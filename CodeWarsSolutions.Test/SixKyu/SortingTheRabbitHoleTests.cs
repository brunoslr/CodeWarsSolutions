using NUnit.Framework;
using CodeWarsSolutions.SixKyu;
using System.Collections.Generic;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    class SortingTheRabbitHoleTests
    {
        [Test]
        public void BasicTests()
        {
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 1, 2, 3, 4 }, true), new object[] { 1, 2, 3, 4 });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 1, 2, 3, 4 }), new object[] { 4, 3, 2, 1 });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 2, new object[] { 1, 1 }, new object[] { 1, 1 }, 2 }, true), new object[] { 2, new object[] { 1, 1 }, new object[] { 1, 1 }, 2 });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 1, 2, 3, 4, new object[] { -5, -4 } }, true), new object[] { new object[] { -5, -4 }, 1, 2, 3, 4 });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 1, 2, 3, 4, new object[] { -5, -4 } }), new object[] { 4, 3, 2, 1, new object[] { -4, -5 } });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 1, new object[] { 2, 3, new object[] { 4, 5, new object[] { 9, 11 }, 1, 8 }, 6 }, new object[] { 20, 7, 8 } }, true), new object[] { 1, new object[] { 7, 8, 20 }, new object[] { 2, 3, 6, new object[] { 1, 4, 5, 8, new object[] { 9, 11 } } } });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 1, new object[] { 2, 3, new object[] { 4, 5, new object[] { 9, 11 }, 1, 8 }, 6 }, new object[] { 20, 7, 8 } }), new object[] { new object[] { new object[] { new object[] { 11, 9 }, 8, 5, 4, 1 }, 6, 3, 2 }, new object[] { 20, 8, 7 }, 1 });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 1, new object[] { 2, 4 }, 3, 8, new object[] { 6, 6, new object[] { 3, 3, new object[] { 5, new object[] { 8, 9, 0, new object[] { 12, new object[] { 11, 11, new object[] { 1 } } } } } } }, -1, new object[] { 80, 12 } }, true), new object[] { -1, 1, 3, new object[] { 2, 4 }, 8, new object[] { 6, 6, new object[] { 3, 3, new object[] { 5, new object[] { 0, 8, 9, new object[] { 12, new object[] { new object[] { 1 }, 11, 11 } } } } } }, new object[] { 12, 80 } });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 1, new object[] { 2, 4 }, 3, 8, new object[] { 6, 6, new object[] { 3, 3, new object[] { 5, new object[] { 8, 9, 0, new object[] { 12, new object[] { 11, 11, new object[] { 1 } } } } } } }, -1, new object[] { 80, 12 } }), new object[] { new object[] { 80, 12 }, new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { 11, 11, new object[] { 1 } }, 12 }, 9, 8, 0 }, 5 }, 3, 3 }, 6, 6 }, 8, new object[] { 4, 2 }, 3, 1, -1 });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { new object[] { 4, 2, 7 }, new object[] { 7, 2, 4 }, new object[] { 2, 4, 7 } }, true), new object[] { new object[] { 2, 4, 7 }, new object[] { 2, 4, 7 }, new object[] { 2, 4, 7 } });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { new object[] { 4, 2, 7 }, new object[] { 7, 2, 4 }, new object[] { 2, 4, 7 } }), new object[] { new object[] { 7, 4, 2 }, new object[] { 7, 4, 2 }, new object[] { 7, 4, 2 } });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 86, new object[] { 33, 8, new object[] { 9, 4, 4, 3, new object[] { 1, 2, 3 } }, 5, 5, new object[] { 77, 1, -1, new object[] { -5, -6, -7 }, new object[] { 56, 65, 43 } } } }, true), new object[] { 86, new object[] { 5, 5, 8, new object[] { 3, 4, 4, new object[] { 1, 2, 3 }, 9 }, 33, new object[] { new object[] { -7, -6, -5 }, -1, 1, 77, new object[] { 43, 56, 65 } } } });
            TestWithVisualization(SortingTheRabbitHole.DeepSort(new object[] { 86, new object[] { 33, 8, new object[] { 9, 4, 4, 3, new object[] { 1, 2, 3 } }, 5, 5, new object[] { 77, 1, -1, new object[] { -5, -6, -7 }, new object[] { 56, 65, 43 } } } }, false), new object[] { new object[] { new object[] { new object[] { 65, 56, 43 }, 77, 1, -1, new object[] { -5, -6, -7 } }, 33, new object[] { 9, new object[] { 3, 2, 1 }, 4, 4, 3 }, 8, 5, 5 }, 86 });
        }

        private static void TestWithVisualization(object[] actual, object[] expected)
        {
            Assert.AreEqual(ArrayToString(expected), ArrayToString(actual));
        }

        private static string ArrayToString(object[] array)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].GetType().IsArray)
                {
                    list.Add(ArrayToString((object[])array[i]));
                }
                else
                {
                    list.Add(array[i].ToString());
                }
            }
            return "[" + string.Join(", ", list) + "]";
        }
    }
}

