//URL: https://www.codewars.com/kata/concatenated-sum/train/csharp
using System;
using System.Linq;

/*  The number 198 has the property that 198 = 11 + 99 + 88, i.e., if each of its digits is 
 *  concatenated twice and then summed, the result will be the original number. 
 *  It turns out that 198 is the only number with this property. 
 *  However, the property can be generalized so that each digit is concatenated n times and then summed.   
    eg:
    
    original number =2997 , n=3
    2997 = 222+999+999+777 and here each digit is concatenated three times.
    
    original number=-2997 , n=3
    
    -2997 = -222-999-999-777 and here each digit is concatenated three times.
*/
namespace CodeWarsSolutions.SevenKyu
{
    public class ConcatenatedSum
    {
        /// <summary>
        /// Returns a Boolean representing if a number with its digits concatenated an arbitrary 
        /// number of times and summed is the same as the original number.</summary>
        /// <param name="number">int to be tested.</param>
        /// <param name="n">int which represents the number of times to concatenate each digit</param>
        public static bool CheckConcatenatedSum(int number, int n)
        {
            if (n > number.ToString().Length) return false;

            int absNumber = Math.Abs(number);
            return absNumber.ToString().Select(c => int.Parse(new String(c, n))).Sum() == absNumber;
        }
    }
}
