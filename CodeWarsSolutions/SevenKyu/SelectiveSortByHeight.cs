/*URL: https://www.codewars.com/kata/simple-fun-number-88-sort-by-height/train/csharp
 * Task

Some people are standing in a row in a park. There are trees between them which cannot be moved.

Your task is to rearrange the people by their heights in a non-descending order without moving the trees.
Example

For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be

[-1, 150, 160, 170, -1, -1, 180, 190].
Input/Output

[input] integer array a

If a[i] = -1, then the ith position is occupied by a tree. Otherwise a[i] is the height of a person standing in the ith position.

Constraints:

5 ≤ a.length ≤ 30,

-1 ≤ a[i] ≤ 200.
[output] an integer array

Sorted array a with all the trees untouched.*/
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public class SelectiveSortByHeight
    {
        public int[] SortByHeight(int[] a)
        {

            var sortedHeightStack = new Stack<int>(a.Where(i => i > -1).OrderByDescending(i => i));
            for (int i = 0; i < a.Length; i++)
                if (a[i] != -1) a[i] = sortedHeightStack.Pop();

            return a;
        }
    }
 
}
