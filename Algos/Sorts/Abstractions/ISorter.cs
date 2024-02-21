namespace Algos.Sort;

public interface ISorter<T>
    where T : IComparable
{
    public void Sort(T[] arr);
}
