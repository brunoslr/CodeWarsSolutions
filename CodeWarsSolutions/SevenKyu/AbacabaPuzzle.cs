/* URL: https://www.codewars.com/kata/simple-fun-number-114-abacaba/train/csharp
Consider the following algorithm for constructing 26 strings S(1) .. S(26):
S(1) = "a";
For i in [2, 3, ..., 26]:
S(i) = S(i - 1) + character(i) + S(i - 1).
For example:
S(1) = "a"
S(2) = S(1) + "b" + S(1) = "a" + "b" + "a" = "aba"
S(3) = S(2) + "c" + S(2) = "aba" + "c" +"aba" = "abacaba"
S(26) = S(25) + "z" + S(25)
Finally, we got a long string S(26). Your task is to find the kth symbol (indexing from 1) in the string S(26). All strings consist of lowercase letters only.
Input / Output
[input] integer k
1 ≤ k < 226
[output] a string(char in C#)
the kth symbol of S(26)
 */

namespace CodeWarsSolutions.SevenKyu
{
    class AbacabaPuzzle
    {
        public char abacaba(int k)
        {

            if (k == 0) return '?';

            char symbol = 'a';

            while ((k & 1) == 0) //k%2==0
            {
                symbol++;
                k >>= 1; //Shift right divide by 2
            }

            return symbol;

        }
    }
}

