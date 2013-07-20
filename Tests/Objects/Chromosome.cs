using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm;

namespace Tests.Objects
{
    public class Chromosome : IChromosome
    {
        public IEnumerable<IGene> Genes { get; set; }
    }
}
