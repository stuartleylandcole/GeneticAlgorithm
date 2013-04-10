using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm.Criteria;

namespace GeneticAlgorithm.SelectionStrategy
{
    public class TournamentSelection<TOrganism, TChromosome> : ISelectionStrategy<TOrganism, TChromosome> 
        where TOrganism : IOrganism<TChromosome> 
        where TChromosome : IChromosome
    {
        // ReSharper disable StaticFieldInGenericType
        private static readonly Random Random = new Random();
        // ReSharper restore StaticFieldInGenericType

        private readonly double _selectionLimit;
        private readonly IEnumerable<CriteriaBase<TOrganism, TChromosome>> _criteria;

        public TournamentSelection(double selectionLimit, IEnumerable<CriteriaBase<TOrganism, TChromosome>> criteria)
        {
            _selectionLimit = selectionLimit;
            _criteria = criteria;
        }

        public TOrganism SelectParent(IList<TOrganism> parents)
        {
            var selectedParents = new List<TOrganism>
                {
                    parents[Random.Next(0, parents.Count)],
                    parents[Random.Next(0, parents.Count)]
                };

            var orderedParents = selectedParents.OrderByDescending(
                organism => new CriteriaCalculator<TOrganism, TChromosome>(organism, _criteria).Calculate().Score);

            if (Random.NextDouble() < _selectionLimit)
            {
                return orderedParents.First();
            }

            return orderedParents.Last();
        }
    }
}
