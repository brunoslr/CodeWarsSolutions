using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.SixKyu
{
    public class Thirteen
    {

        public static long Thirt(long n)
        {
            var numberToDivide = n;
            var remainders = new int[] { 1, 10, 9, 12, 3, 4 };
            var digitPosition = 0;
            long result = 0;

            while (numberToDivide >= 1)
            {
                result += numberToDivide % 10 * remainders[digitPosition % remainders.Length];
                digitPosition++;
                numberToDivide = numberToDivide / 10;
            }
            return (n == result) ? result : Thirt(result);
        }
    }
}
