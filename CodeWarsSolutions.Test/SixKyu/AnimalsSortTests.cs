using NUnit.Framework;
using System.Collections.Generic;
using CodeWarsSolutions.SixKyu;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    public class AnimalsSortTests
    {
        [Test]
        public void SortTest()
        {
            var animals = new List<Animal>
              {
                new Animal {Name = "Cat", NumberOfLegs = 4},
                new Animal {Name = "Snake", NumberOfLegs = 0},
                new Animal {Name = "Dog", NumberOfLegs = 4},
                new Animal {Name = "Pig", NumberOfLegs = 4},
                new Animal {Name = "Human", NumberOfLegs = 2},
                new Animal {Name = "Bird", NumberOfLegs = 2}
              };
            var output = new AnimalSorter().Sort(animals);
            Assert.AreEqual(output[0].Name, "Snake");
            Assert.AreEqual(output[3].Name, "Cat");
        }
    }
}

