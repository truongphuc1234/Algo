namespace Algos.Sort;

public interface IMerger<T>
    where T : IComparable
{
    public void Merge(T[] arr, int low, int mid, int high, T[] aux);
}
