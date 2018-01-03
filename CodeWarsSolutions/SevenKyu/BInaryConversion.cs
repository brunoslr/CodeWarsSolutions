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
*/
using System;

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
            return Int32.Parse($"1{result}");

        }
    }
}
