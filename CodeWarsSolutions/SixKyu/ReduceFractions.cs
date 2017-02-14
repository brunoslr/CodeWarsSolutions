/* URL: https://www.codewars.com/kata/irreducible-sum-of-rationals/train/csharp
 You will have a list of rationals in the form

m = [ [numer_1, denom_1] , ... , [numer_n, denom_n] ] or m = [ (numer_1, denom_1) , ... , (numer_n, denom_n) ]

where all numbers are positive integers. You have to produce the sum N/D of these rationals in an irreducible form ie N and D have only 1 for divisor.

The result will be written in the form

[N, D] in Ruby/Python/Clojure/JS/CS/PHP
Just "N D" in Haskell or Some "N D" in F#
Some((N, D)) in Rust
"[N, D]" in Java, CSharp, TS
{N, D} in C++
{N, D} in Elixir
Example:

[ [1, 2], [1, 3], [1, 4] ] ----> "[13, 12]" 

 */

namespace CodeWarsSolutions.SixKyu
{
    public class ReduceFractions
    {
        public static string SumFracts(int[,] l)
        {
            if (l == null || l.GetLength(0) == 0)
                return null;

            long divisor = 1;
            long dividend = 0;
            int maxDivisor = 1;

            for (int i = 0; i < l.GetLength(0); i++)
            {
                if (l[i, 1] > maxDivisor)
                    maxDivisor = l[i, 1];

                divisor *= l[i, 1];
            }

            for (int i = 0; i < l.GetLength(0); i++)
            {
                dividend += l[i, 0] * (divisor / l[i, 1]);
            }

            //reduce common factor between dividend and divisor
            for (int i = 2; i <= maxDivisor; i++)
            {
                while (dividend % i == 0 && divisor % i == 0)
                {
                    dividend = dividend / i;
                    divisor = divisor / i;
                }
            }
            return divisor == 1 ? dividend.ToString() : $"[{dividend}, {divisor}]";
        }
    }
}
