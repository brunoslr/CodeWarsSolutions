﻿/* URL: https://www.codewars.com/kata/fruit-machine/train/csharp
Slot machine (American English), informally fruit machine (British English), puggy (Scottish English slang), 
the slots (Canadian and American English), poker machine (or pokies in slang) (Australian English and New Zealand English) 
or simply slot (American English), is a casino gambling machine with three or more reels which spin when a button is pushed.
Slot machines are also known as one-armed bandits because they were originally operated by one lever on the side of the machine 
as distinct from a button on the front panel, and because of their ability to leave the player in debt and impoverished. 
Many modern machines are still equipped with a legacy lever in addition to the button. (Source Wikipedia)

Task

You will be given three reels of different images and told at which index the reels stop. From this information your job is to return the score of the resulted reels.
Rules
1. There are always exactly three reels
2. Each reel has 10 different items.
3. The three reel inputs may be different.
4. The spin array represents the index of where the reels finish.
5. The three spin inputs may be different
6. Three of the same is worth more than two of the same
7. Two of the same plus one "Wild" is double the score.
8. No matching items returns 0.
Scoring

Item    Three of the same   Two of the same     Two of the same plus one Wild
Wild            100                 10                  N/A
Star            90                  9                   18
Bell            80                  8                   16
Shell           70                  7                   14
Seven           60                  6                   12
Cherry          50                  5                   10
Bar             40                  4                   8
King            30                  3                   6
Queen           20                  2                   4
Jack            10                  1                   2
 
Returns

 	Return an integer of the score.
Example

Initialise

Kata kata = new Kata();
string[] reel1 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
string[] reel2 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
string[] reel3 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };
int[] spins = new int[] { 5, 5, 5 };
int result = kata.fruit(reels, spins);
Scoring

reel1[5] == "Cherry"
reel2[5] == "Cherry"
reel3[5] == "Cherry"

Cherry + Cherry + Cherry == 50
Return
result == 50 */

using System.Collections.Generic;
using System;

namespace CodeWarsSolutions.SixKyu
{
    public class SlotMachine
    {
        private static Dictionary<string, int> myDictionary = new Dictionary<string, int>
        {
            {"Wild",10},
            {"Star",9},
            {"Bell",8},
            {"Shell",7},
            {"Seven",6},
            {"Cherry",5},
            {"Bar",4},
            {"King",3},
            {"Queen",2},
            {"Jack",1}
        };

        public int fruit(List<string[]> reels, int[] spins)
        {

            string[] results = new string[] { reels[0][spins[0]], reels[1][spins[1]], reels[2][spins[2]] };
            Array.Sort(results);

            if (results[0] == results[1] && results[1] == results[2])
                return myDictionary[results[1]] * 10;

            if (results[0] == results[1] || results[1] == results[2])
            {
                int wildMultiplier = 1;
                if (results[2] == "Wild" && results[1] != "Wild") wildMultiplier = 2;

                return myDictionary[results[1]] * wildMultiplier;
            }
            return 0;
        }
    }
}