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


    }
}
