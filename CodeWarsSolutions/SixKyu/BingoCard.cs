/* URL: https://www.codewars.com/kata/bingo-card/train/csharp
 
After yet another dispute on their game the Bingo Association decides to change course and automize the game.
Can you help the association by writing a method to create a random Bingo card?

Task:

Finish method:
BingoCard.GetCard()
A Bingo card contains 24 unique and random numbers according to this scheme:
5 numbers from the B column in the range 1 to 15
5 numbers from the I column in the range 16 to 30
4 numbers from the N column in the range 31 to 45
5 numbers from the G column in the range 46 to 60
5 numbers from the O column in the range 61 to 75

The card must be returned as an array of Bingo style numbers:
{ "B14", "B12", "B5", "B6", "B3", "I28", "I27", ... }
The numbers must be in the order of their column: B, I, N, G, O. Within the columns the order of the numbers is random.
*/

using System;
using System.Collections.Generic;

namespace CodeWarsSolutions.SixKyu
{
    public class BingoCard
    {
        public static Random rnd = new Random();

        public static string[] GetCard()
        {
            List<string> card = new List<string>();
            card.AddRange(GenerateBingoRow(1, 15, 5, 'B'));
            card.AddRange(GenerateBingoRow(16, 30, 5, 'I'));
            card.AddRange(GenerateBingoRow(31, 45, 4, 'N'));
            card.AddRange(GenerateBingoRow(46, 60, 5, 'G'));
            card.AddRange(GenerateBingoRow(61, 75, 5, 'O'));
            return card.ToArray();
        }

        public static List<int> GenerateRandomListInOrder(int min, int max, int size)
        {
            List<int> randomList = new List<int>();
            int randomValue;
            for (int i = 0; i < size; i++)
            {
                do
                {
                    randomValue = rnd.Next(min, max);
                } while (randomList.Contains(randomValue));

                randomList.Add(randomValue);
            }
            return randomList;
        }

        public static List<string> GenerateBingoRow(int min, int max, int size, char rowLetter)
        {
            List<string> row = new List<string>();
            foreach (int value in GenerateRandomListInOrder(min, max, size))
            {
                row.Add($"{rowLetter}{value}");
            }
            return row;
        }
    }
}
