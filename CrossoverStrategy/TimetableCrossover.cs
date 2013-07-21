namespace GeneticAlgorithm.CrossoverStrategy
{
    public class TimetableCrossover<TOrganism, TChromosome> : ICrossoverStrategy<TOrganism, TChromosome>
        where TOrganism : IOrganism<TChromosome>, new()
        where TChromosome : IChromosome
    {
        public TOrganism CrossOver(TOrganism parent1, TOrganism parent2)
        {
            //choose a random starting point in the chromosome
            //go from starting point to end and then from start of list to starting point-1
            //find any genes that are in the same chromosome in both parents (eg: that means Arsenal v Man United is gameweek 4 in both parents)
            return parent1;
        }
    }

    
    //class TimetableOrganism<TOrganism, TChromosome>
    //    where TOrganism : IOrganism<TChromosome> 
    //    where TChromosome : IChromosome
    //{
    //    private TOrganism _organism;
    //    private IList<IGene> _unschedulableGenes = new List<IGene>();

    //    public TimetableOrganism(TOrganism organism)
    //    {
    //        _organism = organism;
    //    }

    //    public IList<TChromosome> Chromosomes { get { return _organism.Chromosomes; } }
    //    public IList<IGene> UnschedulableGenes { get { return _unschedulableGenes; } }
    //}
}
