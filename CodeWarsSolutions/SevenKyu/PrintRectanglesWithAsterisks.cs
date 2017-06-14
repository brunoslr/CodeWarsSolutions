/* URL:https://www.codewars.com/kata/print-a-rectangle-using-asterisks/train/csharp
Write a method that, given two arguments, width and height, returns a string representing a rectangle with those dimensions.
The rectangle should be filled with spaces, and its borders should be composed of asterisks (*).
For example, the following call:
GetRectangleString(3, 3);
Should return the following string:
***
* *
***
End each line of the string (including the last one) with a carriage return-line feed combination.
Note: You may assume that width and height will always be greater than zero.
*/
using System.Collections.Generic;

namespace CodeWarsSolutions.SevenKyu
{

    public class PrintRectanglesWithAsterisks
    {
        public string GetRectangleString(int width, int height)
        {
            List<string> rectangle = new List<string>();
            string endline = "\r\n";
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                    rectangle.Add(new string('*', width) + endline);

                else
                {
                    rectangle.Add("*" + new string(' ', width - 2) + "*" + endline);
                }

            }
            return string.Concat(rectangle);
        }
    }
}
