/* URL: https://www.codewars.com/kata/1-s-0-s-and-wildcards/train/csharp
1-s-0-s-and-wildcards
You are given a string containing 0's, 1's and one or more '?', where ? is a wildcard that can be 0 or 1.
Return an array containing all the possibilities you can reach substituing the ? for a value.

Examples: 
'101?' -> ['1010', '1011']
'1?1?' -> ['1010', '1110', '1011', '1111']
1 - Don't worry about sorting the output. 2 - Your string will never be empty. 3 - Have fun!
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CodeWarsSolutions.FiveKyu
{
    public class RegexWithBranching
    {
        public List<string> Possibilities(string input)
        {
            if (input.Contains("?"))
            {
                List<string> listBranch = Possibilities(Regex.Replace(input, @"(.*)\?(.*)", "${1}0${2}"));
                listBranch.AddRange(Possibilities(Regex.Replace(input, @"(.*)\?(.*)", "${1}1${2}")));
                return listBranch;
            }
            else return new List<string> { input };
        }
    }
}
