namespace Algos.Tests;

public class Helper
{
	public static bool IsSorted<T>(T[] arr) where T : IComparable
	{
		for (int i = 1; i < arr.Length; i++)
		{
			if (arr[i].CompareTo(arr[i - 1]) < 0)
			{
				return false;
			}
		}
		return true;
	}

	public static bool HasSameElements<T>(T[] arr1, T[] arr2)
	{
		return new HashSet<T>(arr1).SetEquals(arr2);
	}
}

