/* URL:https://www.codewars.com/kata/multiples-of-3-and-5/train/csharp
 If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

Note: If the number is a multiple of both 3 and 5, only count it once.
Courtesy of ProjectEuler.net
 */
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    class MultiplesOfFiveandThree
    {
        public static int Solution(int value)
        {
            if (value < 3) return 0;
            return Enumerable.Range(1, value - 1).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
