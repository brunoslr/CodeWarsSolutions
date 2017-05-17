/* URL: https://www.hackerrank.com/challenges/saveprincess2
 In this version of "Bot saves princess", Princess Peach and bot's position are randomly set. Can you save the princess?

Task

Complete the function nextMove which takes in 4 parameters - an integer N, integers r and c indicating the row & column position of the bot and the character array grid - and outputs the next move the bot makes to rescue the princess.

Input Format

The first line of the input is N (<100), the size of the board (NxN). The second line of the input contains two space separated integers, which is the position of the bot.

Grid is indexed using Matrix Convention

The position of the princess is indicated by the character 'p' and the position of the bot is indicated by the character 'm' and each cell is denoted by '-' (ascii value: 45).

Output Format

Output only the next move you take to rescue the princess. Valid moves are LEFT, RIGHT, UP or DOWN

Sample Input

5
2 3
-----
-----
p--m-
-----
-----
Sample Output

LEFT
Resultant State

-----
-----
p-m--
-----
-----
Explanation

As you can see, bot is one step closer to the princess.

Scoring 
Your score for every testcase would be (NxN minus number of moves made to rescue the princess)/10 where N is the size of the grid (5x5 in the sample testcase). Maximum score is 17.5
 */

using System;
using System.Linq;


namespace HackerRankSolutions.AI.BotBuilding
{
    class SavePrincess2
    {
        static void nextMove(int n, int r, int c, String[] grid)
        {
            var mario = new int[2] { r, c };

            var peach = GetPositionInGraph(n, grid);

            if (!Enumerable.SequenceEqual(mario, peach))
            {
                MoveMarioTowardsPeach(mario, peach);
            }
        }

        private static int[] GetPositionInGraph(int n, string[] grid)
        {
            int[] peach = new int[2];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 'p')
                    {
                        peach[0] = i;
                        peach[1] = j;

                        return peach;
                    }
                }
            }
            return peach;
        }

        private static void MoveMarioTowardsPeach(int[] mario, int[] peach)
        {
            if (mario[1] > peach[1])
            {
                Console.WriteLine("LEFT");
            }
            else if (mario[1] < peach[1])
            {
                Console.WriteLine("RIGHT");
            }
            else if (mario[0] > peach[0])
            {
                Console.WriteLine("UP");
            }
            else if (mario[0] < peach[0])
            {
                Console.WriteLine("DOWN");
            }
        }

        static void Main(String[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            String pos;
            pos = Console.ReadLine();
            String[] position = pos.Split(' ');
            int[] int_pos = new int[2];
            int_pos[0] = Convert.ToInt32(position[0]);
            int_pos[1] = Convert.ToInt32(position[1]);
            String[] grid = new String[n];
            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            nextMove(n, int_pos[0], int_pos[1], grid);

        }
    }
}
