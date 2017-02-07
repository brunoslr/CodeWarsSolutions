﻿/*URl: https://www.codewars.com/kata/srot-the-inner-ctonnet-in-dsnnieedcg-oredr/train/csharp
 Srot the inner ctnnoet in dsnnieedcg oredr

You have to sort the inner content of every word of a string in descending order.
The inner content is the content of a word without first and the last char.

Some examples:

"sort the inner content in descending order" -> "srot the inner ctonnet in dsnnieedcg oredr"
"wait for me" -> "wiat for me"
"this kata is easy" -> "tihs ktaa is esay"
The string will never be null and will never be empty.
It will contain only lowercase-letters and whitespaces. 


Have fun coding it and please don't forget to vote and rank this kata! :-)

I have also created other katas. Take a look if you enjoyed this kata!
 */

using System;
using System.Linq;

namespace CodeWarsSolutions.Beta
{
    public class OrderTheInnerStrings
    {
        public static string SortTheInnerContent(string words)
        {
            return string.Join(" ", words.Split(' ')
              .Select(SortInnerContentSingleString).ToList());
        }

        public static string SortInnerContentSingleString(string word)
        {
            if (word.Length < 4)
                return word;

            return $"{word.Substring(0, 1)}{string.Concat(word.Substring(1, word.Length - 2).OrderByDescending(x => x))}{word.Substring(word.Length - 1)}";
        }
    }
}
