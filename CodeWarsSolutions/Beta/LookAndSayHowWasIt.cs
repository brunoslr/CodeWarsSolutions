/* URL: https://www.codewars.com/kata/56e3781c93c3d9fec600011d/train/csharp
The Look-and-say sequence, looks like this:

11, 21, 1211, 111221, ...
Here the following number is always the "description" of the previous, that is:

"11" is the previous number of "21" because "11" has "two" "ones"

"21" is the previous number of "1211" because "21" has "one" "two" and "one" "one"
The task for this Kata is given a number (n >= 10) return the "previous" number in the sequence. Here you can assume that the quantity indicator is always one digit.

The result is returned as a string.
 */

using System.Linq;

namespace CodeWarsSolutions.Beta
{
    public static class Sequence
    {
        public static string GetPreviousNumber(int n)
        {

            string number = n.ToString();
            string result = "";
            //string result2 = "";
            for (int i = 0; i < number.Length; i += 2)
            {
                //result2+=new string(number[i+1],(int)char.GetNumericValue(number[i]));
                result += string.Concat(Enumerable.Repeat(number[i + 1], (int)char.GetNumericValue(number[i])));
            }
            return result;
        }
    }
}
