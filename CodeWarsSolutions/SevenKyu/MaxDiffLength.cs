/* URL: https://www.codewars.com/kata/maximum-length-difference/csharp
You are given two arrays a1 and a2 of strings.Each string is composed with letters from a to z.
Let x be any string in the first array and y be any string in the second array.
Find max(abs(length(x) − length(y)))
If a1 or a2 are empty return -1 in each language except in Haskell where you will return Nothing.
#Example:
s1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"]
s2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"]
mxdiflg(s1, s2) --> 13
*/
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public class MaxDiffLength
    {

        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0) return -1;

            var a1Min = a1.Min(s => s.Length);
            var a1Max = a1.Max(s => s.Length);
            var a2Min = a2.Min(s => s.Length);
            var a2Max = a2.Max(s => s.Length);

            return a1Max - a2Min > a2Max - a1Min ? a1Max - a2Min : a2Max - a1Min;
        }
    }
}
