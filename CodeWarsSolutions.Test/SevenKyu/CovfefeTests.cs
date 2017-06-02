using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;


namespace CodeWarsSolutions.Test.SevenKyu
{

    [TestFixture]
    public class CovfefeTests
    {

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(CovfefeClass.Covfefe("coverage"), "covfefe");
            Assert.AreEqual(CovfefeClass.Covfefe("coverage coverage"), "covfefe covfefe");
            Assert.AreEqual(CovfefeClass.Covfefe("nothing"), "nothing covfefe");
            Assert.AreEqual(CovfefeClass.Covfefe("double space "), "double space  covfefe");
            Assert.AreEqual(CovfefeClass.Covfefe("covfefe"), "covfefe covfefe");
            Assert.AreEqual(CovfefeClass.Covfefe(""), " covfefe");
        }

    }
}
