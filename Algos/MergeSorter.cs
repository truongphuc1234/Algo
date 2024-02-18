namespace Algos.Sort;

public interface IMerger<T> where T : IComparable
{
	public void Merge(T[] arr, int low, int mid, int high, T[] aux);
}

public class BasicMerger<T> : IMerger<T> where T : IComparable
{
	public void Merge(T[] arr, int low, int mid, int high, T[] aux)
	{
		for (int k = low; k <= high; k++)
		{
			aux[k] = arr[k];
		}

		int i = low, j = mid + 1;

		for (int k = low; k <= high; k++)
		{
			if (i > mid)
			{
				arr[k] = aux[j];
				j++;
			}
			else if (j > high)
			{
				arr[k] = aux[i];
				i++;
			}
			else if (aux[i].Less(aux[j]))
			{
				arr[k] = aux[i];
				i++;
			}
			else
			{
				arr[k] = aux[j];
				j++;
			}
		}
	}
}

public class MergeSorter<T> : ISorter<T> where T : IComparable
{

	IMerger<T> merger;
	T[] aux = new T[0];

	public MergeSorter(IMerger<T> merger)
	{
		this.merger = merger;
	}


	public void Sort(T[] arr)
	{
		aux = new T[arr.Length];
		Sort(arr, 0, arr.Length - 1);
	}

	public void Sort(T[] arr, int low, int high)
	{
		if (low >= high)
		{
			return;
		}
		int mid = low + (high - low) / 2;
		Sort(arr, low, mid);
		Sort(arr, mid + 1, high);
		merger.Merge(arr, low, mid, high, aux);
	}
}

public class BottomUpMergeSorter<T> : ISorter<T> where T : IComparable
{
	T[] aux = new T[0];
	IMerger<T> merger;

	public BottomUpMergeSorter(IMerger<T> merger)
	{
		this.merger = merger;
	}

	public void Sort(T[] arr)
	{
		aux = new T[arr.Length];
		for (int size = 1; size < arr.Length; size *= 2)
		{
			for (int low = 0; low < arr.Length - size; low += size * 2)
			{
				merger.Merge(arr, low, low + size - 1, Math.Min(low + size * 2 - 1, arr.Length - 1), aux);
			}
		}
	}
}
