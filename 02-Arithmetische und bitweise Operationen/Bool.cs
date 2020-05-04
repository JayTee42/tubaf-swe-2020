using System;
using System.Globalization;

namespace BoolOp
{
	class Program
	{
		static void Main()
		{
			//Input:
			double x, y;

			try
			{
				//Parse x:
				Console.Write("x -> ");
				x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				//Parse y:
				Console.Write("y -> ");
				y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
				Console.WriteLine("Bad format!");
				return;
			}

			//Constants:
			var x1 = 0.1;
			var x2 = 2.0;
			var y1 = -1.1;
			var y2 = 2.7;

			//Queries:
			bool inXRange = (x1 <= x) && (x <= x2);
			Console.WriteLine($"In x range? {inXRange}");

			bool inYRange = (y1 <= y) && (y <= y2);
			Console.WriteLine($"In y range? {inYRange}");

			bool inRect = inXRange && inYRange;
			Console.WriteLine($"In rect? {inRect}");

			var eps = 0.000000001;
			var isEqual = (Math.Abs(x - x1) < eps) && (Math.Abs(y - y1) < eps);
			Console.WriteLine($"Is equal to lower left corner? {isEqual}");

			bool inOneRange = inXRange || inYRange;
			Console.WriteLine($"In one range? {inOneRange}");
		}
	}
}
