using System;
using System.Collections.Generic;

class Uhr
{
	public uint AktuelleStunde
	{
		get;
		private set;
	} = 0;

	public uint AktuelleMinute
	{
		get;
		private set;
	} = 0;

	public uint AktuelleSekunde
	{
		get;
		private set;
	} = 0;

	public void Laufen()
	{
		AktuelleSekunde++;
		Console.WriteLine("TickTack");

		if (AktuelleSekunde == 60)
		{
			AktuelleSekunde = 0;
			AktuelleMinute++;

			if (AktuelleMinute == 60)
			{
				AktuelleMinute = 0;
				Schlagen();
				AktuelleStunde++;

				if (AktuelleStunde == 24)
				{
					AktuelleStunde = 0;
				}
			}
		}
	}

	protected virtual void Schlagen()
	{
		Console.WriteLine("Bumm");
	}
}

class Kuckuck { /* ... */ }

class Kuckucksuhr: Uhr
{
	private Kuckuck _kuckuck;

	// => "Schlagen()" in Uhr muss mind. protected sein!
	// => "Schlagen()" in Uhr muss außerdem virtual sein!
	protected override void Schlagen()
	{
		Console.WriteLine("Kuckuck");
	}

	public Kuckucksuhr(Kuckuck kuckuck)
		: base()
	{
		_kuckuck = kuckuck;
	}
}

class Uhrmacherladen
{
	public List<Uhr> Uhren
	{
		get;
	} = new List<Uhr>();

	public void Hinzufügen(Uhr uhr) => Uhren.Add(uhr);
}

class Programm
{
	static void Main(string[] args)
	{
		// Angenommen, dass eine Instanz der Klasse
		// Kuckuck namens "kuckuck" existiert ...
		var kuckuck = new Kuckuck();

		var uhr = new Uhr();
		var kuckucksuhr = new Kuckucksuhr(kuckuck);
		var laden = new Uhrmacherladen();

		laden.Hinzufügen(uhr);
		laden.Hinzufügen(kuckucksuhr);

		while (true)
		{
			foreach (var aktuelle_uhr in laden.Uhren)
			{
				aktuelle_uhr.Laufen();
			}
		}
	}
}
