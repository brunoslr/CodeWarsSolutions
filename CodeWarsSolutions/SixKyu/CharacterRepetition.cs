/* URL: https://www.codewars.com/kata/character-with-longest-repetition/train/csharp
For a given string s find the character c with longest consecutive repetition and return a tuple (c, l) (in Haskell Just (Char, Int), in C# Tuple<char?, int>, in Shell a String of comma-separated values c,l) where l is the length of the repetition. If there are two or more characters with the same l return the first.
For empty string return ('', 0) (in Haskell Nothing, in C# Tuple<char, int>(null, 0), in Shell ,0).
 */
using System;

namespace CodeWarsSolutions.SixKyu
{
    public static class CharacterRepetition
    {
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            char? currentChar = null;
            char? maxCountChar = null;
            int currentCount = 0;
            int maxCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (currentChar == input[i])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxCountChar = currentChar;
                    }
                    currentChar = input[i];
                    currentCount = 1;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxCountChar = currentChar;
            }

            return new Tuple<char?, int>(maxCountChar, maxCount);
        }
    }

}

/*
 Solution by Davesen

using System;
using System.Linq;

 public static class Kata
{
    public static Tuple<Char?, Int32> LongestRepetition( String input )
        => input
               .Select( ( x, i ) => new Tuple<Char?, Int32>( x, input.Substring( i ).TakeWhile( y => y == x ).Count() ) )
               .OrderByDescending( x => x.Item2 )
               .FirstOrDefault()
           ?? new Tuple<Char?, Int32>( null, 0 );
}

 */
