using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Beta
{

    public class Candies
    {
        public static int CountCandies(int startingAmount, int newEvery)
        {
            int currentAmount = startingAmount;
            int eaten = 0;
            while(currentAmount >= newEvery)
            {
                var newCandyAmount = currentAmount / newEvery;
               
                eaten += newEvery * newCandyAmount;


                currentAmount = currentAmount % newEvery + newCandyAmount;
              
            }

            return eaten + currentAmount;
        }


    }
}
