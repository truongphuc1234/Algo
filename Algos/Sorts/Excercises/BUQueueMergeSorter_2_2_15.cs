namespace Algos.Sort;

public class BUQueueMergeSorter_2_2_15<T> : ISorter<T>
    where T : IComparable
{
    private MergeQueue_2_2_14<T> merger = new MergeQueue_2_2_14<T>();

    public void Sort(T[] arr)
    {
        var parentQueue = new Queue<Queue<T>>();
        for (int i = 0; i < arr.Length; i++)
        {
            var queue = new Queue<T>();
            queue.Enqueue(arr[i]);
            parentQueue.Enqueue(queue);
        }
        while (parentQueue.Count > 1)
        {
            var first = parentQueue.Dequeue();
            var second = parentQueue.Dequeue();
            var newQueue = merger.Merge(first, second);
            parentQueue.Enqueue(newQueue);
        }
        if (parentQueue.Count == 1)
        {
            var result = parentQueue.Dequeue();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = result.Dequeue();
            }
        }
    }
}
