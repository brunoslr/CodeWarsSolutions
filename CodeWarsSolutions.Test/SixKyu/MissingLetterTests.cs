using CodeWarsSolutions.SixKyu;
using NUnit.Framework;


namespace CodeWarsSolutions.Test.SixKyu
{
    class MissingLetterTests
    {
           
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual('e', MissingLetter.FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
            Assert.AreEqual('P', MissingLetter.FindMissingLetter(new[] { 'O', 'Q', 'R', 'S' }));
        }
    }

}
