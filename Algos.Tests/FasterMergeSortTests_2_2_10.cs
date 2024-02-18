using Algos.Sort;

namespace Algos.Tests;

public class FasterMergeSortTests_2_2_10
{
    SharedSortTestCase _sharedTestCase;

    public FasterMergeSortTests_2_2_10()
    {
        var merger = new FasterMerger_2_2_10<int>();
        var sorter = new MergeSorter<int>(merger);
        _sharedTestCase = new SharedSortTestCase(sorter);
    }

    [Fact]
    public void FasterMergeSort_Work()
    {
        _sharedTestCase.Work();
    }

    [Fact]
    public void FasterMergeSort_Work_With_No_Element()
    {
        _sharedTestCase.WorkWithEmpty();
    }

    [Fact]
    public void FasterMergeSort_Work_With_Sorted()
    {
        _sharedTestCase.WorkWithSorted();
    }

    [Fact]
    public void FasterMergeSort_Work_With_Reversed()
    {
        _sharedTestCase.WorkWithReserved();
    }

    [Fact]
    public void FasterMergeSort_Work_With_One_Element()
    {
        _sharedTestCase.WorkWithOneElement();
    }
}
