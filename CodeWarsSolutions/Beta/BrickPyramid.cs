/* URL: https://www.codewars.com/kata/5836f1bb44ff28b068000ba4
Description:
Brick "pyramid".
"Pyramid" is infinite.
"Pyramid" is two-dimensional (triangle).

(row, pos) - function parameters.
row - top row number ranging from zero,
pos - brick number from left to right ranging from zero.

Brick weight - 1 kg.

Every brick equally presses the bricks underneath.
1/2 to the left brick and 1/2 to the right.

If the brick pressed above with the total mass of 100 kg, then the pressure is distributed evenly on the bottom bricks.

Required: implement function weight that calculates the pressure on the brick on the row, pos position. 
*/

namespace CodeWarsSolutions.Beta
{
    class BrickPyramid
    {
        public static double weight(int row, int pos)
        {

            if (pos < 0 || pos > row || row == 0) return 0;

            if (row == 1) return 0.5;

            double topLeft = weight(row - 1, pos - 1) / 2;
            double topRight = weight(row - 1, pos) / 2;

            return (topLeft > 0 ? topLeft + 0.5 : 0) + (topRight > 0 ? topRight + 0.5 : 0);
        }
    }
}
