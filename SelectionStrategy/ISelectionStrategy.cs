using System.Collections.Generic;

namespace GeneticAlgorithm.SelectionStrategy
{
    public interface ISelectionStrategy<TOrganism, TChromosome> where TOrganism : IOrganism<TChromosome> where TChromosome : IChromosome
    {
        TOrganism SelectParent(IList<TOrganism> parents);
    }
}
