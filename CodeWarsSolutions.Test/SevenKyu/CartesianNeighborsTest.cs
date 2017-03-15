using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    
[TestFixture]
    public class CartesianNeighborsTest
{

    [Test]
    public void ExampleTests()
    {
        var r = new List<int[]>{
          new int[]{1,1},
          new int[]{1,2},
          new int[]{1,3},
          new int[]{2,1},
          new int[]{2,3},
          new int[]{3,1},
          new int[]{3,2},
          new int[]{3,3},
    };
            Assert.AreEqual(r, CartesianNeighbors.cartesianNeighbor(2, 2).OrderBy(s=>s[0]).ThenBy(s=>s[1]));
        }
    }
}
