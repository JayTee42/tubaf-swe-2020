using System;

class Program
{
	// Create an array of diameters with values between 0.75 and 4.0.
	// The number of elements will be between 2000 and 5000.
	static double[] CreateDiameters()
	{
		// Create a random number generator:
		var rand = new Random();

		// Choose the size of the array by random:
		var count = rand.Next(2000, 5000);

		// Create the array:
		var diameters = new double[count];

		// Initialize all of them with random values between 0.75 and 4:
		for (var i = 0; i < count; i++)
		{
			diameters[i] = (rand.NextDouble() * 3.25) + 0.75;
		}

		return diameters;
	}

	// Calculate the (approx.) diameter of a nut with the given diameter.
	static double CalculateVolume(double d) => (Math.PI * d * d * d) / 6;

	static void Main()
	{
		// Create the random array of nut diameters:
		var diameters = CreateDiameters();

		// Initialize the counters:
		var hazelnutCount = 0;
		var hazelnutVol = 0.0;
		var walnutCount = 0;
		var walnutVol = 0.0;

		foreach (var d in diameters)
		{
			// Calculate the volume:
			var vol = CalculateVolume(d);

			// Classify the nut:
			if (d < 2)
			{
				hazelnutCount++;
				hazelnutVol += vol;
			}
			else
			{
				walnutCount++;
				walnutVol += vol;
			}
		}

		// Print the results:
		Console.WriteLine($"Cinderella has separated the {diameters.Length} nuts into {hazelnutCount} hazelnuts and {walnutCount} walnuts.");
		Console.WriteLine($"Average hazelnut volume: {hazelnutVol / hazelnutCount} cm^3");
		Console.WriteLine($"Average walnut volume: {walnutVol / walnutCount} cm^3");
	}
}
