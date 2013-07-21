using System.Collections.Generic;
using GeneticAlgorithm;
using GeneticAlgorithm.CrossoverStrategy;
using GeneticAlgorithm.SelectionStrategy;
using NUnit.Framework;
using Tests.Objects;
using Tests.SelectionStrategyTests;

namespace Tests
{
    [TestFixture]
    public class PopulationGeneratorTests
    {
        private IList<Organism> _population;
        private IList<Organism> _newPopulation;
        private const int NumberOfChildrenToCreate = 100;

        [SetUp]
        public void Init()
        {
            var populationGenerator = new TestPopulationGenerator();
            populationGenerator.Generate();
            _population = populationGenerator.Organisms;

            var crossover = new TimetableCrossover<Organism, Chromosome>();
            var selectionStrategy = new SimpleSelectionStrategy<Organism, Chromosome>();
            var selector = new ConsistentSelector();
            var newPopulationGenerator = new PopulationGenerator<Organism, Chromosome>(_population,
                                                                                       NumberOfChildrenToCreate,
                                                                                       crossover, selectionStrategy,
                                                                                       selector);
            _newPopulation = newPopulationGenerator.Generate();
        }

        [Test]
        public void TestCorrectNumberOfChildrenCreated()
        {
            Assert.AreEqual(NumberOfChildrenToCreate, _newPopulation.Count);
        }

        [Test]
        public void TestNewPopulationDoesNotContainAnyFromCurrentPopulation()
        {
            Assert.That(_population, Is.Not.SubsetOf(_population));
        }
    }
}
