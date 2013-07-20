using System.Collections.Generic;
using System.Linq;
using GeneticAlgorithm.Criteria;
using GeneticAlgorithm.CrossoverStrategy;
using GeneticAlgorithm.SelectionStrategy;
using GeneticAlgorithm.SelectionStrategy.Selectors;

namespace GeneticAlgorithm
{
    public class PopulationGenerator<TOrganism, TChromosome> where TOrganism : IOrganism<TChromosome> where TChromosome : IChromosome
    {
        private readonly List<TOrganism> _parents;
        private readonly int _numberOfChildrenToCreate;
        private readonly ICrossoverStrategy<TOrganism, TChromosome> _crossoverStrategy;
        private readonly ISelectionStrategy<TOrganism, TChromosome> _selectionStrategy;
        private readonly ISelector _selector;

        public PopulationGenerator(List<TOrganism> parents, int numberOfChildrenToCreate, 
                                  ICrossoverStrategy<TOrganism, TChromosome> crossoverStrategy, 
                                  ISelectionStrategy<TOrganism, TChromosome> selectionStrategy,
                                  ISelector selector)
        {
            _parents = parents;
            _numberOfChildrenToCreate = numberOfChildrenToCreate;
            _crossoverStrategy = crossoverStrategy;
            _selectionStrategy = selectionStrategy;
            _selector = selector;
        }

        public List<TOrganism> Generate()
        {
            return _crossoverStrategy.CreateNewPopulation(_parents, _selectionStrategy, _selector, 100).ToList();
        }

        public string GetStatistics(IEnumerable<CriteriaBase<TOrganism, TChromosome>> criteria)
        {
            var average = _parents.Average(season => new CriteriaCalculator<TOrganism, TChromosome>(season, criteria).Calculate().Score);
            var min = _parents.Min(season => new CriteriaCalculator<TOrganism, TChromosome>(season, criteria).Calculate().Score);
            var max = _parents.Max(season => new CriteriaCalculator<TOrganism, TChromosome>(season, criteria).Calculate().Score);

            return "Min: " + min + ". Max: " + max + ". Average: " + average;
        }
    }
}
