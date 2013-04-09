namespace GeneticAlgorithm.CrossoverStrategy
{
    public class SimpleCrossoverStrategy<TOrganism, TChromosome> : ICrossoverStrategy<TOrganism, TChromosome> where TOrganism: IOrganism<TChromosome> where TChromosome : IChromosome
    {
        public TOrganism CrossOver(TOrganism parent1, TOrganism parent2)
        {
            return parent1;
        }
    }
}
