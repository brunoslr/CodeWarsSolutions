using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWarsSolutions
{

    class StepInPrimes
    {
        public static long[] Step(int g, long m, long n)
        {
            if (g % 2 == 1 && m > 2)
                return null;


            List<long> primes = new List<long>();
            long currentNumber = m;
            int limit = 0;
            long[] validPrimesList;

            while (currentNumber <= n)
            {
                limit = (int)Math.Ceiling(Math.Sqrt(currentNumber));

                for (int i = 2; i <= limit; i += 1)
                {
                    if (currentNumber % i == 0) break;

                    if (i == limit)
                    {
                        primes.Add(currentNumber);

                        if (primes.Count > 2)
                        {
                            validPrimesList = primes.Where(a => primes.Contains(a + g)).ToArray();

                            if (validPrimesList.Length > 0)
                            {
                                return new long[] { (int)validPrimesList[0], (int)validPrimesList[0] + g };
                            }
                            //Reduces the list od primes to only the acceptable ones
                            primes = primes.Where(x => x >= (primes[primes.Count - 1] - g)).ToList();

                        }

                    }
                }
                currentNumber++;
            }

            validPrimesList = primes.Where(a => primes.Contains(a + g)).ToArray();

            if (validPrimesList.Length > 0)
            {
                return new long[] { (int)validPrimesList[0], (int)validPrimesList[0] + g };
            }

            return null;
        }
    }
}
