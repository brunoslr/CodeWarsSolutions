/* URL: https://www.codewars.com/kata/casear-cypher/train/csharp

Your country has asked you to aid in solving a super secret code. Your task is to write a function which returns the decrypted secret code.

Notes:
hint: the letters are all shifted a certain number of times, the number of shifts will be passed as a parameter
punctuation should not be modified, only letters should be shifted
the code will not contain captial letters or special characters
Examples:

Decypher("abc", 1) => "bcd"
Decypher("lbh'yy arire trg guvf bar", 13) => "you'll never get this one"
Have fun coding it and please don't forget to vote and rank this kata! :)
*/

using System.Linq;

namespace CodeWarsSolutions.Beta
{
    public class CaesarCypher
    {
        public static string Decypher(string secretCode, int shifts)
        {
            return string.Concat(
              secretCode
              .Select(c => (c > 96 && c < 123) ? (char)((c - 96 + shifts) % 26 + 96) : c));
        }
    }
}
