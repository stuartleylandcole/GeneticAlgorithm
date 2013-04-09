using System.Collections.Generic;
using System.Linq;
using GeneticAlgorithm.Criteria;
using GeneticAlgorithm.CrossoverStrategy;
using GeneticAlgorithm.SelectionStrategy;

namespace GeneticAlgorithm
{
    public class PopulationGenerator<T, U> where T : IOrganism<U> where U : IChromosome
    {
        private readonly List<T> _parents;
        private readonly int _numberOfChildrenToCreate;
        private readonly ICrossoverStrategy<T, U> _crossoverStrategy;
        private readonly ISelectionStrategy<T, U> _selectionStrategy;

        public PopulationGenerator(List<T> parents, int numberOfChildrenToCreate, ICrossoverStrategy<T, U> crossoverStrategy, ISelectionStrategy<T, U> selectionStrategy)
        {
            _parents = parents;
            _numberOfChildrenToCreate = numberOfChildrenToCreate;
            _crossoverStrategy = crossoverStrategy;
            _selectionStrategy = selectionStrategy;
        }

        public List<T> Generate()
        {
            var newPopulation = new List<T>();
            for (int i = 0; i < _numberOfChildrenToCreate; i++)
            {
                var parent1 = _selectionStrategy.SelectParent(_parents);
                var parent2 = _selectionStrategy.SelectParent(_parents);

                var child = _crossoverStrategy.CrossOver(parent1, parent2);
                newPopulation.Add(child);
            }

            return newPopulation;
        }

        public string GetStatistics(IEnumerable<CriteriaBase<T, U>> criteria)
        {
            var average = _parents.Average(season => new CriteriaCalculator<T, U>(season, criteria).Calculate().Score);
            var min = _parents.Min(season => new CriteriaCalculator<T, U>(season, criteria).Calculate().Score);
            var max = _parents.Max(season => new CriteriaCalculator<T, U>(season, criteria).Calculate().Score);

            return "Min: " + min + ". Max: " + max + ". Average: " + average;
        }
    }
}
