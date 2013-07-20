namespace GeneticAlgorithm.SelectionStrategy.Selectors
{
    public interface ISelector
    {
        int SelectInt(int max);
        double SelectDouble();
    }
}
