namespace Algos.Sort;

public class BottomUpMergeSorter<T> : ISorter<T>
    where T : IComparable
{
    T[] aux = new T[0];
    IMerger<T> merger;

    public BottomUpMergeSorter(IMerger<T> merger)
    {
        this.merger = merger;
    }

    public void Sort(T[] arr)
    {
        aux = new T[arr.Length];
        for (int size = 1; size < arr.Length; size *= 2)
        {
            for (int low = 0; low < arr.Length - size; low += size * 2)
            {
                merger.Merge(
                    arr,
                    low,
                    low + size - 1,
                    Math.Min(low + size * 2 - 1, arr.Length - 1),
                    aux
                );
            }
        }
    }
}
