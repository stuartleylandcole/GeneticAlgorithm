using System.Collections.Generic;
using System.Linq;
using FizzWare.NBuilder;
using GeneticAlgorithm.SelectionStrategy;
using NUnit.Framework;
using Tests.Objects;

namespace Tests.SelectionStrategyTests
{
    [TestFixture]
    public class SimpleSelectionStrategyTests
    {
        private IList<Organism> _organisms;

        [SetUp]
        public void Init()
        {
            var populationGenerator = new TestPopulationGenerator();
            populationGenerator.Generate();
            _organisms = populationGenerator.Organisms;
        }

        [Test]
        public void TestConsistentSelection()
        {
            var selection = new SimpleSelectionStrategy<Organism, Chromosome>();
            var selector = new ConsistentSelector();
            var selectedParent = selection.SelectParent(_organisms, selector);
            var firstOrganism = _organisms.First();
            Assert.AreEqual(firstOrganism, selectedParent);
        }
    }
}
