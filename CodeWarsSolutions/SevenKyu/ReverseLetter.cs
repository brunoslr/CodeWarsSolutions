using System.Text.RegularExpressions;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public class ReverseLetterClass
    {
        public string ReverseLetter(string str)
        {
            var cleanUp = Regex.Replace(str, @"[^a-zA-Z]", "");
            return new string(cleanUp.ToCharArray().Reverse().ToArray());
        }
    }
    
}
