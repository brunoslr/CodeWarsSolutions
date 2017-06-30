/* Title: shorter concat [reverse longer]
 Given 2 strings, a and b, return a string of the form: shorter+reverse(longer)+shorter.

In other words, the shortest string has to be put as prefix and as suffix of the reverse of the longest.

Strings a and b may be empty, but not null (In C# strings may also be null. Treat them as if they are empty.).
If a and b have the same length treat a as the longer producing b+reverse(a)+b
 */

namespace CodeWarsSolutions.SevenKyu
{
    class SimpleConcatGame
    {
        public static string ShorterReverseLonger(string a, string b)
        {
            string shorter, longerReverse;
            if (a.Length < b.Length)
            {
                longerReverse = ReverseWord(b);
                shorter = a;
            }
            else
            {
                longerReverse = ReverseWord(a);
                shorter = b;
            }

            return $"{shorter}{longerReverse}{shorter}";

        }

        private static string ReverseWord(string word)
        {
            var wordArray = word.ToCharArray();
            System.Array.Reverse(wordArray);
            return string.Concat(wordArray);
        }
    }
}
