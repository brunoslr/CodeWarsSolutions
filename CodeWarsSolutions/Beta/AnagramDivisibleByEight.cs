/* In this exercise you need to develop a method that checks if a given string value containing only numbers
 * can be rearranged in any way that their value would be divisible by 8.
 * (Given a array of strings return develop a function that returns "YES" or "NO" for each element, 
 * if any anagram of the given string contains a number divisible by 8)
 * Ex:87654321 can be rearranged as  13567248 which is divisible by 8 so it should return "YES"
 * 11113333 does not contain any possible anagrams which are divisible by 8 so it should return "NO"
*/

//using System;

//class AnagramDivisibleByEight
//{
//    /*
//     * Complete the function below.
//     */
//    static string[] checkDivisibility(string[] arr)
//    {
//        throw new NotImplementedException();
//    }
//    static void Main(String[] args)
//    {
//        string[] res;

//        int _arr_size = 2;

//        string[] _arr = { "123454", "104243" };

//        res = checkDivisibility(_arr);
//        for (int res_i = 0; res_i < res.Length; res_i++)
//        {
//            Console.WriteLine(res[res_i]);
//        }

//    }
//}

using System.Text.RegularExpressions;

class AnagramDivisiblebyEight
{

    static string[] checkDivisibility(string[] arr)
    {
        string[] result = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = checkDivisibilityByEight(arr[i]);
        }

        return result;
    }

    private static string checkDivisibilityByEight(string anagram)
    {

        if (checkWordContainsRegexPermutation(anagram, "[6]", "[159]", "[02468]") ||
            checkWordContainsRegexPermutation(anagram, "[4]", "[26]", "[02468]") ||
            checkWordContainsRegexPermutation(anagram, "[2]", "[37]", "[02468]") ||
            checkWordContainsRegexPermutation(anagram, "[08]", "[48]", "[02468]") ||
            checkWordContainsRegexPermutation(anagram, "[2]", "[159]", "[13579]") ||
            checkWordContainsRegexPermutation(anagram, "[08]", "[26]", "[13579]") ||
            checkWordContainsRegexPermutation(anagram, "[6]", "[37]", "[13579]") ||
            checkWordContainsRegexPermutation(anagram, "[4]", "[48]", "[13579]"))
            return "YES";

        return "NO";
    }


    private static bool checkWordContainsRegexPermutation(string anagram, string a, string b, string c)
    {
        if (Regex.IsMatch(anagram, $"({a}(.*{b}.*{c}|.*{c}.*{b}))") ||
            Regex.IsMatch(anagram, $"({b}(.*{a}.*{c}|.*{c}.*{a}))") ||
            Regex.IsMatch(anagram, $"({c}(.*{b}.*{a}|.*{a}.*{b}))"))
            return true;

        return false;
    }

    /*static void Main(String[] args)
    {
        string[] res;

        int _arr_size = 2;

        string[] _arr = { "12345678", "13579141", "11112559", "75345779", "13579141", "11115559" };

        res = checkDivisibility(_arr);
        for (int res_i = 0; res_i < res.Length; res_i++)
        {
            Console.WriteLine(res[res_i]);
        }

    }*/
}


