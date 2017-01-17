/*URL  https://www.codewars.com/kata/square-into-squares-protect-trees/train/csharp
Description: My little sister came back home from school with the following task: given a squared sheet of paper she has to cut it in pieces which, when assembled, give squares the sides of which form an increasing sequence of numbers. At the beginning it was lot of fun but little by little we were tired of seeing the pile of torn paper. So we decided to write a program that could help us and protects trees.

Task:

Given a positive integral number n, return a strictly increasing sequence (list/array/string depending on the language) of numbers, so that the sum of the squares is equal to n².
If there are multiple solutions (and there will be), return the result with the largest possible values:

Examples

decompose(11) must return [1,2,4,10]. 
Note that there are actually two ways to decompose 11², 11² = 121 = 1 + 4 + 16 + 100 = 1² + 2² + 4² + 10² but don't return [2,6,9], since 9 is smaller than 10.

For decompose(50) don't return [1, 1, 4, 9, 49] but [1, 3, 5, 8, 49] since [1, 1, 4, 9, 49] doesn't form a strictly increasing sequence.

Neither [n] nor [1,1,1,…,1] are valid solutions. If no valid solution exists, return nil, null, Nothing, None (depending on the language) or "" (Java, C#) or {} (C++).
The function "decompose" will take a positive integer n and return the decomposition of N = n² as:

"x1 ... xk"

Hint: Very often xk will be n-1. */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.FourKyu
{
    public class SquareIntoSquares
    {  

        public string decompose(long n)
        {
            Stack<long> numbers = new Stack<long>();
            long rest = n * n - (long)Math.Pow(n - 1, 2);
            numbers.Push(n - 1);
            long temp = (long)Math.Sqrt(rest);
            while (rest > 0)
            {
                if (rest - (long)Math.Pow(temp, 2) >= 0 && temp >= 1)
                {
                    rest = rest - (long)Math.Pow(temp, 2);
                    numbers.Push(temp);
                }
                else
                {
                    if (temp <= 1)
                    {
                        if (numbers.Count == 0) break;

                        temp = numbers.Pop();
                        rest = rest + (long)Math.Pow(temp, 2);
                    }
                }

                temp--;

                if (numbers.Sum(el => el * el) == n * n)
                {
                    return String.Join(" ", numbers.ToArray());
                }

            }
            return null;
        }
    }
}
