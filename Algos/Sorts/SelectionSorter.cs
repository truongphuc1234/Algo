namespace Algos.Sort;

public class SelectionSorter<T> : ISorter<T> where T : IComparable
{
	public void Sort(T[] arr)
	{
		int n = arr.Length;
		for (int i = 0; i < n; i++)
		{
			int min = i;
			for (int j = i + 1; j < n; j++)
			{
				if (arr[j].Less(arr[min]))
				{
					min = j;
				}
			}
			arr.Exchange(i, min);
		}
	}
}
