/*URL: https://www.codewars.com/kata/weird-prime-generator/train/csharp
 * 
    Consider the sequence a(1) = 7, a(n) = a(n-1) + gcd(n, a(n-1)) for n >= 2:
    7, 8, 9, 10, 15, 18, 19, 20, 21, 22, 33, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 69, 72, 73....
    Let us take the differences between successive elements of the sequence and get a second sequence g: 1, 1, 1, 5, 3, 1, 1, 1, 1, 11, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 23, 3, 1....
    For the sake of uniformity of the lengths of sequences we add a 1 at the head of g:
    g: 1, 1, 1, 1, 5, 3, 1, 1, 1, 1, 11, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 23, 3, 1...
    Removing the 1s gives a third sequence: p: 5, 3, 11, 3, 23, 3... where you can see prime numbers.

    Task: Write functions:
    1: an(n) with parameter n: returns the first n terms of the series a(n) (not tested)
    2: gn(n) with parameter n: returns the first n terms of the series g(n) (not tested)
    3: countOnes(n) with parameter n: returns the number of 1 in g(n) 
        (don't forget to add a `1` at the head) # (tested)
    4: p(n) with parameter n: returns an array of n unique prime numbers (not tested)
    5: maxp(n) with parameter n: returns the biggest prime number of the sequence pn(n) # (tested)
    6: anOver(n) with parameter n: returns an array (n terms) of the a(i)/i for every i such g(i) != 1 (not tested but interesting result)
    7: anOverAverage(n) with parameter n: returns as an *integer* the average of anOver(n)  (tested)
    Note:
    You can write directly functions 3:, 5: and 7:. There is no need to write functions 1:, 2:, 4: 6: except out of pure curiosity.
 */
 
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.FiveKyu
{
    public class WeirdPrimeGen
    {

        static List<int> initialSequence;
        static List<int> secondSequence;
        static List<int> thirdSequence;
        static List<int> primeNumbersSequence;


        private static void GenerateInitialSequence(int n)
        {
            initialSequence = new List<int>();
            int initialElement = 7;
            initialSequence.Add(initialElement);

            for (int i = 1; i < n; i++)
            {
                initialSequence.Add(initialSequence[i - 1] + GCD(initialSequence[i - 1], i + 1));
            }

            secondSequence = new List<int>();
            initialElement = 1;
            secondSequence.Add(initialElement);

            for (int i = 1; i < n; i++)
            {
                secondSequence.Add(initialSequence[i] - initialSequence[i - 1]);
            }

            thirdSequence = secondSequence.Where(x => x != 1).ToList();

            primeNumbersSequence = thirdSequence.Distinct().OrderBy(x => x).ToList();


        }

        private static void GeneratePrimeNumberSequence(int n)
        {
            initialSequence = new List<int>();
            secondSequence = new List<int>();
            primeNumbersSequence = new List<int>();
            initialSequence.Add(7);
            secondSequence.Add(1);


            int i = 1;

            while (primeNumbersSequence.Count() < n)
            {

                initialSequence.Add(initialSequence[i - 1] + GCD(initialSequence[i - 1], i + 1));
                secondSequence.Add(initialSequence[i] - initialSequence[i - 1]);

                if (secondSequence[i] > 1)
                {
                    thirdSequence = secondSequence.Where(x => x != 1).ToList();
                    primeNumbersSequence = thirdSequence.Distinct().OrderBy(x => x).ToList();
                }
                i++;
            }

        }

        static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }


        public static long CountOnes(int n)
        {
            GenerateInitialSequence(n);
            return secondSequence.Count(x => x == 1);
            // your code
        }
        public static long MaxPn(int n)
        {
            GeneratePrimeNumberSequence(n);
            //Console.WriteLine(String.Join(",",primeNumbersSequence));
            return (long)primeNumbersSequence[n - 1];
        }

        public static long AnOverAverage(int n)
        {
            Decimal tempAverage = 0;
            int tempAverageCount = 0;

            GenerateInitialSequence(n);
            for (int i = 1; i < n; i++)
            {
                if (secondSequence[i] > 1)
                {
                    tempAverage += initialSequence[i] / i;
                    Console.WriteLine(initialSequence[i] / i);
                    tempAverageCount++;
                }
            }
            if (tempAverageCount == 0)
                return 3;

            return (long)(tempAverage / tempAverageCount);
        }

    }
}
