/* AC - 2016
//Given a string containing a paragraph with a date in the format MM/DD/YYYY, return the same 
// paragraph with the date in the format DD/MM/YYYY
using System;

public class Paragraph
{
    public static string ChangeDateFormat(string paragraph)
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(ChangeDateFormat("Last time it rained was on 07/25/2013 and today is 08/09/2013."));
    }
}

*/

using System;
using System.Text.RegularExpressions;

namespace CodeWarsSolutions.Beta
{
    public class Kata
    {
        public static string ChangeDateFormat(string paragraph)
        {
            return Regex.Replace(paragraph, @"\b(\d{2})/(\d{2})/(\d{4})\b", "${2}/${1}/${3}");
            //return Regex.Replace(paragraph, @"(?<month>\d{2})/(?<day>\d{2})/(?<year>\d{4})", @"${day}/${month}/${year}"); ;
        }

       /* public static void Main(string[] args)
        {
            Console.WriteLine(ChangeDateFormat("Last time it rained was on 07/08/2016 and today is 01/25/2017."));
            Console.ReadLine();
        }*/
    }    
}
