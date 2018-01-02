using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CodeWarsSolutions.EightKyu
{
    /* URL:https://www.codewars.com/kata/short-long-short/train/csharp
     Given 2 strings, a and b, return a string of the form short+long+short, 
     with the shorter string on the outside and the longer string on the inside. 
     The strings will not be the same length, but they may be empty (length).

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


    /* URL: https://www.codewars.com/kata/sushi-go-round-beginners/train/csharp
     * Sam has opened a new sushi train restaurant - a restaurant where sushi is served on plates that travel around the bar on a conveyor belt and customers take the plate that they like.
        Sam is using Glamazon's new visual recognition technology that allows a computer to record the number of plates at a customer's table and the colour of those plates. The number of plates is returned as a string. For example, if a customer has eaten 3 plates of sushi on a red plate the computer will return the string 'rrr'.
        Currently, Sam is only serving sushi on red plates as he's trying to attract customers to his restaurant. There are also small plates on the conveyor belt for condiments such as ginger and wasabi - the computer notes these in the string that is returned as a space ('rrr r' //denotes 4 plates of red sushi and a plate of condiment).
        Sam would like your help to write a program for the cashier's machine to read the string and return the total amount a customer has to pay when they ask for the bill. The current price for the dishes are as follows:
        Red plates of sushi ('r') - $2 each, but if a customer eats 5 plates the 5th one is free.
        Condiments (' ') - free.
        Input: String
        Output: Number
        Examples:
        Input: 'rr'  Output: 4
        Input: 'rr rrr' Output: 8
        Input: 'rrrrr rrrrr' Output: 16
    */
    public class SushiGoKata
    {
        public static int TotalBill(string str)
        {
            var sushiTotal = str.Count(c => c == 'r');
            return (sushiTotal - sushiTotal / 5) * 2;
        }
    }

    /*URL: https://www.codewars.com/kata/exclamation-marks-series-number-4-remove-all-exclamation-marks-from-sentence-but-ensure-a-exclamation-mark-at-the-end-of-string/csharp
     * Remove all exclamation marks from sentence but ensure a exclamation 
     * mark at the end of string. For a beginner kata, you can assume that 
     * the input data is always a non empty string, no need to verify it.
     */
    public class RemoveExclamations
    {
        public static string Remove(string s) => s.Replace("!", "") + "!";

        public static string RemoveOneFromEndOfLine(string s)
        {
            return System.Text.RegularExpressions.Regex.Replace(s, @"!$", "");
        }
    }

    /*Write a function that takes an array of strings as an argument 
     and returns a sorted array containing the same strings, ordered from shortest to longest.*/
    public class SortingKata
    {
        public static string[] SortByLength(string[] array)
        {
            return array.OrderBy(s => s.Length).ToArray();
        }
    }

    /* https://www.codewars.com/kata/vampire-numbers-1/csharp
     Vampire Numbers
     Our loose definition of Vampire Numbers can be described as follows:
 
     6 * 21 = 126
     # 6 and 21 would be valid 'fangs' for a vampire number as the 
     # digits 6, 1, and 2 are present in both the product and multiplicands
 
     10 * 11 = 110
     # 110 is not a vampire number since there are three 1's in the
     # multiplicands, but only two 1's in the product
     */
    static class VampireNumbers
    {
        public static bool vampire_test(long x, long y)
        {
            return String.Concat($"{x}{y}".OrderBy(c => c)) == String.Concat($"{x * y}".OrderBy(c => c));
        }
    }

    public class ToMoneyClass
    {
        public static string FormatMoney(double amount)
        {
            return String.Format(new CultureInfo("en-US"), "{0:C}", amount);
        }
    }

    /* URL: https://www.codewars.com/kata/odd-or-even/csharp
        Given an array of numbers, determine whether the sum of all of the numbers is odd or even.
        Give your answer in string format as 'odd' or 'even'.
        If the input array is empty consider it as: [0] (array with a zero).

        Example:

        oddOrEven([0]) returns "even"
        oddOrEven([2, 5, 34, 6]) returns "odd"
        oddOrEven([0, -1, -5]) returns "even"
    */
    public class EvenOrOdd
    {
        public static string OddOrEven(int[] array)
        {
            return array.Sum() % 2 == 0 ? "even" : "odd";
        }
    }

    /*
     Have you heard about the myth that if you fold a paper enough times, you can reach the moon with it? Sure you do, but exactly how many? Maybe it's time to write a program to figure it out.
        You know that a piece of paper has a thickness of 0.0001m. Given distance in units of meters, calculate how many times you have to fold the paper to make the paper reach this distance.
        (If you're not familiar with the concept of folding a paper: Each fold doubles its total thickness.)
        Note: Of course you can't do half a fold. You should know what this means ;P
        Also, if somebody is giving you a non-positive distance, it's clearly bogus and you should yell at them by returning null/NULL.
         */
    public class FoldingToTheMoon
    {
        public static int? FoldTo(double distance)
        {
            if (distance <= 0) return null;

            var currentThickness = 0.0001;
            var count = 0;
            while (currentThickness < distance)
            {
                count++;
                currentThickness *= 2;
            }
            return count;
        }
    }
    /* Round any given number to the closest 0.5 step
    I.E.

    solution(4.2) = 4
    solution(4.3) = 4.5
    solution(4.6) = 4.5
    solution(4.8) = 5
    Round up if number is as close to previous and next 0.5 steps.

    solution(4.75) == 5 */
    public class RoundByPointFiveSteps
    {
        public static double RoundZeroPointFive(double n)
        {
            return System.Math.Round(n * 2) / 2;
        }
    }

    /* URL: https://www.codewars.com/kata/javascript-array-filter/train/csharp 
    Starting with .NET Framework 3.5, C# supports a Where (in the System.Linq namespace) method which allows a user to filter arrays based on a predicate. Use the Where method to complete the function given.
    Enumerable.Where documentation: https://msdn.microsoft.com/en-us/library/bb534803(v=vs.110).aspx
     */
    public class FilterOddNumbers
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(a=>a%2==0).ToArray();
        }
    }

    /* Your task is to write a function maskify, which changes all but the last four characters into '#'.
        Examples
        Kata.Maskify('4556364607935616'); // should return "############5616"
        Kata.Maskify('64607935616');      // should return "#######5616"
        Kata.Maskify('1');                // should return "1"
        Kata.Maskify('');                 // should return ""
        // "What was the name of your first pet?"
        Kata.Maskify('Skippy');                                   // should return "##ippy"
        Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"
    */
    public static class MaskLastFourNumbers
    {
        public static string Maskify(string cc)
        {
            if (cc.Length < 5) return cc;

            return new string('#', cc.Length - 4) + cc.Substring(cc.Length - 4);
        }
    }

    /* You will be given an array (a) and a value (x). All you need to do is check whether the provided array contains the value.
    Array can contain numbers or strings. X can be either. Return true if the array contains the value, false if not.
     */
    public static class CheckContains
    {
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }
    }

    /*Given an input n, write a function always that returns a function which returns n. Ruby should return a lambda or a proc.
        Func<int> three = Kata.Always(3);
        three(); // returns 3      
    */
    public class FunctionWithinFunction
    {
        public static Func<int> Always(int n) =>
            () => n;

    }

}


