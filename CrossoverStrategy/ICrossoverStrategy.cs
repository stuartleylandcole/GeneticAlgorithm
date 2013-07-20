using System.Collections.Generic;
using GeneticAlgorithm.SelectionStrategy;
using GeneticAlgorithm.SelectionStrategy.Selectors;

namespace GeneticAlgorithm.CrossoverStrategy
{
    public interface ICrossoverStrategy<TOrganism, TChromosome> where TOrganism : IOrganism<TChromosome> where TChromosome : IChromosome
    {
        IList<TOrganism> CreateNewPopulation(IList<TOrganism> currentPopulation,
                                             ISelectionStrategy<TOrganism, TChromosome> selectionStrategy,
                                             ISelector selector,
                                             int numberOfChildrenToCreate);
    }
}
