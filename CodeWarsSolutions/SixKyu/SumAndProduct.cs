/* URL: https://www.codewars.com/kata/find-two-doubles-for-the-given-sum-and-product/train/csharp
 * Write a method, which takes two doubles, sum and product, and returns two doubles (in a Tuple<double, double>) so x1 + x2 == sum and x1 * x2 == product.

In case there are no two doubles to fulfill the above criteria, return null.

It's allowed to return two doubles which are exactly the same.

Some examples:

Input: 4 (sum), 4 (product), output: 2, 2
Input: 8 (sum), 15 (product), output: 3, 5
Input: 9.05 (sum), 9.85 (product), output: 1.25, 7.8.
Input: -4 (sum), 4 (product), output: -2, -2.
Input: 2 (sum), 7/3 (product), output: null.
 */

using System;

namespace CodeWarsSolutions.SixKyu
{

    class SumAndProduct
    {
        public static Tuple<double, double> FindDoubles(double sum, double product)
        {
            /* x1 + x2 = sum => x2 = sum - x1
              * x1 * x2 = product; x1 * (sum - x1) = product;
              * -x1^2 + sum x1 - product = 0;
              * x1 = +-sum * sqrt(sum^2 - 4*product) / 2
              * By pilisera
              */

            var x1 = (sum + Math.Sqrt(sum * sum - 4 * product)) / 2;
            var x2 = sum - x1;

            if (double.IsNaN(x1))
            {
                return null;
            }

            return new Tuple<double, double>(x1, x2);
        }

    }
}
