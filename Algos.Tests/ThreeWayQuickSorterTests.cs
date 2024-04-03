using Algos.Sort;

namespace Algos.Tests;

public class ThreeWayQuickSorterTests
{
    SharedSortTestCase _sharedTestCase;

    public ThreeWayQuickSorterTests()
    {
        var sorter = new ThreeWayQuickSorter<int>();
        _sharedTestCase = new SharedSortTestCase(sorter);
    }

    [Fact]
    public void QuickSort_Work()
    {
        _sharedTestCase.Work();
    }

    [Fact]
    public void QuickSort_Work_With_No_Element()
    {
        _sharedTestCase.WorkWithEmpty();
    }

    [Fact]
    public void QuickSort_Work_With_Sorted()
    {
        _sharedTestCase.WorkWithSorted();
    }

    [Fact]
    public void QuickSort_Work_With_Reversed()
    {
        _sharedTestCase.WorkWithReserved();
    }

    [Fact]
    public void QuickSort_Work_With_One_Element()
    {
        _sharedTestCase.WorkWithOneElement();
    }
}

