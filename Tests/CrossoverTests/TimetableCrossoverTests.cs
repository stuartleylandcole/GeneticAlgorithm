using System.Collections.Generic;
using GeneticAlgorithm.Criteria;
using GeneticAlgorithm.CrossoverStrategy;
using NUnit.Framework;
using Tests.Objects;

namespace Tests.CrossoverTests
{
    [TestFixture]
    public class TimetableCrossoverTests
    {
        [Test]
        public void TestOffspringIsValid()
        {
            //create some criteria
            var criteria = new List<CriteriaBase<Organism, Chromosome>>();

            //create two parents that can crossover
            var parent1 = new Organism();
            var parent2 = new Organism();

            //crossover
            var crossover = new TimetableCrossover<Organism, Chromosome>();
            var offspring = crossover.CrossOver(parent1, parent2);
            
            //check offspring is valid
            var criteriaCalculator = new CriteriaCalculator<Organism, Chromosome>(offspring, criteria);
            var result = criteriaCalculator.Calculate();
            Assert.True(result.IsValid);
        }
    }
}
