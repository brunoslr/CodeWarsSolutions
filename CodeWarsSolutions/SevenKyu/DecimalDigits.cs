/* URL: https://www.codewars.com/kata/number-of-decimal-digits/train/csharp
Determine number of decimal digits in an unsiged integer. For example, 9 is a single digit, 66 has 2 digits and 128685 has 6 digits. Be careful to avoid overflows/underflows.

Extra challenge - Try optimize your implementation by avoiding slow operation like heap allocation and string formatting. 
 */

namespace CodeWarsSolutions.SevenKyu
{
    public class DecimalDigits
    {
        public static int Digits(ulong n)
        {
            // return n.ToString().Length;
            int digitsCount = 1;
            while (n / 10 > 0)
            {
                n = n / 10;
                digitsCount++;
            }

            return digitsCount;
        }
    }
}
