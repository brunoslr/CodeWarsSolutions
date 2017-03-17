using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.SevenKyu
{
    class ReverseFirst
    {
        public int[] FirstReverseTry(int[] arr)
        {
            if (arr.Length < 2) return arr;
            arr[0] += arr[arr.Length - 1];
            arr[arr.Length - 1] = arr[0] - arr[arr.Length - 1];
            arr[0] -= arr[arr.Length - 1];
            return arr;
        }
    }
}
