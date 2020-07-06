using System;

class TransportEventArgs: EventArgs
{
	// Amount of garbage (liters) taken out of the trashcan
	public double GarbageAmount
	{
		get;
	}

	public TransportEventArgs(double garbageAmount) => GarbageAmount = garbageAmount;
}
