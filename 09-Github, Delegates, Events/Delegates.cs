using System;

// Delegate type: A kind of typed function pointer
// A delegate type specifies 1.) the parameters + 2.) the return type of functions it points to.
delegate void StateChangeEventHandler(string oldS, string newS);

class Publisher
{
	// Internal state: i.e. a string
	private string _myString = "abc";

	// Event == a set of delegates
	public event StateChangeEventHandler StateChanged;

	public void modifyState(string state)
	{
		StateChanged?.Invoke(_myString, state);
		_myString = state;
	}
}

class StaticSubscriber
{
	// Handle a state change of the publisher
	public static void handleStateChange(string oldState, string newState)
	{
		Console.WriteLine($"StaticSubscriber: State changed from { oldState } to { newState }.");
	}
}

class InstanceSubscriber
{
	// Handle a state change of the publisher
	public void handleStateChange(string oldState, string newState)
	{
		Console.WriteLine($"Subscriber2: State changed from { oldState } to { newState }.");
	}
}

class Program
{
	static void Main()
	{
		Console.WriteLine("Delegates / Events");
		var publisher = new Publisher();

		// Register a static method for the event:
		publisher.StateChanged += StaticSubscriber.handleStateChange;

		var s2 = new InstanceSubscriber();

		// Register an instance method for the event:
		publisher.StateChanged += s2.handleStateChange;

		publisher.modifyState("new state");
		publisher.modifyState("just another new state");
		publisher.modifyState("one more new state");
	}
}
