
namespace Algos.Sort;

public class QuickSorter<T> : ISorter<T> where T : IComparable
{
    public void Sort(T[] arr)
    {
        Sort(arr, 0, arr.Length - 1);

    }

    private void Sort(T[] arr, int low, int high)
    {
        if (high <= low)
        {
            return;
        }

        var mid = Partition(arr, low, high);
        Sort(arr, low, mid - 1);
        Sort(arr, mid+ 1, high);
    }

    private int Partition(T[] arr, int low, int high)
    {
        int i = low + 1, j = high;
        //get low as pivot
        var pivot = arr[low];
        while (true)
        {
            while (i < high && arr[i].Less(pivot))
            {
                i++;
            }

            while (j > low && pivot.Less(arr[j]))
            {
                j--;
            }

            if (i >= j)
            {
                break;
            }
            arr.Exchange(i, j);
        }
        arr.Exchange(low, j);
        return j;
    }
}
