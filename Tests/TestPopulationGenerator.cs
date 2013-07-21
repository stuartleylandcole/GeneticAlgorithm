using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzWare.NBuilder;
using Tests.Objects;

namespace Tests
{
    class TestPopulationGenerator
    {
        private IList<Gene> _genes;
        private IList<Chromosome> _chromosomes;
        private IList<Organism> _organisms;

        public void Generate()
        {
            _genes = Builder<Gene>
                .CreateListOfSize(1000)
                .Build()
                .ToList();

            _chromosomes = Builder<Chromosome>
                .CreateListOfSize(500)
                .All()
                .With(c => c.Genes = Pick<Gene>
                    .UniqueRandomList(With.Exactly(25).Elements)
                    .From(_genes))
                .Build()
                .ToList();

            _organisms = Builder<Organism>
                .CreateListOfSize(5)
                .All()
                .With(o => o.Chromosomes = Pick<Chromosome>
                    .UniqueRandomList(With.Exactly(10).Elements)
                    .From(_chromosomes))
                .Build()
                .ToList();
        }

        public IList<Gene> Genes { get { return _genes; } }
        public IList<Chromosome> Chromosomes { get { return _chromosomes; } }
        public IList<Organism> Organisms { get { return _organisms; } }
    }
}
