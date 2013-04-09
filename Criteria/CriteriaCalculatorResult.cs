using System.Collections.Generic;

namespace GeneticAlgorithm.Criteria
{
    public class CriteriaCalculatorResult<TOrganism, TChromosome> where TOrganism : IOrganism<TChromosome> where TChromosome : IChromosome
    {
        private readonly List<CriteriaBase<TOrganism, TChromosome>> _matchingCriteria;
        private readonly List<CriteriaBase<TOrganism, TChromosome>> _failedCriteria;
        private readonly int _score;

        public CriteriaCalculatorResult(List<CriteriaBase<TOrganism, TChromosome>> matchingCriteria, List<CriteriaBase<TOrganism, TChromosome>> failedCriteria, int score)
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

        public List<CriteriaBase<TOrganism, TChromosome>> MatchingCriteria
        {
            get { return _matchingCriteria; }
        }

        public List<CriteriaBase<TOrganism, TChromosome>> FailedCriteria
        {
            get { return _failedCriteria; }
        }
    }
}
