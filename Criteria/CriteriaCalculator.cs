using System.Collections.Generic;

namespace GeneticAlgorithm.Criteria
{
    public class CriteriaCalculator<TOrganism, TChromosome> where TOrganism : IOrganism<TChromosome> where TChromosome : IChromosome
    {
        private readonly TOrganism _entity;
        private readonly IEnumerable<CriteriaBase<TOrganism, TChromosome>> _criteria;

        public CriteriaCalculator(TOrganism entity, IEnumerable<CriteriaBase<TOrganism, TChromosome>> criteria)
        {
            _entity = entity;
            _criteria = criteria;
        }

        public CriteriaCalculatorResult<TOrganism, TChromosome> Calculate()
        {
            var matchedCriteria = new List<CriteriaBase<TOrganism, TChromosome>>();
            var failedCriteria = new List<CriteriaBase<TOrganism, TChromosome>>();
            int score = 0;

            foreach (var criteria in _criteria)
            {
                score += criteria.CalculateScore(_entity);

                if (criteria.PassesCriteria(_entity))
                {
                    matchedCriteria.Add(criteria);
                }
                else
                {
                    failedCriteria.Add(criteria);
                }
            }

            return new CriteriaCalculatorResult<TOrganism, TChromosome>(matchedCriteria, failedCriteria, score);
        }
    }
}
