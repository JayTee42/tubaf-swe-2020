using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Hello zoo!");

		var myZoo = new Pet[]
		{
			new Cat(),
			new Cat(),
			new Goldfish(),
			new Guppy(),
			new Cat(),
			new PersianCat(),
		};

		foreach (var pet in myZoo)
		{
			Console.WriteLine($"I am a { pet }.");

			// Is-operator:
			if (pet is IStrokeable)
			{
				((IStrokeable)pet).Stroke();
			}
			else
			{
				Console.WriteLine("I cannot be stroked :(");
			}

			// As-operator:
			// Like the cast above, but safe!
			// Does not throw, but returns null
			// (dynamic cast)
			// I like this more because of performance (one instead of two typechecks)!
			var strokeablePet = pet as IStrokeable;

			if (strokeablePet != null)
			{
				strokeablePet.Stroke();
			}
			else
			{
				Console.WriteLine("I cannot be stroked :(");
			}
		}
	}
}
