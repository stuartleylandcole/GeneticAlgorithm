using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm;

namespace Tests.Objects
{
    public class Gene : IGene
    {
        public int Property { get; set; }
        
        public bool IsSameAs(IGene other)
        {
            var otherGene = other as Gene;
            if (otherGene == null)
            {
                return false;
            }

            return Property == otherGene.Property;
        }

        public override string ToString()
        {
            return Property.ToString();
        }
    }
}
