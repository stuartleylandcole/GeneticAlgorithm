using System.Collections.Generic;
using GeneticAlgorithm.SelectionStrategy;
using GeneticAlgorithm.SelectionStrategy.Selectors;

namespace GeneticAlgorithm.CrossoverStrategy
{
    public class SimpleCrossoverStrategy<TOrganism, TChromosome> : ICrossoverStrategy<TOrganism, TChromosome> where TOrganism: IOrganism<TChromosome> where TChromosome : IChromosome
    {
        public IList<TOrganism> CreateNewPopulation(IList<TOrganism> currentPopulation, ISelectionStrategy<TOrganism, TChromosome> selectionStrategy, ISelector selector,
                                         int numberOfChildrenToCreate)
        {
            throw new System.NotImplementedException();
        }
    }
}
