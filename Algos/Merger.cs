namespace Algos.Sort;

public class Merger<T> : IMerger<T>
    where T : IComparable
{
    public void Merge(T[] arr, int low, int mid, int high, T[] aux)
    {
        for (int k = low; k <= high; k++)
        {
            aux[k] = arr[k];
        }

        int i = low,
            j = mid + 1;

        for (int k = low; k <= high; k++)
        {
            if (i > mid)
            {
                arr[k] = aux[j];
                j++;
            }
            else if (j > high)
            {
                arr[k] = aux[i];
                i++;
            }
            else if (aux[i].Less(aux[j]))
            {
                arr[k] = aux[i];
                i++;
            }
            else
            {
                arr[k] = aux[j];
                j++;
            }
        }
    }
}
