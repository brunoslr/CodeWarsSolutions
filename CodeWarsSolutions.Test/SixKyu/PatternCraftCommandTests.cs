using NUnit.Framework;
using CodeWarsSolutions.SixKyu;

namespace CodeWarsSolutions.Test.SixKyu
{


    [TestFixture]
    public class PatternCraftCommandsTests
    {
        [Test]
        public void _0_MoveCommand_Should_Move_Unit()
        {
            var unit = new Probe();
            var moveCommand = new MoveCommand(unit, 7, 9);

            moveCommand.Execute();

            var expected = new Point { X = 7, Y = 9 };

            Assert.AreEqual(expected.X, unit.Position.X);
            Assert.AreEqual(expected.Y, unit.Position.Y);
        }

        [Test]
        public void _1_GatherCommand_Should_Gather_Resources()
        {
            var unit = new Probe();
            var gatherCommand = new GatherCommand(unit);

            gatherCommand.Execute();

            Assert.AreEqual(5, unit.Minerals);
        }

        [Test]
        public void _2_GatherCommand_Should_Only_Gather_Resources_If_Minerals_Equal_0()
        {
            var unit = new Probe();
            var gatherCommand = new GatherCommand(unit);

            Assert.AreEqual(0, unit.Minerals);

            gatherCommand.Execute();

            Assert.AreEqual(5, unit.Minerals);

            unit.Minerals = 6;

            gatherCommand.Execute();

            Assert.IsTrue(unit.Minerals == 6, "you should increment only when it can execute");
        }
    }
}
