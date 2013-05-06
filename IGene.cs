using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithm
{
    public interface IGene
    {
        bool IsSameAs(IGene other);
    }
}
