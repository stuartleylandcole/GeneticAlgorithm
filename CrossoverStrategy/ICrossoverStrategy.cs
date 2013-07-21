namespace GeneticAlgorithm.CrossoverStrategy
{
    public interface ICrossoverStrategy<TOrganism, TChromosome> where TOrganism : IOrganism<TChromosome> where TChromosome : IChromosome
    {
        TOrganism CrossOver(TOrganism parent1, TOrganism parent2);
    }
}