namespace Algos.Sort;

public class SubLinearExtraSpaceSorter_2_2_12<T> : ISorter<T>
    where T : IComparable
{
    IMerger<T> merger;
    int blockSize;
    T[] aux = new T[0];

    public SubLinearExtraSpaceSorter_2_2_12(IMerger<T> merger, int blockSize)
    {
        this.merger = merger;
        this.blockSize = blockSize;
    }

    public void Sort(T[] arr)
    {
        aux = new T[arr.Length];
        for (int low = 0; low < arr.Length; low += blockSize)
        {
            InsertionSort(arr, low, low + blockSize - 1);
        }

        for (int time = 0; time < arr.Length / blockSize; time++)
        {
            for (int low = 0; low < arr.Length - blockSize; low += blockSize)
            {
                merger.Merge(arr, low, low + blockSize - 1, low + blockSize * 2 - 1, aux);
            }
        }
    }

    public void InsertionSort(T[] arr, int low, int high)
    {
        for (int i = low; i <= high; i++)
        {
            for (int j = i; j > low && arr[j].Less(arr[j - 1]); j--)
            {
                arr.Exchange(j, j - 1);
            }
        }
    }
}
