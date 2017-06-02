using System.Text.RegularExpressions;

namespace CodeWarsSolutions.SevenKyu
{
    public static class CovfefeClass
    {
        public static string Covfefe(string tweet) => Regex.IsMatch(tweet, "coverage") ?
               Regex.Replace(tweet, "coverage", "covfefe") : tweet + " covfefe";
    }
}
