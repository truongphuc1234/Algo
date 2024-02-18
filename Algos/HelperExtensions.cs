namespace Algos.Sort;

public static class HelperExtensions
{
	public static bool Less<T>(this T first, T second) where T : IComparable
	{
		return first.CompareTo(second) < 0;
	}

	public static void Exchange<T>(this T[] arr, int i, int j)
	{
		(arr[i], arr[j]) = (arr[j], arr[i]);
	}
}

