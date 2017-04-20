using System;
using System.Collections.Generic;

namespace CodeWarsSolutions.SixKyu
{
    public class SplitStringKata
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1)
                str = str + "_";
            var strList = new List<string>();
            for (int i = 0; i < str.Length; i += 2)
            {
                strList.Add(str.Substring(i, 2));
            }

            return strList.ToArray();
        }
    }
}
