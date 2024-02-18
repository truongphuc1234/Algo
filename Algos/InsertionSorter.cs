namespace Algos.Sort;

public class InsertionSorter<T> : ISorter<T> where T : IComparable
{
	public void Sort(T[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			for (int j = i; j > 0 && arr[j].CompareTo(arr[j - 1]) < 0; j--)
			{
				(arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
			}
		}
	}
}

