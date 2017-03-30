/* URL: https://www.codewars.com/kata/build-tower/train/csharp
 * Build Tower

Build Tower by the following given argument:
number of floors (integer and always greater than 0).

Tower block is represented as *

Python: return a list;
JavaScript: returns an Array;
C#: returns a string[];
PHP: returns an array;
C++: returns a vector<string>;
Haskell: returns a [String];
Have fun!

for example, a tower of 3 floors looks like below

[
  '  *  ', 
  ' *** ', 
  '*****'
]
and a tower of 6 floors looks like below

[
  '     *     ', 
  '    ***    ', 
  '   *****   ', 
  '  *******  ', 
  ' ********* ', 
  '***********'
]
 */
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    public class BuildTower
    {
        public static string[] TowerBuilder(int n) => Enumerable.Range(1, n)
        .Select(x => $"{new string(' ', n - x)}{new string('*', 2 * x - 1)}{new string(' ', n - x)}").ToArray();
    }
}
