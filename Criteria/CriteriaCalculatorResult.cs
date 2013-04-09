using System.Collections.Generic;

namespace GeneticAlgorithm.Criteria
{
    public class CriteriaCalculatorResult<T, U> where T : IOrganism<U> where U : IChromosome
    {
        private readonly List<CriteriaBase<T, U>> _matchingCriteria;
        private readonly List<CriteriaBase<T, U>> _failedCriteria;
        private readonly int _score;

        public CriteriaCalculatorResult(List<CriteriaBase<T, U>> matchingCriteria, List<CriteriaBase<T, U>> failedCriteria, int score)
        {
            _matchingCriteria = matchingCriteria;
            _failedCriteria = failedCriteria;
            _score = score;
        }

        public bool IsValid
        {
            get { return _failedCriteria.Count == 0; }
        }

        public int Score
        {
            get { return _score; }
        }

        public List<CriteriaBase<T, U>> MatchingCriteria
        {
            get { return _matchingCriteria; }
        }

        public List<CriteriaBase<T, U>> FailedCriteria
        {
            get { return _failedCriteria; }
        }
    }
}
