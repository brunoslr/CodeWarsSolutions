/*URL:https://www.codewars.com/kata/56c30ad8585d9ab99b000c54/train/csharp
Your task is to Combine two Strings. But consider the rule...

By the way you don't have to check errors or incorrect input values, every thing is ok without bad tricks, only two input strings and as result one output string;-)...

And here's the rule:
Input Strings 'a' and 'b': For each char in 'a' you have to switch the same char inside 'b' to upper case, if it exists in 'b' (clear) and if it is in lower case. If 'b' contains the char in lower case, you have to switch it to upper case (do it for all the same chars found in 'b'). If 'a' contains same char more than once, you have to switch again... and again... and again... One last important word: A char of 'a' is in 'b' regardless if it's in upper or lower case.
Do the same for the chars of 'b' found in 'a', combine both (result for 'a' + result for 'b') and return it as a string - see the testcases too. I think that's all;-)... 

Some easy examples:

Input: "abc" and "cde"      => Output: "abCCde" 
Input: "abab" and "bababa"  => Output: "ABABbababa"
Input: "ab" and "aba"        => Output: "aBABA"
There are some static tests at the beginning and many random tests if you submit your solution.
 */
using System;
using System.Linq;

namespace CodeWarsSolutions.Beta
{

    public class PlayWithTwoStrings
    {
        public string workOnStrings(string a, string b)
        {
            return playWithOneString(a, b) + playWithOneString(b, a);
        }

        private string playWithOneString(string a, string b)
        {
            return String.Concat(a
                 .Select(el => (b.Where(c => c == Char.ToLower(el) || c == Char.ToUpper(el)).Count() % 2 == 1) ? revertCharCase(el) : el));

        }
        public char revertCharCase(char c)
        {
            return (c == Char.ToUpper(c)) ? Char.ToLower(c) : Char.ToUpper(c);
        }

    }
    
}
