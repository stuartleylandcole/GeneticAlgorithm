using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzWare.NBuilder;
using GeneticAlgorithm;
using GeneticAlgorithm.CrossoverStrategy;
using NUnit.Framework;
using Tests.Objects;

namespace Tests.CrossoverTests
{
    [TestFixture]
    public class TimetableCrossoverTests
    {
        private Organism _parent1;
        private Organism _parent2;

        [SetUp]
        public void Init()
        {
            var populationGenerator = new TestPopulationGenerator();
            populationGenerator.Generate();
            _parent1 = populationGenerator.Organisms[0];
            _parent2 = populationGenerator.Organisms[1];
        }

        [Test]
        public void TestAllGenesFromParentsAreScheduledOrInUnschedulableList()
        {
            var crossover = new TimetableCrossover<Organism, Chromosome>();
            var child = crossover.CrossOver(_parent1, _parent2);

            var allGenesFromParents = new HashSet<IGene>();
            foreach (var c in _parent1.Chromosomes)
            {
                allGenesFromParents.UnionWith(c.Genes);
            }

            foreach (var c in _parent2.Chromosomes)
            {
                allGenesFromParents.UnionWith(c.Genes);
            }

            var allGenesForChild = new HashSet<IGene>();
            foreach (var c in child.Chromosomes)
            {
                allGenesForChild.UnionWith(c.Genes);
            }

            Assert.AreEqual(allGenesForChild, allGenesFromParents);
        }
    }
}
