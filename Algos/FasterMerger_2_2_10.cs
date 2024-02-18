namespace Algos.Sort;

public class FasterMerger_2_2_10<T> : IMerger<T>
    where T : IComparable
{
    public void Merge(T[] arr, int low, int mid, int high, T[] aux)
    {
        for (int k = low; k <= mid; k++)
        {
            aux[k] = arr[k];
        }

        for (int k = mid + 1; k <= high; k++)
        {
            aux[k] = arr[high - k + mid + 1];
        }

        int i = low,
            j = high;

        for (int k = low; k <= high; k++)
        {
            if (aux[i].Less(aux[j]))
            {
                arr[k] = aux[i];
                i++;
            }
            else
            {
                arr[k] = aux[j];
                j--;
            }
        }
    }
}
