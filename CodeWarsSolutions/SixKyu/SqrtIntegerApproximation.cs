/* URL:https://www.codewars.com/kata/sqrt-approximation/train/csharp
We want to approximate the sqrt function. Usually this functions takes a floating point number and returns another floating point number, but in this kata we're going to work with integral numbers instead.
Your task is to write a function that takes an integer n and returns either
an integer k if n is a square number, such that k * k == n or
a range (k, k+1), such that k * k < n and n < (k+1) * (k+1).
Examples
Assert.AreEqual(2, Kata.SqrtApproximation(4));
Assert.AreEqual(new int[] { 2,3 }, Kata.SqrtApproximation(5));
Note : pow()```` andsqrt()``` functions are disabled.
Remarks
In dynamic languages, return either a single value or an array/list. In Haskell, use Either.
 */

namespace CodeWarsSolutions.SixKyu
{
    public class SqrtIntegerApproximation
    {
        public static object SqrtApproximation(int number)
        {
            int rtApprox = 0;
            while (rtApprox * rtApprox < number) rtApprox++;

            return rtApprox * rtApprox == number ? (object)rtApprox :
                (object)new int[] { rtApprox - 1, rtApprox };
        }
    }
}
