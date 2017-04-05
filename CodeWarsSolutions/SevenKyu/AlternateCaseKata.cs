/* URL:https://www.codewars.com/kata/alternate-case/train/csharp
 
 */
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public static class AlternateCaseKata
    {
        public static string alternateCase(string s) => string.Concat(s.Select(x => x == char.ToLower(x) ? char.ToUpper(x) : char.ToLower(x)));
    }
}
