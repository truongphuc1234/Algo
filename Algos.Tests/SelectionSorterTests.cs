using Algos.Sort;

namespace Algos.Tests;

public class SelectionSortTests
{
    SharedSortTestCase _sharedTestCase;

    public SelectionSortTests()
    {
        _sharedTestCase = new SharedSortTestCase(new SelectionSorter<int>());
    }

    [Fact]
    public void SelectionSort_Work()
    {
        _sharedTestCase.Work();
    }

    [Fact]
    public void SelectionSort_Work_With_No_Element()
    {
        _sharedTestCase.WorkWithEmpty();
    }

    [Fact]
    public void SelectionSort_Work_With_Sorted()
    {
        _sharedTestCase.WorkWithSorted();
    }

    [Fact]
    public void SelectionSort_Work_With_Reversed()
    {
        _sharedTestCase.WorkWithReserved();
    }

    [Fact]
    public void SelectionSort_Work_With_One_Element()
    {
        _sharedTestCase.WorkWithOneElement();
    }
}

public class MergeSortTests
{
    SharedSortTestCase _sharedTestCase;

    public MergeSortTests()
    {
        _sharedTestCase = new SharedSortTestCase(new MergeSorter<int>());
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
