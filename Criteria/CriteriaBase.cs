using System;
using System.Linq;

namespace GeneticAlgorithm.Criteria
{
    //public abstract class CriteriaBase<T>
    //    where T : IOrganism
    public abstract class CriteriaBase<T, U>
        where T : IOrganism<U> where U : IChromosome
    {
        public abstract string Description { get; }
        //protected abstract Func<IChromosome, bool> Criteria { get; }
        protected abstract Func<U, bool> Criteria { get; }
        protected abstract int Multiplier { get; }
        protected abstract bool Mandatory { get; }

        public bool PassesCriteria(T season)
        {
            var matchesFound = GetNumberOfCriteriaMatches(season) > 0;
            return !Mandatory || matchesFound;
        }

        public int CalculateScore(T season)
        {
            return GetNumberOfCriteriaMatches(season) * Multiplier;
        }

        private int GetNumberOfCriteriaMatches(T season)
        {
            //works
            //Func<IChromosome, bool> predicate = c => c.Genes == null;
            //return season.Chromosomes.Count(predicate);

            //doesn't work - cannot convert instance argument type 'System.Collections.Generic.IENumerable<GeneticAlgorithm.IChromosome>'
            //to 'System.Collections.Generic.IEnumerable<U>'.
            //Func<U, bool> predicate = c => c.Genes == null;
            //return season.Chromosomes.Count<U>(predicate);
            
            //doesn't work - The type arguments for method 'int System.Linq.Enumerable.Count<TSource>(this IEnumerable<TSource>, Func<TSource, bool>)'
            //cannot be inferred from the usage. Try specifying the type arguments explicitly.
            return season.Chromosomes.Count(Criteria);
        }
    }
}
