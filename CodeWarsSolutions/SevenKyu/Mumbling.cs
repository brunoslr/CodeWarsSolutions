/* URL: https://www.codewars.com/kata/mumbling/train/csharp
 This time no story, no theory. The examples below show you how to write function accum:

Examples:

Accumul.Accum("abcd");    // "A-Bb-Ccc-Dddd"
Accumul.Accum("RqaEzty"); // "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
Accumul.Accum("cwAt");    // "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.
 */
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    class Mumbling
    {
        public static string Accum(string s) => string.Join("-", s.Select((x, ind) => char.ToUpper(x) + new string(char.ToLower(x), ind)));
    }
}
