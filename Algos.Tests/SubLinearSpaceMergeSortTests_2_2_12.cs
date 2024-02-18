using Algos.Sort;

namespace Algos.Tests;

public class SubLinearSpaceMergeSortTests_2_2_12
{
    SharedSortTestCase _sharedTestCase;

    public SubLinearSpaceMergeSortTests_2_2_12()
    {
        var merger = new Merger<int>();
        var sorter = new SubLinearExtraSpaceSorter_2_2_12<int>(merger, 2);
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
}
