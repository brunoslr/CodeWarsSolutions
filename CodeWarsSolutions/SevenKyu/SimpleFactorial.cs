using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.SevenKyu
{
    public static class SimpleFactorial
    {
        public static int Factorial(int n)
        {
            if (n > 12 || n < 0) throw new ArgumentOutOfRangeException(nameof(n));

            return (n == 0 || n == 1)? 1 : n * Factorial(n - 1);
        }
    }

}
