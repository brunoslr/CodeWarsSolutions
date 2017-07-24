using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions.Beta
{
    public class CandleKata
    {
        public static int Candles(int m, int n)
        {
            int initialQuantity = m;
            int leftOvers = 0;

            while(initialQuantity >= n)
            {
                var newCandles = initialQuantity / n;
               
                leftOvers += n * newCandles;


                initialQuantity = initialQuantity % n + newCandles;
              
            }

            return leftOvers + initialQuantity;
        }


    }
}
