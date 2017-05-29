/* URL: https://www.codewars.com/kata/ga-de-ry-po-lu-ki-cypher/train/csharp
 Introduction

The GADERYPOLUKI is a simple substitution cypher used in scouting to encrypt messages. The encryption is based on short, easy to remember key. The key is written as a paired letters, which are in the cipher simple replacement.

The most frequently used key is "GA-DE-RY-PO-LU-KI".

 G => A
 g => a
 a => g
 A => G
 D => E
  etc.
The letters, which are not on the list of substitutes, stays in the encrypted text without changes.

Task

Your task is to help scouts to encrypt and decrypt thier messages. Write the Encode and Decode functions.

Input/Output

The input string consists of lowercase and uperrcase characters and white . The substitution has to be case-sensitive.
 */

using System.Collections.Generic;
using System.Linq;


namespace CodeWarsSolutions.SevenKyu
{

    public class CypherEasy
    {
        private static Dictionary<char, char> myDictionary = new Dictionary<char, char>()
        { {'G','A'},{'A','G'},{'g','a'},{'a','g'},
          {'D','E'},{'E','D'},{'d','e'},{'e','d'},
          {'R','Y'},{'Y','R'},{'r','y'},{'y','r'},
          {'P','O'},{'O','P'},{'p','o'},{'o','p'},
          {'L','U'},{'U','L'},{'l','u'},{'u','l'},
          {'K','I'},{'I','K'},{'k','i'},{'i','k'}
          };

        public static string Encode(string str)
        {
            return string.Concat(str.Select(c => myDictionary.ContainsKey(c) ? myDictionary[c] : c));
        }

        public static string Decode(string str)
        {
            return Encode(str);
        }
    }
}
