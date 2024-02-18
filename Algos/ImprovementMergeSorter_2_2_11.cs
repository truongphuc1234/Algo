namespace Algos.Sort;

public class ImprovementMergeSorter_2_2_11<T> : ISorter<T>
    where T : IComparable
{
    IMerger<T> merger;
    int cutoff = 0;
    T[] aux = new T[0];

    public ImprovementMergeSorter_2_2_11(IMerger<T> merger, int cutoff)
    {
        this.merger = merger;
        this.cutoff = cutoff;
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
        if (high - low + 1 <= cutoff)
        {
            new SelectionSorter<T>().Sort(arr);
            return;
        }

        int mid = low + (high - low) / 2;
        Sort(arr, low, mid);
        Sort(arr, mid + 1, high);

        if (arr[mid].Less(arr[mid + 1]))
        {
            return;
        }
        merger.Merge(arr, low, mid, high, aux);
    }
}
