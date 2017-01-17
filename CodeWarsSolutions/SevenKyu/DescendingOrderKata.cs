/* URL https://www.codewars.com/kata/descending-order/train/csharp
 * Your task is to make a function that can take any non-negative integer as a argument and return it with it's digits in descending order. Descending order means that you take the highest digit and place the next highest digit immediately after it.
    Examples:

Input: 145263 Output: 654321
Input: 1254859723 Output: 9875543221       */

using System;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public static class DescendingOrderKata
    {
        public static int DescendingOrder(int num)
        {
            return Int32.Parse(String.Join("", num.ToString().OrderByDescending(x => x)));
        }
    }
}
