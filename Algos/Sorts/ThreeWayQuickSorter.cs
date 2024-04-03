
namespace Algos.Sort;

public class ThreeWayQuickSorter<T> : ISorter<T> where T : IComparable
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

        int lt = low, i = low + 1, gt = high;

        var pivot = arr[low];
        while (i <= gt)
        {
            int cmp = arr[i].CompareTo(pivot);
            if (cmp < 0)
            {
                arr.Exchange(lt, i);
                lt++;
                i++;
            }
            else if (cmp > 0)
            {
                arr.Exchange(i, gt);
                gt--;
            }
            else
            {
                i++;
            }
        };

        Sort(arr, low, lt - 1);
        Sort(arr, gt + 1, high);
    }
}
