using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneticAlgorithm.SelectionStrategy;
using GeneticAlgorithm.SelectionStrategy.Selectors;

namespace GeneticAlgorithm.CrossoverStrategy
{
    public class TimetableCrossover<TOrganism, TChromosome> : ICrossoverStrategy<TOrganism, TChromosome> 
                                                             where TOrganism : IOrganism<TChromosome>, new()
        where TChromosome : IChromosome
    {
        public IList<TOrganism> CreateNewPopulation(IList<TOrganism> currentPopulation,
                                                    ISelectionStrategy<TOrganism, TChromosome> selectionStrategy, 
                                                    ISelector selector,
                                                    int numberOfChildrenToCreate)
        {
            return currentPopulation;
            //var newPopulation = new List<TOrganism>();
            //for (int i = 0; i < numberOfChildrenToCreate; i++)
            //{
            //    var parent1 = selectionStrategy.SelectParent(currentPopulation, selector);
            //    var parent2 = selectionStrategy.SelectParent(currentPopulation, selector);

            //    var child = CrossOver(parent1, parent2, selector);
            //    newPopulation.Add(child);
            //}

            //return newPopulation;
        }

        private TOrganism CrossOver(TOrganism parent1, TOrganism parent2, ISelector selector)
        {
            int startingPoint = selector.SelectInt(parent1.Chromosomes.Count - 1);
            for (int i = startingPoint; i < parent1.Chromosomes.Count; i++)
            {
                var parent1Chromosome = parent1.Chromosomes[i];
                var parent2Chromosome = parent2.Chromosomes[i];
            }

            var child = new TOrganism();

            //choose a random starting point in the chromosome
            //go from starting point to end and then from start of list to starting point-1
            //find any genes that are in the same chromosome in both parents (eg: that means Arsenal v Man United is gameweek 4 in both parents)
            //add any genes (from both parents) that don't cause a clash (just use the criteria)
            return parent1;
        }
    }

    class TimetableOrganism<TOrganism, TChromosome>
        where TOrganism : IOrganism<TChromosome> 
        where TChromosome : IChromosome
    {
        private TOrganism _organism;
        private IList<IGene> _unschedulableGenes = new List<IGene>();

        public TimetableOrganism(TOrganism organism)
        {
            _organism = organism;
        }

        public IList<TChromosome> Chromosomes { get { return _organism.Chromosomes; } }
        public IList<IGene> UnschedulableGenes { get { return _unschedulableGenes; } }
    }
}
