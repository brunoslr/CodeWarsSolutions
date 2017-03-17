/* URL: http://www.codewars.com/kata/shortest-word/train/csharp
 x Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
 */
using System;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    class ShortestWord
    {
        static int FindShort(string s)
        {
            if (s.Trim().Length == 0) return 0;
            return s.Split(' ').Aggregate(Int32.MaxValue, (cur, next) => (cur < next.Length) ? cur : next.Length);
        }

        internal static int FindShortForTest(string s)
        {
           return FindShort(s);
        }

    }

}
