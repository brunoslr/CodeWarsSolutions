using System;
using System.Collections.Generic;
using System.Linq;

/*URL:https://www.codewars.com/kata/genetic-algorithm-series-number-5-roulette-wheel-selection/train/csharp
 The "Roulette wheel selection", also known as "Fitness proportionate selection", is a genetic operator used in genetic algorithms for selecting potentially useful solutions for recombination.
Your task is to implement it.

You throw a coin in and has a chance to fall in one of the slots, the higher the fitness the higher the chance the element has to be selected.
Given the population and fitnesses, your task is to run the roulette to return one element.
Note: Some tests are random. If you think your algorithm is correct but the result fails, trying again should work.     
*/

namespace CodeWarsSolutions.SixKyu
{
    public class GeneticAlgorithmSeries_Selection
    {
        Random rnd = new Random();
        public string Select(IEnumerable<string> population, IEnumerable<double> fitnesses)
        {
            if (population.Count() == 0)
                return "";

            string selectedChromosome = population.ElementAt(0);
            double maxFitness = 0;
            double currentFitness = 0;

            for (int i = 0; i < population.Count(); i++)
            {
                currentFitness = fitnesses.ElementAt(i) * rnd.Next();
                if (currentFitness > maxFitness)
                {
                    maxFitness = currentFitness;
                    selectedChromosome = population.ElementAt(i);
                }
            }
            return selectedChromosome;
        }
    }
}
