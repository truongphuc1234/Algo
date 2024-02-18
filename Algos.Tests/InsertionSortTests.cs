using Algos.Sort;

namespace Algos.Tests;

public class InsertionSortTests
{

	SharedSortTestCase _sharedTestCase;

	public InsertionSortTests()
	{
		_sharedTestCase = new SharedSortTestCase(new InsertionSorter<int>());
	}

	[Fact]
	public void InsertionSort_Work()
	{
		_sharedTestCase.Work();
	}

	[Fact]
	public void InsertionSort_Work_With_No_Element()
	{
		_sharedTestCase.WorkWithEmpty();
	}

	[Fact]
	public void InsertionSort_Work_With_Sorted()
	{
		_sharedTestCase.WorkWithSorted();
	}

	[Fact]
	public void InsertionSort_Work_With_Reversed()
	{
		_sharedTestCase.WorkWithReserved();
	}

	[Fact]
	public void InsertionSort_Work_With_One_Element()
	{
		_sharedTestCase.WorkWithOneElement();
	}
}

