using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
	private static readonly int _count = 100000;

	static void ListInsert(List<int> list)
	{
		for (int i = 0; i < _count; i++)
		{
			list.Add(i);
		}
	}

	static void ListDelete(List<int> list)
	{
		for (int i = 0; i < (_count / 2); i++)
		{
			if ((i % 10) == 0)
			{
				list.RemoveAt(i);
			}
		}
	}

	static void ListInsertFront(List<int> list)
	{
		for (int i = 0; i < 10000; i++)
		{
			list.Insert(0, i);
		}
	}

	static void ListInsertBack(List<int> list)
	{
		for (int i = 0; i < 10000; i++)
		{
			list.Insert(list.Count - 1, i);
		}
	}

	static void ArrayInsert(int[] arr)
	{
		for (int i = 0; i < _count; i++)
		{
			arr[i] = i;
		}
	}

	static void ArrayListInsert(ArrayList arrList)
	{
		for (int i = 0; i < _count; i++)
		{
			arrList.Add(i);
		}
	}

	static void ArrayListDelete(ArrayList arrList)
	{
		for (int i = 0; i < (_count / 2); i++)
		{
			if ((i % 10) == 0)
			{
				arrList.RemoveAt(i);
			}
		}
	}

	static void Main()
	{
		// List vs. Array vs. ArrayList

		// List:
		var watch = Stopwatch.StartNew();
		var list = new List<int>();
		ListInsert(list);
		var elapsed = watch.ElapsedTicks;
		Console.WriteLine($"List (insert): { elapsed } ticks");

		watch = Stopwatch.StartNew();
		ListDelete(list);
		elapsed = watch.ElapsedTicks;
		Console.WriteLine($"List (delete): { elapsed } ticks");

		list.Clear();
		ListInsert(list);
		watch = Stopwatch.StartNew();
		ListInsertFront(list);
		elapsed = watch.ElapsedTicks;
		Console.WriteLine($"List (insert front): { elapsed } ticks");

		list.Clear();
		ListInsert(list);
		watch = Stopwatch.StartNew();
		ListInsertBack(list);
		elapsed = watch.ElapsedTicks;
		Console.WriteLine($"List (insert back): { elapsed } ticks");

		// Array:
		watch = Stopwatch.StartNew();
		var arr = new int[_count];
		ArrayInsert(arr);
		elapsed = watch.ElapsedTicks;
		Console.WriteLine($"Array (insert): { elapsed } ticks");

		// ArrayList:
		watch = Stopwatch.StartNew();
		var arrList = new ArrayList();
		ArrayListInsert(arrList);
		elapsed = watch.ElapsedTicks;
		Console.WriteLine($"ArrayList (insert): { elapsed } ticks");

		watch = Stopwatch.StartNew();
		ArrayListDelete(arrList);
		elapsed = watch.ElapsedTicks;
		Console.WriteLine($"ArrayList (delete): { elapsed } ticks");
	}
}
