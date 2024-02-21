namespace Algos.Sort;

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
