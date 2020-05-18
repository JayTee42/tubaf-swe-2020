using System;

class Robot
{
	// *****************************************
	//  Fields ("Felder: Variablen in Klassen")
	// *****************************************
	private string _name;

	// *****************************************************************
	//  Properties ("Eigenschaften: Methoden, die wie Felder aussehen")
	// *****************************************************************
	public string Name
	{
		get => _name;

		// Always a "value" parameter of property type!
		set => this._name = value;
	}

	/*
	// Automatic property ("Automatische Eigenschaft: Erzeugt ihr eigenes, verstecktes privates Feld")
	public string Name
	{
		get;
		set;
	} = "WALL-E";
	*/

	// *********************************************
	//  Methods ("Methoden: Funktionen in Klassen")
	// *********************************************
	public void PrintName()
	{
		// Can access all class fields / properties / methods, even private ones!
		// Here, the property "Name" is accessed.
		Console.WriteLine($"I am a robot and my name is {Name}.");

		// Here, the private field "_name" is accessed.
		// Console.WriteLine($"I am a robot and my name is {_name}.");
	}

	// Fat arrow notation ("Kurzform für Methoden mit einer einzigen Anweisung")
	// public void PrintName() => Console.WriteLine($"I am a robot and my name is {Name}.");

	/*
	// Explicit getter / setter methods that access the private field (replaced by property above).
	public string GetName()
	{
		return _name;
	}

	public void SetName(string name)
	{
		_name = name;
	}
	*/

	// Static method: Access by class ("Robot.GetPossibleEnergySources()"), not by instance.
	public static string[] GetPossibleEnergySources()
	{
		return new string[] { "sunlight", "water", "bio fuel" };
	}

	// Special method: "Constructor" (same name as class, no return type)
	public Robot(string name)
	{
		Name = name;
	}

	// Overloading ("Überladen"): Same method name, different parameters
	public Robot()
	{
		Name = "WALL-E";
	}
}

static class Program
{
	static void Main()
	{
		// Create an instance ("Instanz") of the Robot class:
		Robot robot0 = new Robot("Günther"); // <--- This calls the first constructor!
		robot0.Name = "Heinz";

		Console.WriteLine($"Name of robot0: {robot0.Name}");

		// Create another instance (this time with type inference):
		var robot1 = new Robot(); // <--- This calls the second constructor!
		Console.WriteLine($"Name of robot1: {robot1.Name}");
	}
}
