using System;

class GarbageTruck
{
	public double GarbageAmount
	{
		get;
		private set;
	} = 0;

	public void HandleFullTrashCan(object sender, TransportEventArgs e)
	{
		// Perform the downcast back to the overflowing trashcan:
		var trashCan = (TrashCan)sender;

		// Add the amount of garbage from the trashcan into the truck:
		GarbageAmount += e.GarbageAmount;

		// Empty the can.
		trashCan.UsedVolume -= e.GarbageAmount;

		// Debug logging:
		Console.WriteLine("Total truck garbage volume is now {0:F2} liters.", GarbageAmount);
	}
}
