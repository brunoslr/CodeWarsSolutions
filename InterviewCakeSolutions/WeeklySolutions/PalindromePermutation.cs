﻿/* Write an efficient function that checks whether any permutation ↴ of an input string is a palindrome ↴ .
Examples:

"civic" should return true
"ivicc" should return true
"civil" should return false
"livci" should return false
"But 'ivicc' isn't a palindrome!"
If you had this thought, read the question again carefully. We're asking if any permutation of the string is a palindrome. Spend some extra time ensuring you fully understand the question before starting. Jumping in with a flawed understanding of the problem doesn't look good in an interview.
Gotchas
We can do this in O(n)O(n) time.

Breakdown
The brute force ↴ approach would be to check every permutation of the input string to see if it is a palindrome.

What would be the time cost? For a string of length n, there are n!n! permutations (nn choices for the first character, times n-1n−1 choices for the second character, etc). Checking each length-nn permutation to see if it's a palindrome involves checking each character, taking O(n)O(n) time. That gives us O(n!n)O(n!n) time overall. We can do better!

Let's try rephrasing the problem. How can we tell if any permutation of a string is a palindrome?

Well, how would we check that a string is a palindrome? We could use the somewhat-common "keep two pointers" pattern. We'd start a pointer at the beginning of the string and a pointer at the end of the string, and check that the characters at those pointers are equal as we walk both pointers towards the middle of the string.

civic
^   ^

civic
 ^ ^

civic
  ^
Can we adapt the idea behind this approach to checking if any permutation of a string is a palindrome?

Notice: we're essentially checking that each character left of the middle has a corresponding copy right of the middle.

We can simply check that each character appears an even number of times (unless there is a middle character, which can appear once or some other odd number of times). This ensures that the characters can be ordered so that each char on the left side of the string has a matching char on the right side of the string.

But we'll need a data structure to keep track of the number of times each character appears. What should we use?

We could use a dictionary. (Tip: using a dictionary is the most common way to get from a brute force approach to something more clever. It should always be your first thought.)

So we’ll go through all the characters and track how many times each character appears in the input string. Then we just have to make sure no more than one of the characters appears an odd numbers of times.

That will give us a runtime of O(n)O(n), which is the best we can do since we have to look at a number of characters dependent on the length of the input string.

Ok, so we’ve reached our best run time. But can we still clean our solution up a little?

We don’t really care how many times a character appears in the string, we just need to know whether the character appears an even or odd number of times.

What if we just track whether or not each character appears an odd number of times? Then we can map characters to booleans. This will be more explicit (we don’t have to check each number’s parity, we already have booleans) and we’ll avoid the risk of integer overflow ↴ if some characters appear a high number of times.

Can we take this a step further and clean it up even more?

Even more specifically than whether characters appear an even or odd number of times, we really just need to know there isn’t more than one character that appears an odd number of times.

What if we only track the characters that appear an odd number of times? Is there a data structure even simpler than a dictionary we could use?

We could use a hash set, adding and removing characters as we look through the input string, so the hash set always only holds the characters that appear an odd number of times.

Solution
Our approach is to check that each character appears an even number of times, allowing for only one characters to appear an odd number of times (a middle character). This is enough to determine if a permutation of the input string is a palindrome.

We iterate through each character in the input string, keeping track of the characters we’ve seen an odd number of times using a hash set unpairedCharacters.

As we iterate through the characters in the input string:

If the character is not in unpairedCharacters, we add it.
If the character is already in unpairedCharacters, we remove it.
Finally, we just need to check if less than two characters don’t have a pair.

Complexity
O(n)O(n) time, since we're making one iteration through the nn characters in the string.
Our unpairedCharacters hash set is the only thing taking up non-constant space. We could say our space cost is O(n)O(n) as well, since the set of unique characters is less than or equal to nn. But we can also look at it this way: there are only so many different characters. How many? The ASCII character set has just 128 different characters (standard english letters and punctuation), while Unicode has 110,000 (supporting several languages and some icons/symbols). We might want to treat our number of possible characters in our character hash set as another variable kk and say our space complexity is O(k)O(k). Or we might want to just treat it as a constant, and say our space complexity is O(1)O(1).

What We Learned
One of the tricks was to use a dictionary or hash set.

This is the most common way to get from a brute force approach to something more efficient. Especially for easier problems.
I even know interviewers who just want to hear you say "dictionary", and once they hear that they'll say, "Great, let's move on."
So always ask yourself, right from the start: "Can I save time by using a dictionary?"
 */

using System.Collections.Generic;

namespace InterviewCakeSolutions
{
    class PalindromePermutation
    {
        public bool HasPalindromePermutation(string theString)
        {
            // Track characters we've seen an odd number of times
            var unpairedCharacters = new HashSet<char>();

            foreach (char c in theString)
            {
                if (unpairedCharacters.Contains(c))
                {
                    unpairedCharacters.Remove(c);
                }
                else
                {
                    unpairedCharacters.Add(c);
                }
            }

            // The string has a palindrome permutation if it
            // has one or zero characters without a pair
            return unpairedCharacters.Count <= 1;
        }
        
    }
}