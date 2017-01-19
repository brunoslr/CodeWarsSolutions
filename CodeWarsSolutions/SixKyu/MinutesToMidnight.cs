﻿/*URL: https://www.codewars.com/kata/minutes-to-midnight/train/csharp
 Teemo is not really excited about the new year's eve, but he has to celebrate it with his friends anyway. 

He has a really big passion about programming and he want's to be productive till midnight. He want's to know how many minutes he has left to work on his new project.
He doesn't want to look on the clock all the time, so he thought about a function, which returns him the number of minutes.

Can you write him a function, so he can stay productive? 

The function
minutesToMidnight(d)
will take a date object as parameter. Return the number of minutes in the following format: 

"x minute(s)" 

You will always get a date object with of today with a random timestamp. 
You have to round the number of minutes. 
Milliseconds doesn't matter!

Some examples:

10.00 am => "840 minutes"
23.59 pm => "1 minute" 

This kata is part of the Collection "Date fundamentals":
 */
 
using System;

namespace CodeWarsSolutions.SixKyu
{
    public class Minute
    {
        public string countMinutes(DateTime d)
        {

            TimeSpan difference = DateTime.Today.AddDays(1) - d;

            return $"{Math.Round(difference.TotalMinutes)} minute{((int)difference.TotalMinutes > 1 ? "s":"")}";
        }
    }
}
