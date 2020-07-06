using System;
using System.Collections.Generic;

class Set<T>: ICollection<T> where T: ISuitable
{
	private List<T> _list = new List<T>();

	public int Count => _list.Count;
	public bool IsReadOnly => false;
	public void Clear() => _list.Clear();
	public bool Contains(T element) => _list.Contains(element);
	public void CopyTo(T[] a, int index) => _list.CopyTo(a, index);
	public bool Remove(T element) => _list.Remove(element);

	// Legacy!
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();

	// Modern version of IEnumerable.GetEnumerator()
	public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

	// Alias for 'Count':
	public int Cardinality => Count;

	// Is the set empty?
	public bool IsEmpty => Count == 0;

	public void Add(T element)
	{
		if (element.Suit() && !Contains(element))
		{
			_list.Add(element);
		}
	}

	// Test if this set is a subset of another one.
	public bool IsSubsetOf(Set<T> other)
	{
		foreach (var element in this)
		{
			if (!other.Contains(element))
			{
				return false;
			}
		}

		return true;
	}

	// Test if this set is a *true* subset of another one.
	public bool IsTrueSubsetOf(Set<T> other) => IsSubsetOf(other) && (Cardinality < other.Cardinality);

	// Calculate the intersection with another given set.
	public Set<T> Intersect(Set<T> other)
	{
		var result = new Set<T>();

		foreach (var element in this)
		{
			if (other.Contains(element))
			{
				result.Add(element);
			}
		}

		return result;
	}

	// Calculate the union with another given set.
	public Set<T> Union(Set<T> other)
	{
		var result = new Set<T>();

		foreach (var element in this)
		{
			result.Add(element);
		}

		foreach (var element in other)
		{
			result.Add(element);
		}

		return result;
	}
}
