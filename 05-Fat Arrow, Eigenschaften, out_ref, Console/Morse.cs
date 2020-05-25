using System;
using System.Threading;

class Morse
{
	// Timing parameters:
	private static readonly int _Unit = 150;
	private static readonly int _Dit = _Unit;
	private static readonly int _Dah = 3 * _Unit;
	private static readonly int _SymbolGap = _Unit;
	private static readonly int _CharGap = 3 * _Unit;
	private static readonly int _WordGap = 7 * _Unit;

	// Extend a symbol gap to a char gap:
	private static readonly int _DeltaCharGap = _CharGap - _SymbolGap;

	// Extend a char gap to a word gap:
	private static readonly int _DeltaWordGap = _WordGap - _CharGap;

	// Styling parameters:
	private static readonly ConsoleColor _FlashColor = ConsoleColor.DarkBlue;

	private static void Flash(int msecs)
	{
		Console.BackgroundColor = _FlashColor;
		Console.Clear();

		Thread.Sleep(msecs);

		Console.BackgroundColor = ConsoleColor.Black;
		Console.Clear();
	}

	private static void MorseChar(string symbols)
	{
		foreach (var symbol in symbols)
		{
			switch (symbol)
			{
			case '.': Flash(_Dit); break;
			case '-': Flash(_Dah); break;

			default: throw new FormatException($"Unexpected morse symbol: {symbol}");
			}

			Thread.Sleep(_SymbolGap);
		}

		// Extend the last symbol gap to a char gap:
		Thread.Sleep(_DeltaCharGap);
	}

	static void Main()
	{
		// Get an input string:
		Console.Write("[Morse] -> ");
		var input = Console.ReadLine();

		// Morse it:
		foreach (var chr in input)
		{
			// Translate the current character to Morse code:
			var symbols = MorseTable.GetMorseCode(chr);

			// Is this a word gap?
			if (symbols == " ")
			{
				// Extend the last char gap to a word gap:
				Thread.Sleep(_DeltaWordGap);
			}
			else
			{
				// Encode the current char and morse its symbols:
				MorseChar(symbols);
			}
		}
	}
}
