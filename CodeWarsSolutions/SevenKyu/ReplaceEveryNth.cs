/* URL:https://www.codewars.com/kata/replace-every-nth/train/csharp
 Replace every nth
Write a method, that replaces every nth char oldValue with char newValue.
Method:
ReplaceNth(string text, int n, char oldValue, char newValue)
Example:
n:         2
oldValue: 'a'
newValue: 'o'
"Vader said: No, I am your father!" -> "Vader soid: No, I am your fother!"
  1     2          3        4       -> 2nd and 4th occurence are replaced
Your method has to be case sensitive!
As you can see in the example: The first changed is the 2nd 'a'. So the start is always at the nth suitable char and not at the first!
If n is 0 or negative or if it is larger than the count of the oldValue, return the original text without a change. 
The text and the chars will never be null.
 */
using System.Text.RegularExpressions;
namespace CodeWarsSolutions.SevenKyu
{
    public class ReplaceEveryNth
    {
        public static string ReplaceNth(string text, int n, char oldValue, char newValue)
        {
            if (n < 1) return text;
            int counter = 0;
            Match m = Regex.Match(text, oldValue.ToString());
            while (m.Success)
            {
                counter++;
                if (counter % n == 0)
                    text = ReplaceAt(text, m.Index, newValue);

                m = m.NextMatch();
            }
            return text;
        }

        public static string ReplaceAt(string text, int index, char newChar)
        {
            if (text == null)
            {
                return text;
            }
            char[] chars = text.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }

    }
}
