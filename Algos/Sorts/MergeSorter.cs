namespace Algos.Sort;

public class MergeSorter<T> : ISorter<T>
    where T : IComparable
{
    IMerger<T> merger;
    T[] aux = new T[0];

    public MergeSorter(IMerger<T> merger)
    {
        this.merger = merger;
    }

    public void Sort(T[] arr)
    {
        aux = new T[arr.Length];
        Sort(arr, 0, arr.Length - 1);
    }

    public void Sort(T[] arr, int low, int high)
    {
        if (low >= high)
        {
            return;
        }
        int mid = low + (high - low) / 2;
        Sort(arr, low, mid);
        Sort(arr, mid + 1, high);
        merger.Merge(arr, low, mid, high, aux);
    }
}
