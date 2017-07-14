/* URL: https://www.codewars.com/kata/turn-any-word-into-a-beef-taco/train/csharp
If you like Taco Bell, you will be familiar with their signature doritos locos taco. They're very good.
Why can't everything be a taco? We're going to attempt that here, turning every word we find into the taco bell recipe with each ingredient.
We want to input a word as a string, and return a list representing that word as a taco.
Key
all vowels (except 'y') = beef
t = tomato
l = lettuce
c = cheese
g = guacamole
s = salsa
NOTE
We do not care about case here. 'S' is therefore equivalent to 's' in our taco.
Ignore all other letters; we don't want our taco uneccesarily clustered or else it will be too difficult to eat.
Note that no matter what ingredients are passed, our taco will always have a shell.
 */
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsSolutions.SevenKyu
{
    public class TacofyClass
    {
        private static readonly Dictionary<char, string> _tacoBellDictionary = new Dictionary<char, string>()
        {
            {'a', "beef"},
            {'e', "beef"},
            {'i', "beef"},
            {'o', "beef"},
            {'u', "beef"},
            {'t', "tomato"},
            {'l', "lettuce"},
            {'c', "cheese"},
            {'g', "guacamole"},
            {'s', "salsa"}
        };

        public string[] Tacofy(string word)
        {
            var beefTaco = new List<string> {"shell"};

            beefTaco.AddRange(word.ToLower()
                .Where(x => _tacoBellDictionary.ContainsKey(x))
                .Select(c => _tacoBellDictionary[c]));

            /*foreach (char c in word.ToLower())
            {
                if (_tacoBellDictionary.ContainsKey(c))
                {
                    beefTaco.Add(_tacoBellDictionary[c]);
                }

            }*/
            beefTaco.Add("shell");
            return beefTaco.ToArray();
        }
    }
}
