﻿/* URL: https://www.codewars.com/kata/alphabet-war/train/csharp
There is a war and nobody knows - the alphabet war! 
There are two groups of hostile letters. The tension between left side letters and right side letters was too high and the war began.
Task
Write a function that accepts fight string consists of only small letters and return who wins the fight. When the left side wins return Left side wins!, when the right side wins return Right side wins!, in other case return Let's fight again!.
The left side letters and thier power:
 w  - 4
 p  - 3 
 b  - 2
 s  - 1
The right side letters and thier power:
 m  - 4
 q  - 3 
 d  - 2
 z  - 1
The other letters don't have power and are only victims.
 */
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    class AlphabetWars
    {
        private static readonly Dictionary<char, int> alphabetWarPoints = new Dictionary<char, int>{
        {'w',4},{'p',3},{'b',2},{'s',1},{'m',-4},{'q',-3},{'d',-2},{'z',-1}};

        public static string AlphabetWar(string fight)
        {
            var fightSum = fight.Sum(c => alphabetWarPoints.ContainsKey(c) ? alphabetWarPoints[c] : 0);
            return fightSum > 0 ?
                "Left side wins!" : fightSum == 0 ? "Let's fight again!" : "Right side wins!";
        }
    }
}
