using System;
using System.Linq;

namespace CodeWarsSolutions.EightKyu
{
    /* URL:https://www.codewars.com/kata/short-long-short/train/csharp
     Given 2 strings, a and b, return a string of the form short+long+short, 
     with the shorter string on the outside and the longer string on the inside. 
     The strings will not be the same length, but they may be empty (length0).

        For example:

        ShortLongShort.Solution("1", "22"); // returns "1221"
        ShortLongShort.Solution("22", "1"); // returns "1221"  
            
     */

    public class ShortLongShort
    {
        public static string Solution(string a, string b)
        {
            return $"{(a.Length > b.Length ? b + a + b : a + b + a)}";
        }
    }

    /*URL: https://www.codewars.com/kata/smallest-unused-id/train/csharp
     Description:
     You've got much data to manage and of course you use zero-based and non-negative ID's to make each data item unique!

     Therefore you need a method, which returns the smallest unused ID for your next new data item...

     Note: The given array of used IDs may be unsorted. 
     For test reasons there may be duplicate IDs, but you don't have to find or remove them!
    */

    public class SmallestUnusedID
    {
        public static int NextId(int[] ids)
        {
            int i = 0;

            while (i < int.MaxValue)
            {
                if (!ids.Contains(i))
                    return i;
                i++;
            }
            return -1;
        }
    }

    /* URL: https://www.codewars.com/kata/localize-the-barycenter-of-a-triangle/train/csharp
    The medians of a triangle are the segments that unit the vertices with the midpoint of their opposite sides. The three medians of a triangle intersect at the same point, called the barycenter or the centroid. Given a triangle, defined by the cartesian coordinates of its vertices we need to localize its barycenter or centroid.
    The function bar_triang() or barTriang or bar-triang, receives the coordinates of the three vertices A, B and C as three different arguments and outputs the coordinates of the barycenter O in an array [xO, yO]
    This is how our asked function should work: the result of the coordinates should be expressed up to four decimals, (rounded result).
    You know that the coordinates of the barycenter are given by the following formulas.

    For additional information about this important point of a triangle see at: (https://en.wikipedia.org/wiki/Centroid)
    Let's see some cases:
    The given points form a real or a degenerate triangle but in each case the above formulas can be used.
    */
    public class Barycenter
    {
        public static double[] BarTriang(double[] x, double[] y, double[] z)
        {
            return new double[2] { Math.Round((x[0] + y[0] + z[0]) / 3, 4), Math.Round((x[1] + y[1] + z[1]) / 3, 4) };
        }
    }

    /* URL: https://www.codewars.com/kata/logical-calculator/train/csharp
    Your task is to calculate logical value of boolean array. Test arrays are one-dimensional and their size is in the range 1-50.
    Links referring to logical operations: AND, OR and XOR.
    First Example:
    Input: true, true, false, operator: AND
    Steps: true AND true -> true, true AND false -> false
    Output: false
    Second Example:
    Input: true, true, false, operator: OR
    Steps: true OR true -> true, true OR false -> true
    Output: true
    Third Example:
    Input: true, true, false, operator: XOR
    Steps: true XOR true -> false, false XOR false -> false
    Output: false
    Input:
    boolean array, string with operator' s name: 'AND', 'OR', 'XOR'.
    Output:
    calculated boolean
        */
    public class LogicalCalculator
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            switch (op)
            {
                case "AND":
                    return array.Aggregate((a, b) => a && b);
                case "OR":
                    return array.Aggregate((a, b) => a || b);
                case "XOR":
                    return array.Aggregate((a, b) => a ^ b);
                default:
                    return false;
            }
        }

    }
}