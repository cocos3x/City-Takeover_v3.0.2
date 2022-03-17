using System.Collections.Concurrent;
using System.Collections.Generic;

public class FixedSizedQueue<T>
{
	private ConcurrentQueue<T> q;

	private object _lockObject;

	private int _003CLimit_003Ek__BackingField;

	public int Limit
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void Enqueue(T obj)
	{
	}

	public IReadOnlyCollection<T> GetList()
	{
		return null;
	}
}
