namespace GeneticAlgorithm.CrossoverStrategy
{
    public class SimpleCrossoverStrategy<T, U> : ICrossoverStrategy<T, U> where T: IOrganism<U> where U : IChromosome
    {
        public T CrossOver(T parent1, T parent2)
        {
            return parent1;
        }
    }
}
