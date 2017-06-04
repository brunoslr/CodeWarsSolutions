using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Beta
{
    class TwoSum
    {

        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            var lookup = list.Select((x, i) => new { Index = i, Value = x })
                    .ToDictionary( x => x.Value, x => x.Index);

            for (int i = 0; i < list.Count; i++)
            {
                int diff = sum - list[i];
                if (lookup.ContainsKey(diff))
                    return Tuple.Create(i, lookup[diff]);
            }

            return null;
        }


        public static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}
