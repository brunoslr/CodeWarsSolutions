/*
 Make sure you have a base case ↴ ! Otherwise your function may never terminate!

Breakdown
Let's break the problem into subproblems. How could we re-phrase the problem of getting all permutations for "cats" in terms of a smaller but similar subproblem?
Let's make our subproblem be getting all permutations for all characters except the last one. If we had all permutations for "cat," how could we use that to generate all permutations for "cats"?
We could put the "s" in each possible position for each possible permutation of "cat"!
These are our permutations of "cat":

 cat
cta
atc
act
tac
tca
For each of them, we add "s" in each possible position. So for "cat":

  cat
    scat
    csat
    cast
    cats
And for "cta":

  cta
    scta
    csta
    ctsa
    ctas
And so on.

Now that we can break the problem into subproblems, we just need a base case and we have a recursive algorithm!

Solution
If we're making all permutations for "cat," we take all permutations for "ca" and then put "t" in each possible position in each of those permutations. We use this approach recursively:

  using System.Collections.Generic;
using System.Linq;

public ISet<string> GetPermutations(string inputString)
{
    // Base case
    if (inputString.Length <= 1)
    {
        return new HashSet<string>(inputString.Select(c => new string(c, 1)));
    }

    var allCharsExceptLast = inputString.Substring(0, inputString.Length - 1);
    char lastChar = inputString[inputString.Length - 1];

    // Recursive call: get all possible permutations for all chars except last
    var permutationsOfAllCharsExceptLast = GetPermutations(allCharsExceptLast);

    // Put the last char in all possible positions for each of the above permutations
    var permutations = new HashSet<string>();
    foreach (var permutationOfAllCharsExceptLast in permutationsOfAllCharsExceptLast)
    {
        for (int position = 0; position <= allCharsExceptLast.Length; position++)
        {
            var permutation = permutationOfAllCharsExceptLast.Substring(0, position)
                + lastChar
                + permutationOfAllCharsExceptLast.Substring(position);
            permutations.Add(permutation);
        }
    }

    return permutations;
}

Bonus
How does the problem change if the string can have duplicate characters?
What if we wanted to bring down the time and/or space costs?
What We Learned
This is one where playing with a sample input is huge. Sometimes it helps to think of algorithm design as a two-part process: first figure out how you would solve the problem "by hand," as though the input was a stack of paper on a desk in front of you. Then translate that process into code.
 
 */
using System.Collections.Generic;
using System.Linq;

namespace InterviewCakeSolutions.WeeklySolutions
{
    class RecursiveStringPermutations
    {

        public ISet<string> GetPermutations(string inputString)
        {
            // Base case
            if (inputString.Length <= 1)
            {
                return new HashSet<string>(inputString.Select(c => new string(c, 1)));
            }

            var allCharsExceptLast = inputString.Substring(0, inputString.Length - 1);
            char lastChar = inputString[inputString.Length - 1];

            // Recursive call: get all possible permutations for all chars except last
            var permutationsOfAllCharsExceptLast = GetPermutations(allCharsExceptLast);

            // Put the last char in all possible positions for each of the above permutations
            var permutations = new HashSet<string>();
            foreach (var permutationOfAllCharsExceptLast in permutationsOfAllCharsExceptLast)
            {
                for (int position = 0; position <= allCharsExceptLast.Length; position++)
                {
                    var permutation = permutationOfAllCharsExceptLast.Substring(0, position)
                        + lastChar
                        + permutationOfAllCharsExceptLast.Substring(position);
                    permutations.Add(permutation);
                }
            }

            return permutations;
        }
    }
}
