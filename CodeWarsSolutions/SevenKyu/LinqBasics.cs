/* URL: https://www.codewars.com/kata/getting-to-know-linq/train/csharp
 In .NET the Language Integrated Query (LINQ) component adds several helpful methods that can be used with enumerables.

The goal of this Kata is to practice some scenarios where LINQ can be used to replace loops.

Replace each loop in the code with a LINQ expression. The validation will fail if the words 'for' or 'while' occurs anywhere in the code (even in comments).
 */
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public class LinqBasics
    {
        public static int Sum(int[] integers) => integers.Sum();

        public static int CountChar(char[] chars, char charToCount) => chars.Where(c => c == charToCount).Count();

        public static int[] CalculateSquares(int start, int end) => Enumerable.Range(start, (end - start + 1)).Select(x => x * x).ToArray();

    }
}
