/* URL:https://www.codewars.com/kata/binary-operations-number-1/train/csharp
Your work is to write a method that takes a value and an index, and returns the value with the bit at given index flipped.
The bits are numbered from the least significant bit (index 1).
Example:
FlipBit(15,4) == 7  // 15 in binary is 1111, after flipping 4th bit, it becomes 0111, i.e. 7
FlipBit(15,5) == 31 // 15 in binary is 1111, 5th bit is 0, after flipping, it becomes 11111, i.e., 31

 */
 
namespace CodeWarsSolutions.SevenKyu
{
    public class BinaryOperationOne
    {
        public static int FlipBit(int value, int bitIndex)
        {
            return value ^ (int)System.Math.Pow(2, bitIndex - 1);
        }
    }
}
