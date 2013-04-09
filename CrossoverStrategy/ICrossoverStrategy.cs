namespace GeneticAlgorithm.CrossoverStrategy
{
    public interface ICrossoverStrategy<T, U> where T : IOrganism<U> where U : IChromosome
    {
        T CrossOver(T parent1, T parent2);
    }
}
