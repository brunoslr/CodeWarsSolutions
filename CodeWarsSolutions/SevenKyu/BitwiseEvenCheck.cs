/* URL: https://www.codewars.com/kata/iseven-bitwise-series/train/csharp
Is the number even?
If the numbers is even return true. If it's odd, return false. 

Oh yeah... the following symbols/commands have been disabled!
use of percent
*/

namespace CodeWarsSolutions.SevenKyu
{
    public static class BitwiseEvenCheck
    {
        public static bool IsEven(int n) => (n & 1) == 0;
        // public static bool IsEven(int n) => Convert.ToString(n, 2).Last() == '0';
    }
}
