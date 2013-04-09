using System;
using System.Collections.Generic;

namespace GeneticAlgorithm.SelectionStrategy
{
    public class SimpleSelectionStrategy<T, U> : ISelectionStrategy<T, U> where T : IOrganism<U> where U : IChromosome
    {
        // ReSharper disable StaticFieldInGenericType
        private static readonly Random Random = new Random();
        // ReSharper restore StaticFieldInGenericType

        public T SelectParent(IList<T> parents)
        {
            return parents[Random.Next(0, parents.Count - 1)];
        }
    }
}
