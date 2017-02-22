/* URL:https://www.codewars.com/kata/moves-in-squared-strings-iv/train/csharp
 You are given a string of n lines, each substring being n characters long: For example:
s = "abcd\nefgh\nijkl\nmnop"
We will study some transformations of this square of strings.
Symmetry with respect to the main cross diagonal: diag_2_sym (or diag2Sym or diag-2-sym)
diag_2_sym(s) => "plhd\nokgc\nnjfb\nmiea"
Counterclockwise rotation 90 degrees: rot_90_counter (or rot90Counter or rot-90-counter)
rot_90_counter(s)=> "dhlp\ncgko\nbfjn\naeim"
selfie_diag2_counterclock (or selfieDiag2Counterclock or selfie-diag2-counterclock) It is initial string + string obtained by symmetry with respect to the main cross diagonal + counterclockwise rotation 90 degrees .
s = "abcd\nefgh\nijkl\nmnop" --> 
"abcd|plhd|dhlp\nefgh|okgc|cgko\nijkl|njfb|bfjn\nmnop|miea|aeim"
or printed for the last:
selfie_diag2_counterclock
abcd|plhd|dhlp
efgh|okgc|cgko
ijkl|njfb|bfjn
mnop|miea|aeim
Task:
Write these functions diag_2_sym, rot_90_counter, selfie_diag2_counterclock
and
high-order function oper(fct, s) where
fct is the function of one variable f to apply to the string s (fct will be one of diag_2_sym, rot_90_counter, selfie_diag2_counterclock)
Examples:
s = "abcd\nefgh\nijkl\nmnop"
oper(diag_2_sym, s) => "plhd\nokgc\nnjfb\nmiea"
oper(rot_90_counter, s) => "dhlp\ncgko\nbfjn\naeim"
oper(selfie_diag2_counterclock, s) => "abcd|plhd|dhlp\nefgh|okgc|cgko\nijkl|njfb|bfjn\nmnop|miea|aeim"
Notes:
The form of the parameter fct in oper changes according to the language. You can see each form according to the language in "Your test cases".
It could be easier to take these katas from number (I) to number (IV)
 */
using System.Collections.Generic;
using System;
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    public class Opstrings
    {
        public delegate string StringOperation(string strng);

        public static string VertMirror(string strng)
        {
            return string.Join("\n", strng.Split('\n').Select(s => string.Concat(s.Reverse())));
        }

        public static string HorMirror(string strng)
        {
            return string.Join("\n", strng.Split('\n').Reverse());
        }

        private static char[][] StringToCharArray(string strng)
        {
            var stringArray = strng.Split('\n');
            int n = stringArray.Length;
            List<char[]> lettersArraylist = new List<char[]>();

            for (int i = 0; i < stringArray.Length; i++)
                lettersArraylist.Add(stringArray[i].ToCharArray());

            return lettersArraylist.ToArray();
        }

        public static string Rot90Counter(string strng)
        {
            char[][] ca = StringToCharArray(strng);
            int n = ca[0].Length;

            string stringLine;
            List<string> resultStringList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                stringLine = "";

                for (int j = 0; j < n; j++)
                {
                    stringLine += ca[j][n - i - 1];
                }
                resultStringList.Add(stringLine);
            }
            return String.Join("\n", resultStringList.ToArray());
        }

        public static string Diag2Sym(string strng)
        {
            char[][] ca = StringToCharArray(strng);
            int n = ca[0].Length;

            string stringLine;
            List<string> resultStringList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                stringLine = "";

                for (int j = 0; j < n; j++)
                {
                    stringLine += ca[n - j - 1][n - i - 1];
                }
                resultStringList.Add(stringLine);
            }
            return String.Join("\n", resultStringList.ToArray());
        }

        public static string SelfieDiag2Counterclock(string strng)
        {
            var stringArray = strng.Split('\n');
            var diagArray = Diag2Sym(strng).Split('\n');
            var rotArray = Rot90Counter(strng).Split('\n');

            return String.Join("\n", stringArray.Select((s, i) => $"{s}|{diagArray[i]}|{rotArray[i]}"));
        }

        public static string Oper(StringOperation fct, string s)
        {
            return fct(s);
        }

    }
}
