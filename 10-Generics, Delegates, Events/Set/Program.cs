using System;

class Program
{
	public static void Main(string[] args)
	{
		var stickSet = new Set<Sticks>();

		for (uint i = 0; i < 100; i++)
		{
			var stick = new Sticks(i);
			stickSet.Add(stick);
		}

		foreach (var stick in stickSet)
		{
			Console.WriteLine($"{ stick }");
		}
	}
}
