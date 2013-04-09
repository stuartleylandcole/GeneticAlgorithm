using System.Collections.Generic;

namespace GeneticAlgorithm
{
    public interface IOrganism<T> where T : IChromosome
    {
        IEnumerable<T> Chromosomes { get; }
    }
}
