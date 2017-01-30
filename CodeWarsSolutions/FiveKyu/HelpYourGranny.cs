/*Url:https://www.codewars.com/kata/help-your-granny/train/csharp
Your granny, who lives in town X0, has friends. These friends are given in an array, for example: array of friends is

[ "A1", "A2", "A3", "A4", "A5" ].
The order of friends is this array must not be changed since this order gives the order in which they will be visited.

These friends inhabit towns and you have an array with friends and towns, for example:

[ ["A1", "X1"], ["A2", "X2"], ["A3", "X3"], ["A4", "X4"] ]
or
(C)
{"A1", "X1", "A2", "X2", "A3", "X3", "A4", "X4"}
which means A1 is in town X1, A2 in town X2... It can happen that we don't know the town of one of the friends.

Your granny wants to visit her friends and to know how many miles she will have to travel.

You will make the circuit that permits her to visit her friends. For example here the circuit will contain:

X0, X1, X2, X3, X4, X0
and you must compute the total distance

X0X1 + X1X2 + .. + X4X0.
For the distance, fortunately, you have a map (and a hashmap) that gives each distance X0X1, X0X2 and so on. For example:

[ ["X1", 100.0], ["X2", 200.0], ["X3", 250.0], ["X4", 300.0] ]
or (Coffeescript, Javascript)
['X1',100.0, 'X2',200.0, 'X3',250.0, 'X4',300.0 ]
or
(C)
{"X1", "100.0", "X2", "200.0", "X3", "250.0", "X4", "300.0"}
which means that X1 is at 100.0 miles from X0, X2 at 200.0 miles from X0, etc...

More fortunately (it's not real life, it's a story...), the towns X0, X1, ..Xn are placed in the following manner:

X0X1X2 is a right triangle with the right angle in X1, X0X2X3 is a right triangle with the right angle in X2, etc...

If a town Xi is not visited you will suppose that the triangle

X0Xi-1Xi+1 is still a right triangle.

(Ref: https://en.wikipedia.org/wiki/Pythagoras#Pythagorean_theorem)

Task

Can you help your granny and give her the distance to travel?

All languages

The data type of the parameters can be seen in the examples test cases.

"tour" returns an int which is the floor of the total distance. 

public class Tour
        {
            public static int tour(string[] arrFriends, string[][] ftwns, Hashtable h)
            {
                // your code
                return -1;
            }
        }
 Example Test:
 
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class TourTests {

[Test]
  public void Test1() {
    string[] friends1 = new string[] { "A1", "A2", "A3", "A4", "A5" };
    string[][] fTowns1 = { new string[] { "A1", "X1" }, new string[] { "A2", "X2" }, new string[] { "A3", "X3" }, new string[] { "A4", "X4" } };
    Hashtable distTable1 = new Hashtable { { "X1", 100.0 }, { "X2", 200.0 }, { "X3", 250.0 }, { "X4", 300.0 } };
    Assert.AreEqual(889, Tour.tour(friends1, fTowns1, distTable1));
  }
}       


 */

using System.Collections;
using System;
using System.Linq;

namespace CodeWarsSolutions.FiveKyu
{
    public class Tour
    {
        public static int tour(string[] arrFriends, string[][] ftwns, Hashtable h)
        {
            string currentTown = ftwns.Where(arr => arr[0] == arrFriends[0]).First()[1].ToString();
            int previousTownDistance = Convert.ToInt32(h[currentTown]);
            int currentTownDistance = previousTownDistance;

            //Total distance for the first friend you visit
            double totalDistance = previousTownDistance;
            for (int i = 1; i < arrFriends.Length; i++)
            {
                previousTownDistance = currentTownDistance;
                var friendsTown = ftwns.Where(arr => arr[0] == arrFriends[i]);
                currentTown = (friendsTown.Count() > 0) ? friendsTown.First()[1].ToString() : "X0";
                currentTownDistance = Convert.ToInt32(h[currentTown]);
                Console.WriteLine($"Friend:{arrFriends[i]} CurrentTown: {currentTown} TownDistanceFromX0: {Convert.ToInt32(h[currentTown])}, PreviousTownDistanceFromX0:{previousTownDistance}");
                totalDistance += Math.Sqrt(Math.Abs(currentTownDistance * currentTownDistance - previousTownDistance * previousTownDistance));

                //If the last town is not your hometown go back home =)
                if (i == arrFriends.Length - 1 && currentTown != "X0")
                    totalDistance += currentTownDistance;
            }

            return (int)totalDistance;
        }
    }

}
