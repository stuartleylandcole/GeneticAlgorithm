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
            var genes = Builder<Gene>
                .CreateListOfSize(1000)
                .Build()
                .ToList();

            var chromosomes = Builder<Chromosome>
                .CreateListOfSize(100)
                .All()
                .With(c => c.Genes = Pick<Gene>
                    .UniqueRandomList(With.Exactly(25).Elements)
                    .From(genes))
                .Build()
                .ToList();

            _organisms = Builder<Organism>
                .CreateListOfSize(10)
                .All()
                .With(o => o.Chromosomes = Pick<Chromosome>
                    .UniqueRandomList(With.Exactly(80).Elements)
                    .From(chromosomes))
                .Build()
                .ToList();
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
