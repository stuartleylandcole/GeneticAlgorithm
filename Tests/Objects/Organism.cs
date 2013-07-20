using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm;

namespace Tests.Objects
{
    public class Organism : IOrganism<Chromosome>
    {
        public IEnumerable<Chromosome> Chromosomes { get; set; }
    }
}
