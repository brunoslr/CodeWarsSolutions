/* URL:https://www.codewars.com/kata/reversed-words/train/csharp
Complete the solution so that it reverses all of the words within the string passed in.

Example:
Kata.ReverseWords("The greatest victory is that which requires no battle");
// should return "battle no requires which that is victory greatest The"
 */
using System;
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    public class ReverseWordsInAString
    {
        public static string ReverseWords(string str)
        {
            return String.Join(" ", str.Split(' ').Reverse());
        }
    }
}

