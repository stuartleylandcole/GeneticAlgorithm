using System.Collections.Generic;

namespace GeneticAlgorithm.Criteria
{
    public class CriteriaCalculator<T, U> where T : IOrganism<U> where U : IChromosome
    {
        private readonly T _entity;
        private readonly IEnumerable<CriteriaBase<T, U>> _criteria;

        public CriteriaCalculator(T entity, IEnumerable<CriteriaBase<T, U>> criteria)
        {
            _entity = entity;
            _criteria = criteria;
        }

        public CriteriaCalculatorResult<T, U> Calculate()
        {
            var matchedCriteria = new List<CriteriaBase<T, U>>();
            var failedCriteria = new List<CriteriaBase<T, U>>();
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

            return new CriteriaCalculatorResult<T, U>(matchedCriteria, failedCriteria, score);
        }
    }
}
