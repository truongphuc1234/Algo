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

public class MergeQueue_2_2_14<T>
    where T : IComparable
{
    public Queue<T> Merge(Queue<T> first, Queue<T> second)
    {
        var result = new Queue<T>();

        while (first.Count > 0 && second.Count > 0)
        {
            if (first.Peek().Less(second.Peek()))
            {
                result.Enqueue(first.Dequeue());
            }
            else
            {
                result.Enqueue(second.Dequeue());
            }
        }

        while (first.Count > 0)
        {
            result.Enqueue(first.Dequeue());
        }

        while (second.Count > 0)
        {
            result.Enqueue(second.Dequeue());
        }

        return result;
    }
}
