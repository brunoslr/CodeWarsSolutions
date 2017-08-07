/*
 #Find the missing letter

Write a method that takes an array of consecutive (increasing) letters as input and that returns the missing letter in the array.

You will always get an valid array. And it will be always exactly one letter be missing. The length of the array will always be at least 2.
The array will always contain letters in only one case.

Example:

['a','b','c','d','f'] -> 'e'
['O','Q','R','S'] -> 'P'
(Use the English alphabet with 26 letters!)

Have fun coding it and please don't forget to vote and rank this kata! :-)
 
 */
namespace CodeWarsSolutions.SixKyu
{
    public static class MissingLetter
    {
        public static char? FindMissingLetter(char[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((char)(a[i] + 1) != a[i + 1])
                    return (char) (a[i] + 1);
            }

            return null;
        }
    }
}
