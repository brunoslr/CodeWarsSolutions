/*URL:https://www.codewars.com/kata/correct-the-time-string/train/csharp
A new task for you!
You have to create a method, that corrects a given time string. There was a problem in addition, so many of the time strings are broken. Time-Format is european. So from "00:00:00" to "23:59:59". 
Some examples:
"09:10:01" -> "09:10:01"
"11:70:10" -> "12:10:10"
"19:99:99" -> "20:40:39"
"24:01:01" -> "00:01:01"
If the input-string is null or empty return exactly this value! (empty string for C++)
If the time-string-format is invalid, return null. (empty string for C++)
Have fun coding it and please don't forget to vote and rank this kata! :-)
I have created other katas. Have a look if you like coding and challenges.
 */

using System;

namespace CodeWarsSolutions.SevenKyu
{
    public static class TimeString
    {
        public static string Correct(string timeString)
        {
            if (String.IsNullOrEmpty(timeString)) return timeString;

            string[] timeArray = timeString.Split(':');

            if (timeArray.Length < 3)
                return null;

            try
            {
                int seconds = int.Parse(timeArray[2]) % 60;
                int extraMinutesFromSeconds = int.Parse(timeArray[2]) / 60;
                int minutes = (int.Parse(timeArray[1]) + extraMinutesFromSeconds) % 60;
                int extraHoursFromMinutes = (int.Parse(timeArray[1]) + extraMinutesFromSeconds) / 60;
                int hours = (int.Parse(timeArray[0]) + extraHoursFromMinutes) % 24;
                return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }

            catch (System.FormatException) { return null; }

            catch { return "I should not be here"; }

        }
    }
}
