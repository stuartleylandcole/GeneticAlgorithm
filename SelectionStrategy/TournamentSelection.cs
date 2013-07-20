using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm.Criteria;
using GeneticAlgorithm.SelectionStrategy.Selectors;

namespace GeneticAlgorithm.SelectionStrategy
{
    public class TournamentSelection<TOrganism, TChromosome> : ISelectionStrategy<TOrganism, TChromosome> 
        where TOrganism : IOrganism<TChromosome> 
        where TChromosome : IChromosome
    {
        private readonly double _selectionLimit;
        private readonly IEnumerable<CriteriaBase<TOrganism, TChromosome>> _criteria;

        public TournamentSelection(double selectionLimit, IEnumerable<CriteriaBase<TOrganism, TChromosome>> criteria)
        {
            _selectionLimit = selectionLimit;
            _criteria = criteria;
        }

        public TOrganism SelectParent(IList<TOrganism> parents, ISelector selector)
        {
            var selectedParents = new List<TOrganism>
                {
                    parents[selector.SelectInt(parents.Count-1)],
                    parents[selector.SelectInt(parents.Count-1)]
                };

            var orderedParents = selectedParents.OrderByDescending(
                organism => new CriteriaCalculator<TOrganism, TChromosome>(organism, _criteria).Calculate().Score);

            if (selector.SelectDouble() < _selectionLimit)
            {
                return orderedParents.First();
            }

            return orderedParents.Last();
        }
    }
}
