using System;

namespace Artihmetics
{
	class Program
	{
		static void Main()
		{
			int a = 1, b = 2, c = 3, r = 4;
			double y = 4.0;

			var d = (double)a / b;
			Console.WriteLine($"d = { d }");

			var f = ((a + b) / (c - y)) - d;
			Console.WriteLine($"f = { f }");

			var x0 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
			Console.WriteLine($"x0 = { x0 }");

			var area = Math.PI * r * r;
			Console.WriteLine($"area = { area }");
		}
	}
}
