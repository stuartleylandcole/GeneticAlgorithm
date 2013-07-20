using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzWare.NBuilder;
using GeneticAlgorithm;
using GeneticAlgorithm.CrossoverStrategy;
using GeneticAlgorithm.SelectionStrategy;
using NUnit.Framework;
using Tests.Objects;
using Tests.SelectionStrategyTests;

namespace Tests.CrossoverTests
{
    [TestFixture]
    public class TimetableCrossoverTests
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
            _newPopulation = crossover.CreateNewPopulation(_population,
                                                           new SimpleSelectionStrategy<Organism, Chromosome>(),
                                                           new ConsistentSelector(), NumberOfChildrenToCreate);
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
