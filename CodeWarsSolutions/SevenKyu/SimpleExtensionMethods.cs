/* URL: https://www.codewars.com/kata/simple-extension-methods/train/csharp
    An extension method allows you to add a fuction to an exsisting type. (See: https://msdn.microsoft.com/en-us//library/bb383977.aspx for examples.) Your challenge for this Kata is to write two basic extention methods: SayHello and SayGoodbye.

    Examples:

    string name = "Kathy"
    name.SayHello() --> "Hello, Kathy!"
    name.SayGoodbye() --> "Goodbye, Kathy. See you again soon!"
    You will not be expected to handle any erroneous data in your solution.
 */

namespace CodeWarsSolutions.SevenKyu
{
    static class SimpleExtensions
    {
        public static string SayHello(this string name)
        {
            return $"Hello, {name}!";
        }

        public static string SayGoodbye(this string name)
        {
            return $"Goodbye, {name}. See you again soon!";
        }
    }
}