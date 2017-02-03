/*URL: https://www.codewars.com/kata/sum-of-all-the-multiples-of-3-or-5/train/csharp
Write the function findSum.
Upto and including n, this function will return the sum of all multiples of 3 and 5.
Ex:
findSum(5) should return 8 (3 + 5)
findSum(10) should return 33 (3 + 5 + 6 + 9 + 10)
*/
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public class SumofMultiples
    {
        public static int findSum(int n)
        {
            return Enumerable.Range(1, n).Sum(x => (x % 3 == 0 || x % 5 == 0) ? x : 0);
        }
    }
    
}
