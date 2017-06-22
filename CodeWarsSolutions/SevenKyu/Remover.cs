/* URL: https://www.codewars.com/kata/remove-the-minimum/train/csharp
 
 */
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers) => numbers.Where((x, i) => i != numbers.IndexOf(numbers.Min())).ToList();

    }
}
