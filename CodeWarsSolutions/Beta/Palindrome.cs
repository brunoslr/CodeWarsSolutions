using System.Linq;

namespace CodeWarsSolutions.Beta
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            return new string(word.ToUpper().ToCharArray().Reverse().ToArray()) == word.ToUpper();
        }

       /* public static void Main(string[] args)
        {
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
        }*/
    }
}
