using System;

// Manual delegate type declaration would look like this:
// delegate void FullTrashCanEventHandler(object sender, TransportEventArgs e);

class TrashCan
{
	// Maximal volume, in liters
	private readonly double _volume;

	// Current volume
	private double _usedVolume = 0;

	public event EventHandler<TransportEventArgs> OnTrashCanFull;
	// Something like public List<FullTrashCanEventHandler> OnTrashCanFull;

	public double UsedVolume
	{
		get => _usedVolume;

		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("Negative volume");
			}

			_usedVolume = value;

			// Is the trashcan full?
			if (_usedVolume > _volume)
			{
				Console.WriteLine($"Trashcan overflow: { _usedVolume } liters > { _volume } liters");

				var e = new TransportEventArgs(_usedVolume);

				// OnTrashCanFull(this, e); is a bad idea:
				// If there are no registered delegates, the event is null and we throw.
				OnTrashCanFull?.Invoke(this, e); // Short form of if (OnTrashCanFull != null) { OnTrashCanFull(this, e); }
			}
		}
	}

	public TrashCan(double volume) => _volume = volume;
}
