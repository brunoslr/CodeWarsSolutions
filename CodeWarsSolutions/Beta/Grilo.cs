﻿/* Here we have the Grilo class. The grasshopper has a row of leafs and a initial leaf position. Every time he moves, 
// he eats the leaf he is currently at and hops to the second leaf on that direction
//Imagine a row of leaves (numbered 1 to N) and a grasshopper feeding on leaf X. After he eats leaf X, he will move either two leaves to the
//  left or two leaves to the right, skipping the leaves he ate. The grasshopper will always move to an existing leaf.

//   Implement a class that models the grasshopper's behaviour and can report its location at any time.

//   For example, Grilo(5, 2) creates a scenario with a row of 5 leaves (numbered 1 to 5) and a grasshopper feeding on leaf 2 (1 2* 3 4
//   5). A call to eatAndHopRight() marks the current leaf (leaf 2) as eaten and moves the grasshopper two leaves to the right to leaf 4 (1 3
//   4* 5). A call to eatAndHopLeft() marks the current leaf (leaf 4) as eaten and moves the grasshopper two leaves to the left to leaf 1 (1* 3
//   5), skipping leaves marked as eaten.

using System;

public class Grilo
{
    
    /// <summary>
    /// Initialization of view field with n leaves and grasshopper on leaf 'position'.
    /// </summary>
    /// <param name="n">Number of leaves in row.</param>
    /// <param name="position">Position.</param>
    public Grilo(int n, int position)
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    /// <summary>
    /// Grilo has eaten the current leaf and hopped left.
    /// </summary>
    public void ComerEPularEsquerda()
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    /// <summary>
    /// Grilo has eaten the current leaf and hopped right.
    /// </summary>
    public void ComerEPularDireita()
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    /// <returns>Leaf number that grasshopper is feeding on right now.</returns>
    public int OndeEstou()
    {
        throw new InvalidOperationException("Waiting to be implemented.");
    }

    public static void Main(string[] args)
    {
        Grilo g = new Grilo(10, 2);
        Console.WriteLine(g.OndeEstou());

        g.ComerEPularDireita();
        Console.WriteLine(g.OndeEstou());

        g.ComerEPularEsquerda();
        Console.WriteLine(g.OndeEstou());

        g.ComerEPularDireita();
        Console.WriteLine(g.OndeEstou());

        g.ComerEPularDireita();
        Console.WriteLine(g.OndeEstou());

        g.ComerEPularDireita();
        Console.WriteLine(g.OndeEstou());
    }
}
*/
/*
using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWarsSolutions.Beta
{
    public class Grilo
    {
        List<int> list = new List<int>();
        private int currentPos = 0;

        /// <summary>
        /// Initialization of view field with n leaves and grasshopper on leaf 'position'.
        /// </summary>
        /// <param name="n">Number of leaves in row.</param>
        /// <param name="position">Position.</param>
        public Grilo(int n, int position)
        {
            currentPos = position;

            list = Enumerable.Range(1, n).ToList();
        }

        /// <summary>
        /// Grilo has eaten the current leaf and hopped left.
        /// </summary>
        public void ComerEPularEsquerda()
        {
            int eat = currentPos;
            currentPos = list[list.IndexOf(currentPos) - 2];

            list.Remove(eat);
        }

        /// <summary>
        /// Grilo has eaten the current leaf and hopped right.
        /// </summary>
        public void ComerEPularDireita()
        {
            int eat = currentPos;
            currentPos = list[list.IndexOf(currentPos) + 2];

           list.Remove(eat);
        }

        /// <returns>Leaf number that grasshopper is feeding on right now.</returns>
        public int OndeEstou()
        {
            return currentPos;
        }

       /* public static void Main(string[] args)
        {
            Grilo g = new Grilo(10, 2);
            Console.WriteLine(g.OndeEstou());

            g.ComerEPularDireita();
            Console.WriteLine(g.OndeEstou());

            g.ComerEPularEsquerda();
            Console.WriteLine(g.OndeEstou());

            g.ComerEPularDireita();
            Console.WriteLine(g.OndeEstou());

            g.ComerEPularDireita();
            Console.WriteLine(g.OndeEstou());

            g.ComerEPularDireita();
            Console.WriteLine(g.OndeEstou());

            Console.ReadLine();
        }
    }
}
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWarsSolutions.Beta
{
    public class Grilo
    {
        //List<int> list = new List<int>();
        Dictionary<int, Tuple<int, int>> positions = new Dictionary<int, Tuple<int, int>>();
        private int currentPos = 0;
        private int positionsSize = 0;

        /// <summary>
        /// Initialization of view field with n leaves and grasshopper on leaf 'position'.
        /// </summary>
        /// <param name="n">Number of leaves in row.</param>
        /// <param name="position">Position.</param>
        public Grilo(int n, int position)
        {
            currentPos = position;
            positionsSize = n;
            positions = Enumerable.Range(1, n).ToDictionary(i => i, i => new Tuple<int,int>(i-1,i+1));
        }

        /// <summary>
        /// Update the positions dictionary.
        /// </summary>
        private void UpdatePositions()
        {
            if(positions[currentPos].Item1 > 0)
            positions[positions[currentPos].Item1] = new Tuple<int,int> (positions[positions[currentPos].Item1].Item1,positions[currentPos].Item2);

            if (positions[currentPos].Item2 < positionsSize)
                positions[positions[currentPos].Item2] = new Tuple<int, int>(positions[currentPos].Item1, positions[positions[currentPos].Item2].Item2);

        }

        /// <summary>
        /// Grilo has eaten the current leaf and hopped left.
        /// </summary>
        public void ComerEPularEsquerda()
        {
            UpdatePositions();
            currentPos = positions[positions[currentPos].Item1].Item1;
        }

        /// <summary>
        /// Grilo has eaten the current leaf and hopped right.
        /// </summary>
        public void ComerEPularDireita()
        {
            UpdatePositions();
            currentPos = positions[positions[currentPos].Item2].Item2;
        }

        /// <returns>Leaf number that grasshopper is feeding on right now.</returns>
        public int OndeEstou()
        {
            Console.WriteLine(currentPos);
            return currentPos;
        }
        
    }
}
