using System;

class Goldfish: Pet, IStrokeable
{
	public void Stroke()
	{
		Console.WriteLine("blub blub :)");
	}

	public override string ToString() => "goldfish";
}
