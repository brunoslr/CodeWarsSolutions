/* AC
//Here we have the Grasshopper class. The grasshopper has a row of leafs and a initial leaf position. Every time he moves, 
// he eats the leaf he is currently at and hops to the second leaf on that direction
//Imagine a row of leaves (numbered 1 to N) and a grasshopper feeding on leaf X. After he eats leaf X, he will move either two leaves to the
//  left or two leaves to the right, skipping the leaves he ate. The grasshopper will always move to an existing leaf.

//   Implement a class that models the grasshopper's behaviour and can report its location at any time.

//   For example, Grasshopper(5, 2) creates a scenario with a row of 5 leaves (numbered 1 to 5) and a grasshopper feeding on leaf 2 (1 2* 3 4
//   5). A call to eatAndHopRight() marks the current leaf (leaf 2) as eaten and moves the grasshopper two leaves to the right to leaf 4 (1 3
//   4* 5). A call to eatAndHopLeft() marks the current leaf (leaf 4) as eaten and moves the grasshopper two leaves to the left to leaf 1 (1* 3
//   5), skipping leaves marked as eaten.

using System;

public class Grasshopper
{
    
    /// <summary>
    /// Initialization of view field with n leaves and grasshopper on leaf 'position'.
    /// </summary>
    /// <param name="n">Number of leaves in row.</param>
    /// <param name="position">Position.</param>
    public Grasshopper(int n, int position)
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    /// <summary>
    /// Grasshopper has eaten the current leaf and hopped left.
    /// </summary>
    public void EatAndHopLeft()
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    /// <summary>
    /// Grasshopper has eaten the current leaf and hopped right.
    /// </summary>
    public void EatAndHopRight()
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    /// <returns>Leaf number that grasshopper is feeding on right now.</returns>
    public int WhereAmI()
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    public static void Main(string[] args)
    {
        Grasshopper g = new Grasshopper(10, 2);
        Console.WriteLine(g.WhereAmI());

        g.EatAndHopRight();
        Console.WriteLine(g.WhereAmI());

        g.EatAndHopLeft();
        Console.WriteLine(g.WhereAmI());

        g.EatAndHopRight();
        Console.WriteLine(g.WhereAmI());

        g.EatAndHopRight();
        Console.WriteLine(g.WhereAmI());

        g.EatAndHopRight();
        Console.WriteLine(g.WhereAmI());
    }
}
*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWarsSolutions.Beta
{
    public class Grasshopper
    {
        List<int> list = new List<int>();
        private int currentPos = 0;

        /// <summary>
        /// Initialization of view field with n leaves and grasshopper on leaf 'position'.
        /// </summary>
        /// <param name="n">Number of leaves in row.</param>
        /// <param name="position">Position.</param>
        public Grasshopper(int n, int position)
        {
            currentPos = position;

            list = Enumerable.Range(1, n).ToList();
        }

        /// <summary>
        /// Grasshopper has eaten the current leaf and hopped left.
        /// </summary>
        public void EatAndHopLeft()
        {
            int eat = currentPos;
            currentPos = list[list.IndexOf(currentPos) - 2];

            list.Remove(eat);
        }

        /// <summary>
        /// Grasshopper has eaten the current leaf and hopped right.
        /// </summary>
        public void EatAndHopRight()
        {
            int eat = currentPos;
            currentPos = list[list.IndexOf(currentPos) + 2];

           list.Remove(eat);
        }

        /// <returns>Leaf number that grasshopper is feeding on right now.</returns>
        public int WhereAmI()
        {
            return currentPos;
        }

       /* public static void Main(string[] args)
        {
            Grasshopper g = new Grasshopper(10, 2);
            Console.WriteLine(g.WhereAmI());

            g.EatAndHopRight();
            Console.WriteLine(g.WhereAmI());

            g.EatAndHopLeft();
            Console.WriteLine(g.WhereAmI());

            g.EatAndHopRight();
            Console.WriteLine(g.WhereAmI());

            g.EatAndHopRight();
            Console.WriteLine(g.WhereAmI());

            g.EatAndHopRight();
            Console.WriteLine(g.WhereAmI());

            Console.ReadLine();
        }*/
    }
}

