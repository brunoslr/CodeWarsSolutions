/* URL: https://www.codewars.com/kata/fibonacci/train/csharp
 Create function fib that returns n'th element of Fibonacci sequence (classic programming task).
 */
using System.Collections.Generic;

namespace CodeWarsSolutions.SevenKyu
{
    class FibonacciIntroToDynamic
    {
        protected static Dictionary<int, int> cache = new Dictionary<int, int> { { 1, 1 }, { 2, 1 } };

        public static int fib(int n)
        {
            if (cache.ContainsKey(n))
            {
                return cache[n];
            }
            else
            {
                int fibNumber = fib(n - 1) + fib(n - 2);
                cache.Add(n, fibNumber);
                return fibNumber;
            }
        }
    }
}
