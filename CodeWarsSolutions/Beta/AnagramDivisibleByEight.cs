/* Given a array of strings containing each a sequence of numbers. 
* Develop a function that return a array of "YES" or "NO" for each string , 
* if any anagram of the given string contains a number divisible by 8
*/

using System;

class AnagramDivisibleByEight
{
    /*
     * Complete the function below.
     */
    static string[] checkDivisibility(string[] arr)
    {
        throw new NotImplementedException();
    }
    static void Main(String[] args)
    {
        string[] res;

        int _arr_size = 2;

        string[] _arr = { "123454", "104243" };

        res = checkDivisibility(_arr);
        for (int res_i = 0; res_i < res.Length; res_i++)
        {
            Console.WriteLine(res[res_i]);
        }

    }
}



