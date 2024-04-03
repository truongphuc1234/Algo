using Algos.Sort;

namespace Algos.Tests;

public class MergeSort_2_2_15Tests
{
    SharedSortTestCase _sharedTestCase;

    public MergeSort_2_2_15Tests()
    {
        var sorter = new BUQueueMergeSorter_2_2_15<int>();
        _sharedTestCase = new SharedSortTestCase(sorter);
    }

    [Fact]
    public void BUQueueMergeSorter_Work()
    {
        _sharedTestCase.Work();
    }

    [Fact]
    public void BUQueueMergeSorter_Work_With_No_Element()
    {
        _sharedTestCase.WorkWithEmpty();
    }

    [Fact]
    public void BUQueueMergeSorter_Work_With_Sorted()
    {
        _sharedTestCase.WorkWithSorted();
    }

    [Fact]
    public void BUQueueMergeSorter_Work_With_Reversed()
    {
        _sharedTestCase.WorkWithReserved();
    }

    [Fact]
    public void BUQueueMergeSorter_Work_With_One_Element()
    {
        _sharedTestCase.WorkWithOneElement();
    }
}

