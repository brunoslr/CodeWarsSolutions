/*
 Description:

Mount the Bowling Pins!

Task:

Did you ever play Bowling? Short: You have to throw a bowl into 10 Pins arranged like this:


I I I I  # each Pin has a Number:    7 8 9 10
 I I I                                4 5 6
  I I                                  2 3
   I                                    1

You will get an Array with Numbers, e.g.: [3,5,9] and remove them from the field like this:


I I   I
 I   I
  I
   I

Return a string with the current field.
Note that:

You begin a new line with \n
Each Line must be 7 chars long
Fill the missing pins with a whitespace
Have fun!
 */
using System.Text.RegularExpressions;

namespace CodeWarsSolutions.SixKyu
{
    public class Bowling
    {
        public string BowlingPins(int[] arr)
        {

            string laneSetup = "7 8 9 0\n 4 5 6 \n  2 3  \n   1   ";

            foreach (int pin in arr)
            {
                laneSetup = Regex.Replace(laneSetup, $"{pin % 10}", " ");
            }

            return Regex.Replace(laneSetup, @"\d", "I");
        }
    }
}
