namespace Algos.Sort;

public class NaturalMergeSorter_2_2_16<T> : ISorter<T>
    where T : IComparable
{
    T[] aux = new T[0];
    IMerger<T> merger;

    public NaturalMergeSorter_2_2_16(IMerger<T> merger)
    {
        this.merger = merger;
    }

    public void Sort(T[] arr)
    {
        aux = new T[arr.Length];

        while (FindNext(arr, 0) < arr.Length - 1)
        {
            int start = 0;
            while (start < arr.Length)
            {
                int mid = FindNext(arr, start);
                int end = FindNext(arr, mid + 1);
                merger.Merge(arr, start, mid, Math.Min(arr.Length - 1, end), aux);
                start = end + 1;
            }
        }
    }

    private int FindNext(T[] arr, int start)
    {
        int j = start;
        while (j < arr.Length - 1 && arr[j].Less(arr[j + 1]))
        {
            j++;
        }
        return j;
    }
}
