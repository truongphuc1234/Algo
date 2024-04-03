using Algos.Sort;

namespace Algos.Tests;

public class SharedSortTestCase
{
	ISorter<int> _sorter;

	public SharedSortTestCase(ISorter<int> sorter)
	{
		this._sorter = sorter;
	}

	public void Work()
	{
		var arr = new int[10] { 1, 3, 5, 6, 2, 4, 8, 7, 9, 10 };
		var clone = new int[10];
		Array.Copy(arr, clone, arr.Length);
		_sorter.Sort(arr);
        Assert.Equal(arr, new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
		Assert.True(Helper.IsSorted(arr));
		Assert.True(Helper.HasSameElements(arr, clone));
	}

	public void WorkWithEmpty()
	{
		var arr = new int[0] { };
		var clone = new int[0];
		Array.Copy(arr, clone, arr.Length);
		_sorter.Sort(arr);
		Assert.True(Helper.IsSorted(arr));
		Assert.True(Helper.HasSameElements(arr, clone));
	}

	public void WorkWithSorted()
	{
		var arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
		var clone = new int[10];
		Array.Copy(arr, clone, arr.Length);
		_sorter.Sort(arr);
		Assert.True(Helper.IsSorted(arr));
		Assert.True(Helper.HasSameElements(arr, clone));
	}

	public void WorkWithReserved()
	{
		var arr = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
		var clone = new int[10];
		Array.Copy(arr, clone, arr.Length);
		_sorter.Sort(arr);
		Assert.Equal(arr, new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
		Assert.True(Helper.IsSorted(arr));
		Assert.True(Helper.HasSameElements(arr, clone));
	}

	public void WorkWithOneElement()
	{
		var arr = new int[1] { 1 };
		var clone = new int[1];
		Array.Copy(arr, clone, arr.Length);
		_sorter.Sort(arr);
		Assert.True(Helper.IsSorted(arr));
		Assert.True(Helper.HasSameElements(arr, clone));
	}
}

