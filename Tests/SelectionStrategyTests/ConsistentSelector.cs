using GeneticAlgorithm.SelectionStrategy.Selectors;

namespace Tests.SelectionStrategyTests
{
    class ConsistentSelector : ISelector 
    {
        public int SelectInt(int max)
        {
            return 0;
        }

        public double SelectDouble()
        {
            return 1;
        }
    }
}
