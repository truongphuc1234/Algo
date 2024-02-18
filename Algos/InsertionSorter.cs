namespace Algos.Sort;

public class InsertionSorter<T> : ISorter<T>
    where T : IComparable
{
    public void Sort(T[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j > 0 && arr[j].Less(arr[j - 1]); j--)
            {
                arr.Exchange(j, j - 1);
            }
        }
    }
}
