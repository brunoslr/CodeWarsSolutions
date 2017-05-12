using System;

namespace CodeWarsSolutions.SixKyu
{
    public class PrimesWithoutLoop
    {

        public bool IsPrime(int number)
        {
            var sqrt = Math.Sqrt(Math.Abs(number));

            if (sqrt % 1 == 0) return false;

            return IsPrime((int)(sqrt), number);
        }

        private bool IsPrime(int current, int number)
        {
            if (current <= 1) return true;

            if (number % current == 0) return false;

            return IsPrime(current - 1, number);
        }

    }

}
