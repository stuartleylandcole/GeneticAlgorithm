using System.Collections.Generic;

namespace GeneticAlgorithm.SelectionStrategy
{
    public interface ISelectionStrategy<T, U> where T : IOrganism<U> where U : IChromosome
    {
        T SelectParent(IList<T> parents);
    }
}
