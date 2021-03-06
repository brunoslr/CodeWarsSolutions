﻿/* URL: https://www.codewars.com/kata/manage-the-robot-factory-day-1/train/csharp
Explanation

Its your first day in the robot factory. Your supervisor thinks that you should start with an easy task. So you are responsible for purchasing rawmaterials needed to produce the robots.
A full functional robot weights 50 kilogramm. Iron is the only material needed to create a robot. All iron is inserted in the first machine. The output of this machine is the input for the next one and so on. The whole process is sequentiell. Unfortunately not all machines are first class. So a given percentage of their inputs are destroyed during processing.

Task
You need to figure out, how much kilogramm of iron you need to buy to build the requested number of robots.
Example

Three machines are used to create a robot. Each of them produces 10% scrap. Your target is to deliver 90 robots. So the method will be called with the following parameters:
CalculateScrap(scrapOfTheUsedMachines, numberOfRobotsToProduce)
CalculateScrap(int[] { 10, 10, 10 }, 90)
Assumptions

The scrap is less than 100%.
The scrap is never negative.
There is at least one machine in the manufacturing line.
Except for scrap there is no material lost during manufacturing.
The number of produced robots is always a positive number.
You can only buy full kilogramms of iron.
*/
using System;

namespace CodeWarsSolutions.SixKyu
{

    public sealed class ManageRobotFactory
    {
        public long CalculateScrap(int[] scraps, int numberOfRobots)
        {
            double totalRobots = numberOfRobots;
            for (int i = scraps.Length - 1; i >= 0; i--)
            {
                totalRobots = totalRobots / (100 - scraps[i]) * 100;
            }
            return (long)Math.Ceiling(totalRobots * 50);
        }
    }
}
