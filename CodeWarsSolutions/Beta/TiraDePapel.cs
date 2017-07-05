using System;
using System.Linq;

namespace CodeWarsSolutions.Beta
{
    public class TiraDePapel
    {
        public static int MinimoDePecas(int[] original, int[] desired)
        {
            var desiredDictionary = desired.Select((x, i) => new { Value = x, Index = i }).ToDictionary(x => x.Value, x=> x.Index) ;
            var minPieces = original.Length;

            for (int i = 0; i< original.Length -1; i++)
            {
                if (desiredDictionary[original[i]] < desired.Length - 1 && desired[desiredDictionary[original[i]] + 1] == original[i + 1])
                    minPieces--; 
            }

            return minPieces; 
 //                original.Length - 
   //             original.Where((x, i) => desiredDictionary[](desired, x) < desired.Length - 1 
     //                   && i < original.Length - 1 && original[i + 1] == desired[Array.IndexOf(desired, x) +1] ).Count();

           // return original.Length -
           //    original.Where((x, i) => desired.Where((y, j) => x == y && j < desired.Length - 1 && i < original.Length - 1 && original[i + 1] == desired[j + 1]).Count() > 0).Count();

        }

        
    }
}
