using System.Collections.Generic;

namespace GeneticAlgorithm
{
    public interface IOrganism<TChromosome> where TChromosome : IChromosome
    {
        IEnumerable<TChromosome> Chromosomes { get; }
    }
}
