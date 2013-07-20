using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm;

namespace Tests.Objects
{
    public class Organism : IOrganism<Chromosome>
    {
        public IList<Chromosome> Chromosomes { get; set; }

        public override string ToString()
        {
            return "{" + string.Join(", ", Chromosomes) + "}";
        }
    }
}
