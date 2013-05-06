using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticAlgorithm.CrossoverStrategy
{
    public class TimetableCrossover<TOrganism, TChromsome> : ICrossoverStrategy<TOrganism, TChromsome> 
                                                             where TOrganism : IOrganism<TChromsome> 
                                                             where TChromsome : IChromosome
    {
        public TOrganism CrossOver(TOrganism parent1, TOrganism parent2)
        {
            //choose a random starting point in the chromosome
            //go from starting point to end and then from start of list to starting point-1
            //find any genes that are in the same chromosome in both parents (eg: that means Arsenal v Man United is gameweek 4 in both parents)
            //add any genes (from both parents) that don't cause a clash (just use the criteria)
            return parent1;
        }
    }
}
