using System;
using System.Linq;

namespace GeneticAlgorithm.Criteria
{
    public abstract class CriteriaBase<TOrganism, TChromosome>
        where TOrganism : IOrganism<TChromosome> where TChromosome : IChromosome
    {
        public abstract string Description { get; }
        protected abstract Func<TChromosome, bool> Criteria { get; }
        protected abstract int Multiplier { get; }
        protected abstract bool Mandatory { get; }

        public bool PassesCriteria(TOrganism season)
        {
            var matchesFound = GetNumberOfCriteriaMatches(season) > 0;
            return !Mandatory || matchesFound;
        }

        public int CalculateScore(TOrganism season)
        {
            return GetNumberOfCriteriaMatches(season) * Multiplier;
        }

        private int GetNumberOfCriteriaMatches(TOrganism season)
        {
            return season.Chromosomes.Count(Criteria);
        }
    }
}
