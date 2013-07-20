using System;
using System.Collections.Generic;

namespace GeneticAlgorithm.SelectionStrategy.Selectors
{
    public class RandomSelector : ISelector
    {
        private static readonly Random Random = new Random();

        public int SelectInt(int max)
        {
            return Random.Next(0, max);
        }

        public double SelectDouble()
        {
            return Random.NextDouble();
        }
    }
}
