using System;
using NUnit.Framework;
using CodeWarsSolutions.SixKyu;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    public class StrategyPatternBirdBehaviorTests
    {
        public void DuckTest(Duck d,
                             bool validQuackBehavior, bool validFlyBehavior,
                             string expectedQuack, string expectedFly)
        {
            Assert.AreEqual(expectedQuack, d.Quack(), "Expected for Quack: " + expectedQuack + "\n" +
                                                      "But was: " + d.Quack());
            Assert.AreEqual(expectedFly, d.Fly(), "Expected for Fly: " + expectedFly + "\n" +
                                                  "But was: " + d.Fly());

            if (validQuackBehavior)
                Assert.IsNotNull(d.QuackBehavior, d.GetType().ToString() + "'s quack behavior shouldn't be null!");

            if (validFlyBehavior)
                Assert.IsNotNull(d.FlyBehavior, d.GetType().ToString() + "'s fly behavior shouldn't be null!");
        }

        [Test]
        public void Test1()
        {
            Duck mallard = new MallardDuck();
            Duck goose = new Goose();
            Duck rubber = new RubberDuck();
            Duck rocket = new RocketDuck5000();

            DuckTest(mallard, true, true, "Quack!", "Flap!");
            DuckTest(goose, true, true, "Honk!", "Flap!");
            DuckTest(rubber, true, false, "Squeak!", null);
            DuckTest(rocket, true, true, "Greetings human!", "Rocket boosters activated.\n" +
                                                               "Ignition...\n" +
                                                               "3...\n" +
                                                               "2...\n" +
                                                               "1...\n" +
                                                               "Liftoff!");
        }
    }
}
