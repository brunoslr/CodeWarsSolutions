using System;
using System.Collections.Generic;
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

    /* URL: https://www.codewars.com/kata/how-many-stairs-will-suzuki-climb-in-20-years/train/csharp
     Suzuki is a monk who climbs a large staircase to the monastery as part of a ritual. Some days he climbs more stairs than others depending on the number of students he must train in the morning. He is curious how many stairs might be climbed over the next 20 years and has spent a year marking down his daily progress.
    The sum of all the stairs logged in a year will be used for estimating the number he might climb in 20.
    20_year_estimate = one_year_total * 20
    You will receive the following data structure representing the stairs Suzuki logged in a year. You will have all data for the entire year so regardless of how it is logged the problem should be simple to solve.
    stairs = [sunday,monday,tuesday,wednesday,thursday,friday,saturday]
    Make sure your solution takes into account all of the nesting within the stairs array.
    Each weekday in the stairs array is an array.
    sunday = [6737, 7244, 5776, 9826, 7057, 9247, 5842, 5484, 6543, 5153, 6832, 8274, 7148, 6152, 5940, 8040, 9174, 7555, 7682, 5252, 8793, 8837, 7320, 8478, 6063, 5751, 9716, 5085, 7315, 7859, 6628, 5425, 6331, 7097, 6249, 8381, 5936, 8496, 6934, 8347, 7036, 6421, 6510, 5821, 8602, 5312, 7836, 8032, 9871, 5990, 6309, 7825]
    Your function should return the 20 year estimate of the stairs climbed using the formula above.
    */
    public class SuzukiStairs
    {
        public static long StairsIn20(int[][] stairs)
        {
            return 20 * stairs.Sum(wd => wd.Aggregate(0, (a, b) => a + b));
        }
    }

    /* URL: https://www.codewars.com/kata/remove-exclamation-marks/train/csharp
      Write function RemoveExclamationMarks which removes all exclamation marks from a given string. 
    */
    public static class RemoveExclamationMark
    {
        public static string RemoveExclamationMarks(string s) => s.Replace("!", "");
    }

    /* URL: https://www.codewars.com/kata/remove-string-spaces/train/csharp
      Simple, remove the spaces from the string, then return the resultant string.
     */
    public class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
    }

    /*Calculate the product of all elements in an array.
    If the array is null, you should throw ArgumentNullException and if the array is empty, you should throw InvalidOperationException.
    As a challenge, try writing your method in just one line of code. It's possible to have only 36 characters within your method.
     */
    public class ArrayMath
    {
        public static int Product(int[] values) => values.Aggregate((i, j) => i * j);
    }

    /*The objective of 'Duck, duck, goose' is to walk in a circle, tapping on each player's head until one is finally chosen. 
    Task: Given an array of Player objects (an array of associative arrays in PHP) and an index (1-based), return the name of the chosen Player. 

    Example:
    duck_duck_goose([a, b, c, d], 1) should return a.name
    duck_duck_goose([a, b, c, d], 5) should return a.name
    duck_duck_goose([a, b, c, d], 4) should return d.name
    */
    public class DuckDuckGooseClass
    {
        public static string DuckDuckGoose(DdgPlayer[] players, int goose)
        {

            return players[(goose % players.Length == 0) ? players.Length - 1 : goose % players.Length - 1].Name;
        }
    }
    public class DdgPlayer
    {
        public string Name { get; set; }

        public DdgPlayer(string name)
        {
            this.Name = name;
        }
    }

    /* URL: https://www.codewars.com/kata/sum-of-values-from-1-to-n-inclusive-%7B-nsn-equals-1-%7D/csharp
     In this Kata , your job is to write a program that finds the sum of the numbers from 1 to n.
    total(10) => 55
    total(20) => 210
    total(34) => 595
    If you are unsure of what output you got, You can use console.log("Your output") to check
    { My first Kata , So hope you like it }
    */
    public class SumOfValuesFromOneToNInclusive
    {
        public static long Total(long n) => ((1 + n) * n) / 2;
    }

    /*
    Write function sumList (or sum_list) which will calculate the sum of the elements of the given list (or array in Javascript and C).
    For example:
    [1, 2, 3] -> 1 + 2 + 3 -> 6
    */
    public static class SumListOfValues
    {
        public static int SumList(List<int> list)
        {
            return list.Aggregate(0, (a, b) => a + b);
        }
    }
}
