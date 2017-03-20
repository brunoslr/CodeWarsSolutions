/* URL: https://www.codewars.com/kata/consecutive-strings/train/csharp
 You are given an array strarr of strings and an integer k. 
 Your task is to return the first longest string consisting of k consecutive strings taken in the array.
 Example:

longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"
n being the length of the string array, if n = 0 or k > n or k <= 0 return "".
 */
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    public class LongestConsecutives
    {

        public static string LongestConsecRefSolution(string[] strarr, int k)
        {
            if (k > strarr.Length) return "";

            return Enumerable.Range(0,strarr.Length-k+1)
                .Select(x=>string.Concat(strarr.Skip(x).Take(k)))
                .OrderByDescending(el => el.Length).First();
        }

        public static string LongestConsec(string[] strarr, int k)
        {
            if (k > strarr.Length) return "";

            var position = strarr.Select((x, i) => SunConsecFromPosition(strarr, k, i))
            .Select((x, i) => new { x, i })
            .OrderByDescending(el => el.x)
            .First();
            return string.Concat(strarr.Skip(position.i).Take(k));
        }

        public static int SunConsecFromPosition(string[] strarr, int k, int initialIndex)
        {
            int sum = 0;
            for (int i = initialIndex; i < (initialIndex + k) && i < strarr.Length; i++)
            {
                sum += strarr[i].Length;
            }
            return sum;
        }
    }
}