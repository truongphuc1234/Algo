using Algos.Sort;

namespace Algos.Tests;

public class ImprovementMergeSortTests_2_2_11
{
    SharedSortTestCase _sharedTestCase;

    public ImprovementMergeSortTests_2_2_11()
    {
        var merger = new Merger<int>();
        var sorter = new ImprovementMergeSorter_2_2_11<int>(merger, 4);
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
