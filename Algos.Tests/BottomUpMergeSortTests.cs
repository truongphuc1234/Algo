using Algos.Sort;

namespace Algos.Tests;

public class BottomUpMergeSortTests
{
    SharedSortTestCase _sharedTestCase;

    public BottomUpMergeSortTests()
    {
        var merger = new Merger<int>();
        var sorter = new BottomUpMergeSorter<int>(merger);
        _sharedTestCase = new SharedSortTestCase(sorter);
    }

    [Fact]
    public void MergeSort_Work()
    {
        _sharedTestCase.Work();
    }

    [Fact]
    public void MergeSort_Work_With_No_Element()
    {
        _sharedTestCase.WorkWithEmpty();
    }

    [Fact]
    public void MergeSort_Work_With_Sorted()
    {
        _sharedTestCase.WorkWithSorted();
    }

    [Fact]
    public void MergeSort_Work_With_Reversed()
    {
        _sharedTestCase.WorkWithReserved();
    }

    [Fact]
    public void MergeSort_Work_With_One_Element()
    {
        _sharedTestCase.WorkWithOneElement();
    }
}
