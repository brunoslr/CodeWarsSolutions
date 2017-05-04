/* URL: https://www.codewars.com/kata/the-hidden-word/train/csharp
 Maya writes weekly articles to a well known magazine, but she is missing one word each time she is about to send the article to the editor. The article is not complete without this word. Maya has a friend, Dan, and he is very good with words, but he doesn't like to just give them away. He texts Maya a number and she needs to find out the hidden word. The words can contain only the letter: "a", "b", "d", "e", "i", "l", "m", "n", "o", and "t".
Luckily, Maya has the key:
"a" - 6 "b" - 1 "d" - 7 "e" - 4 "i" - 3 "l" - 2 "m" - 9 "n" - 8 "o" - 0 "t" - 5
You can help Maya by writing a function that will take a number between 100 and 999999 and return a string with the word.
The input is always a number, contains only the numbers in the key. The output should be always a string with one word, all lowercase.
*/

using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    public class HiddenWordMaya
    {
        private Dictionary<int,string> myDictionary = new Dictionary<int, string>()
        {
            {6, "a"}, {1, "b"}, {7, "d"}, {4, "e"}, {3, "i"},
            {2, "l"}, {9, "m"}, {8, "n"}, {0, "o"}, {5, "t"}
        };
        
        public string hidden(int num)
        {
          StringBuilder result = new StringBuilder();
          
            while(num>0)
            {
              result.Append(myDictionary[num%10]);
              
              num = num/10;
            }
           
           return result.ToString().ReverseString();
        }

    }
    
     static class StringExtension{
    
        public static string ReverseString(this string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}