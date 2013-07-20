using System.Collections.Generic;

namespace GeneticAlgorithm
{
    public interface IOrganism<TChromosome> where TChromosome : IChromosome
    {
        IList<TChromosome> Chromosomes { get; }
    }
}
