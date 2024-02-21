using Algos.Sort;

namespace Algos.Tests;

public class MergeQueue_2_2_14_Tests
{
    private readonly MergeQueue_2_2_14<int> merger;

    public MergeQueue_2_2_14_Tests()
    {
        merger = new MergeQueue_2_2_14<int>();
    }

    [Fact]
    public void MergeQueue_Work()
    {
        var firstQueue = new Queue<int>();
        firstQueue.Enqueue(1);
        firstQueue.Enqueue(3);
        firstQueue.Enqueue(5);

        var secondQueue = new Queue<int>();
        secondQueue.Enqueue(2);
        secondQueue.Enqueue(4);
        secondQueue.Enqueue(6);

        var result = merger.Merge(firstQueue, secondQueue);

        var resultArr = result.ToArray();
        Assert.True(Helper.IsSorted(resultArr));
    }
}
