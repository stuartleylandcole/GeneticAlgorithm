using System;
using System.Collections.Generic;

namespace GeneticAlgorithm.SelectionStrategy
{
    public class SimpleSelectionStrategy<TOrganism, TChromosome> : ISelectionStrategy<TOrganism, TChromosome> where TOrganism : IOrganism<TChromosome> where TChromosome : IChromosome
    {
        // ReSharper disable StaticFieldInGenericType
        private static readonly Random Random = new Random();
        // ReSharper restore StaticFieldInGenericType

        public TOrganism SelectParent(IList<TOrganism> parents)
        {
            return parents[Random.Next(0, parents.Count - 1)];
        }
    }
}
