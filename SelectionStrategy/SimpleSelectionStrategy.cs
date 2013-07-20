using System.Collections.Generic;
using GeneticAlgorithm.SelectionStrategy.Selectors;

namespace GeneticAlgorithm.SelectionStrategy
{
    public class SimpleSelectionStrategy<TOrganism, TChromosome> : ISelectionStrategy<TOrganism, TChromosome> 
        where TOrganism : IOrganism<TChromosome> 
        where TChromosome : IChromosome
    {
        public TOrganism SelectParent(IList<TOrganism> parents, ISelector selector)
        {
            return parents[selector.SelectInt(parents.Count - 1)];
        }
    }
}
