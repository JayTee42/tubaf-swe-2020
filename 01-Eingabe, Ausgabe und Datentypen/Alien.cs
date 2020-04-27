using System;
using System.Globalization;

namespace Alien
{
	class Program
	{
		static void Main()
		{
			string description;
			int regID;
			char category;
			double luminosity;

			try
			{
				Console.Write("Enter description -> ");
				description = Console.ReadLine();

				Console.Write("Enter reg ID -> ");
				regID = int.Parse(Console.ReadLine());

				Console.Write("Enter category -> ");
				category = char.Parse(Console.ReadLine());

				Console.Write("Enter luminosity -> ");
				luminosity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
				Console.WriteLine("Wrong input format!");
				return;
			}

			// Print output:
			Console.WriteLine("Bezeichnung: {0}", description);
			Console.WriteLine("Registriernummer: {0}", regID);
			Console.WriteLine("Category: {0}", category);

			var formattedLum = luminosity.ToString("f2", CultureInfo.InvariantCulture);

			Console.WriteLine("Luminosity: {0}", formattedLum);
		}
	}
}
