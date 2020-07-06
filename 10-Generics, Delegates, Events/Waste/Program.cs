using System;
using System.Threading;

class Program
{
	public static void Main(string[] args)
	{
		var trashCan = new TrashCan(1000);
		var truck = new GarbageTruck();
		var rand = new Random();

		// Register the garbage truck as handler for our can:
		trashCan.OnTrashCanFull += truck.HandleFullTrashCan;

		while (true)
		{
			var newGarbage = 100 * rand.NextDouble();

			Console.WriteLine("Adding {0:N2} liters to the can ...", newGarbage);
			trashCan.UsedVolume += newGarbage;
			Console.WriteLine("Garbage amount is now {0:N2} liters.", trashCan.UsedVolume);

			Thread.Sleep(500);
		}
	}
}
