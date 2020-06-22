using System;

class Cat: Pet, IStrokeable
{
	public virtual void Stroke()
	{
		Console.WriteLine("The cat enjoys being stroked :) purrrr");
	}

	public override string ToString() => "cat";
}
