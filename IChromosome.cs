using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithm
{
    public interface IChromosome// : IEnumerable<IGene>
    {
        IEnumerable<IGene> Genes { get; }
    }
}
