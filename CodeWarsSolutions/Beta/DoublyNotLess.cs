/* URL: https://www.codewars.com/kata/simple-fun-number-128-doubly-not-less/train/csharp
 Task

You are given an integer n(in string format). Find the smallest integer m such that both m and its reversed version (a number that is obtained by reversing the order of its digits) are not less than n.

Note: After reversing all leading zeros are omitted.
Examples

For n = "5314", the result should be `"5316".

Because both numbers 5316 and 6135 are not less than 5314.

The result is not 5315 because 5135(5315 reversed) < 5314.

For n = "23456", the result is also "23456".
Input/Output

[input] string n

string representation of a positive integer n. 0 < n < 10^100
[output] a string

string representation of an integer m
 */
using System;

namespace CodeWarsSolutions.Beta
{

    public class DoublyNotLessKata
    {
        public string DoublyNotLess(string n)
        {
            char[] number = n.ToCharArray();
            for (int i = 0; i < n.Length / 2; i++)
            {

                char head = n[i];
                char tail = n[n.Length - i - 1];
                if (head >= tail)
                {
                    if (head < '9')
                    {
                        number[n.Length - i - 1] = head;
                        if (!CheckDoublyNotLess(string.Concat(number)))
                        {
                            number[n.Length - i - 1] = (Char)((int)(head) + 1);
                        }
                    }
                    else
                    {
                        number[n.Length - i - 1] = n[i];
                    }
                }

                if (CheckDoublyNotLess(string.Concat(number)))
                    break;

            }
            Console.WriteLine(string.Concat(number));
            return string.Concat(number);
        }

        private bool CheckDoublyNotLess(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {

                char head = n[i];
                char tail = n[n.Length - i - 1];
                if (head < tail)
                {
                    return true;
                }
                if (head > tail)
                {
                    return false;
                }
            }
            return true;
        }
    }    
}
