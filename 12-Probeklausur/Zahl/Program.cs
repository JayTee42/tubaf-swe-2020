using System;

class Zahl
{
	private int _wert;

	public Zahl() => _wert = 0;

	public string Wert
	{
		get => Convert.ToString(_wert, 2).Replace('1', 'X').Replace('0', 'O');

		set
		{
			try
			{
				_wert = Convert.ToInt32(value.Replace('X', '1').Replace('O', '0'), 2);
			}
			catch
			{
				throw new FormatException("Ungültiger String, nur 'X' und 'O' sind erlaubt!");
			}
		}
	}

	public static Zahl zusammen(Zahl a, Zahl b)
	{
		var result = new Zahl();
		result._wert = a._wert + b._wert;

		return result;
	}

	public static Zahl zusammen(string a, string b)
	{
		var result = new Zahl();

		var za = new Zahl();
		za.Wert = a;

		var zb = new Zahl();
		zb.Wert = b;

		return zusammen(za, zb);
	}
}

class Program
{
	static void Main(string[] args)
	{
		var z1 = new Zahl();
		z1.Wert = "XOXOOO";

		var z2 = new Zahl();
		z2.Wert = "XO";

		var z3 = Zahl.zusammen(z1, z2);
		var z4 = Zahl.zusammen(z1.Wert, z2.Wert);

		Console.WriteLine($"z1 = { z1.Wert }");
		Console.WriteLine($"z2 = { z2.Wert }");
		Console.WriteLine($"z3 = { z3.Wert }");
		Console.WriteLine($"z4 = { z4.Wert }");

		try
		{
			z3.Wert = "abc";
		}
		catch (FormatException ex)
		{
			Console.WriteLine($"Exception: { ex.Message }");
		}
	}
}
