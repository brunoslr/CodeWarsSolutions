/* URL: https://www.codewars.com/kata/calculate-string-rotation/train/csharp
  Write a function that receives two strings and returns n, where n is equal to the number of characters we should shift the first string forward to match the second.

For instance, take the strings "fatigue" and "tiguefa". In this case, the first string has been rotated 5 characters forward to produce the second string, so 5 would be returned.

If the second string isn't a valid rotation of the first string, the method returns -1.
Examples:

"coffee", "eecoff" => 2
"eecoff", "coffee" => 4
"moose", "Moose" => -1
"isn't", "'tisn" => 2
"Esham", "Esham" => 0
"dog", "god" => -1
*/

namespace CodeWarsSolutions.SixKyu
{
    
    public class CalculateStringRotation
    {
        public static int ShiftedDiff(string first, string second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (Shift(second, i) == first)
                    return i;
            }
            return -1;
        }

        private static string Shift(string word, int shift)
        {
            return word.Substring(shift, word.Length - shift) + word.Substring(0, shift);
        }
    }
}
