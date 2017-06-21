/* URL:https://www.codewars.com/kata/two-to-one/train/csharp
 Take 2 strings s1 and s2 including only letters from ato z. Return a new sorted string, the longest possible, containing distinct letters,

each taken only once - coming from s1 or s2. #Examples: ``` a = "xyaabbbccccdefww" b = "xxxxyyyyabklmopq" longest(a, b) -> "abcdefklmopqwxy"
a = "abcdefghijklmnopqrstuvwxyz" longest(a, a) -> "abcdefghijklmnopqrstuvwxyz" ```
 */
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    class TwoToOneDistinct
    {
        public static string Longest(string s1, string s2) => string.Concat((s1 + s2).ToArray().OrderBy(c => c).Distinct());
    }
}
