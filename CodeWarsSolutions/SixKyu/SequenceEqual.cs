/* URL: https://www.codewars.com/kata/are-they-the-same/train/csharp
 * Given two arrays a and b write a function comp(a, b)  
 * that checks whether the two arrays have the "same" elements, with the same multiplicities. 
 * "Same" means, here, that the elements in b are the elements in a squared, regardless of the order.
 */
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    class SequenceEqual
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null) return false;

            return a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }
    }
}
