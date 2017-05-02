/* URL: https://www.codewars.com/kata/sort-my-animals/train/csharp
 
Consider the following class:
  public class Animal
  {
    public string Name { get; set; }
    public int NumberOfLegs { get; set; }
  }
Write a method that accepts a list of objects of type Animal, 
and returns a new list. The new list should be a copy of the original list, 
sorted first by the animal's number of legs, and then by its name.
If null is passed, the method should return null. If an empty list is passed,
it should return an empty list back.  
 */
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{

    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }

    public class AnimalSorter
    {
        public List<Animal> Sort(List<Animal> input)
        {
            if (input == null || input.Count < 2)
                return input;

            return input.OrderBy(x => x.NumberOfLegs).ThenBy(x => x.Name).ToList();
        }
    }
}