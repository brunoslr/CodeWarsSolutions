
/* URL https://www.codewars.com/kata/two-sum/csharp
 Write a function that takes an array of numbers (integers for the tests) and a target number. It should find two different items in the array that, when added together, give the target value. The indices of these items should then be returned in an array like so: [index1, index2].

For the purposes of this kata, some tests may have multiple answers; any valid solutions will be accepted.

The input will always be valid (numbers will be an array of length 2 or greater, and all of the items will be numbers; target will always be the sum of two different items from that array).

Based on: http://oj.leetcode.com/problems/two-sum/
FUNDAMENTALSARRAYSNUMBERSINTEGERSARITHMETICMATHEMATICSALGORITHMS
 */
using System;
using System.Linq;
namespace CodeWarsSolutions.SixKyu
{

    public class TwoSumClass
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            var validOne = numbers.Where((x, i) => Array.IndexOf(numbers, target - x) != -1).Last();

            Console.WriteLine(String.Concat(validOne));

            int first = 0;
            int second = 0;

            first = Array.IndexOf(numbers, target - validOne);

            if (target - validOne == validOne)
            {
                for (int i = first + 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == validOne)
                    {
                        second = i;
                        break;
                    }
                }
            }
            else
            {
                second = Array.IndexOf(numbers, validOne);
            }
            return new int[2] { first, second };
        }
    }
}
