﻿/* URL: https://www.codewars.com/kata/simple-fun-number-106-is-thue-morse/train/csharp
Given a sequence of 0s and 1s, determine if it is a prefix of Thue-Morse sequence.
The infinite Thue-Morse sequence is obtained by first taking a sequence containing a single 0 and then repeatedly concatenating the current sequence with its binary complement.
A binary complement of a sequence X is a sequence Y of the same length such that the sum of elements X_i and Y_i on the same positions is equal to 1 for each i.
Thus the first few iterations to obtain Thue-Morse sequence are:
0
0 1
0 1 1 0
0 1 1 0 1 0 0 1
...
Examples
For seq=[0, 1, 1, 0, 1], the result should be true.
For seq=[0, 1, 0, 0], the result should be false.
Inputs & Output
[input] integer array seq
An non-empty array.
Constraints:
1 <= seq.length <= 1000
seq[i] ∈ [0,1]
[output] a boolean value
true if it is a prefix of Thue-Morse sequence. false otherwise.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    class ThueMorse
    { 
        public bool IsThueMorse(int[] seq)
        {
            var thueMorse = new List<int>() { 0 };
            while (thueMorse.Count() < seq.Length)
                thueMorse.AddRange(thueMorse.Select(b => (b == 0) ? 1 : 0).ToList());

            for (int i = 0; i < seq.Length; i++)
            {
                if (thueMorse[i] != seq[i]) return false;
            }

            return true;
        }
    }
}
