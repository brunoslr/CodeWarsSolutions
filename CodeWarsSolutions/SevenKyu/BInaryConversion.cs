/*  URL: https://www.codewars.com/kata/convert-to-binary/train/csharp
 *  Task Overview
    Given a non-negative integer n, write a function toBinary/ToBinary which returns that number in a binary format.
    
    Documentation:
    Kata.ToBinary Method (Int32)
    Returns the binary representation of a non-negative integer as an integer.
    
    Syntax
    
    public static int ToBinary(
    int n
    )
    
    Parameters 
    n 
    Type: System.Int32
    The integer to convert. 
    
    Return Value 
    Type: System.Int32
    The binary representation of the argument as an integer.
     return int.Parse(Convert.ToString(n, 2));
*/
using System;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public static class BinaryConversion
    {
        public static int ToBinary(int n)
        {
            var result = "";
            while (n > 1)
            {
                result = $"{n % 2}{result}";
                n = n / 2;
            }
            return Int32.Parse($"{n}{result}");

        }
    }
}

/*Write a function that takes an(unsigned) integer as input, and returns the number of bits that are equal to one in the binary representation of that number.
    Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case*/
public class BitCounting
{
    public static int CountBits(int n) => Convert.ToString(n, 2).Count(c => c == '1');
}
