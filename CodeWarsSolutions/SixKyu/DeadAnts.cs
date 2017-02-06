/* URL: https://www.codewars.com/kata/dead-ants/train/csharp
An orderly trail of ants is marching across the park picnic area.

It looks something like this:
..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..
But suddenly there is a rumour that a dropped chicken sandwich has been spotted on the ground ahead. The ants surge forward! Oh No, it's an ant stampede!!
Some of the slower ants are trampled, and their poor little ant bodies are broken up into scattered bits.
The resulting carnage looks like this:
...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t
Can you find how many ants have died?

Notes
When in doubt, assume that the scattered bits are from the same ant. e.g. 2 heads and 1 body = 2 dead ants, not 3
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsSolutions.SixKyu
{
    class DeadAnt
    {
        public static int DeadAntCount(string ants)
        {
            if (ants == null)
                return 0;

            string stomped = String.Concat(Regex.Replace(ants, "ant", ""));
            stomped = String.Concat(Regex.Replace(stomped, @"[^ant]", "").OrderBy(x => x));
            if (stomped == "")
                return 0;

            return stomped.Select((c, el) => (stomped.IndexOf(c) == el) ? stomped.Count(x => x == c) : 0).Max();
        }
    }
}