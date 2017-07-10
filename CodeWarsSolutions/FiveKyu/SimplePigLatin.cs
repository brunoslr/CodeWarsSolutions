/* URL: https://www.codewars.com/kata/simple-pig-latin/train/csharp
Move the first letter of each word to the end of it, then add 'ay' to the end of the word.
Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
 */
using System;
using System.Linq;

namespace CodeWarsSolutions.FiveKyu
{
    public class SimplePigLatin
    {
       
        public static string PigIt(string str)
        {
            return String.Join(" ", str.Split().Select(s => PigWord(s)));
        }

        public static string PigWord(string str)
        {
            string suffix = "ay";

            if (str.Length == 1) return str + suffix;
            return str.Substring(1) + str[0] + suffix;
        }
    }
}

