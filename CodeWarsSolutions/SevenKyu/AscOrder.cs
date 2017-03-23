/* URL:https://www.codewars.com/kata/are-the-numbers-in-order/train/csharp
 Are the numbers in order?

In this Kata, your function receives an array of positive integers as input. Your task is to determine whether the numbers are in ascending order.

For the purposes of this Kata, you may assume that all inputs are valid (i.e. arrays containing only positive integers with a length of at least 2).

For example:

Kata.IsAscOrder(new int[]{1,2,4,7,19}) == true
Kata.IsAscOrder(new int[]{1,2,3,4,5}) == true
Kata.IsAscOrder(new int[]{1,6,10,18,2,4,20}) == false
Kata.IsAscOrder(new int[]{9,8,7,6,5,4,3,2,1}) == false // numbers are in DESCENDING order
Extra Challenge: If time, try to optimise and shorten your code as much as possible.
 */

using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public class AscOrder
    {
        public static bool IsAscOrder(int[] arr) => arr.SequenceEqual(arr.OrderBy(x => x));
    }
}
