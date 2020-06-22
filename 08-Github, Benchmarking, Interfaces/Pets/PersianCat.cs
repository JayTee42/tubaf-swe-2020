using System;

class PersianCat: Cat
{
	public override string ToString() => "persian cat";

	public override void Stroke()
	{
		Console.WriteLine("The persian cat enjoys being stroked :) purrrr");
	}
}
