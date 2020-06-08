using System;

namespace Sticks
{
	class Number
	{
		//Internal number repr:
		private uint _val;

		//Public symbol repr:
		private static readonly char NumChar = 'I';

		public String Symbol
		{
			get => new string(NumChar, (int)_val);

			set
			{
				//Check for validity:
				foreach (var c in value)
				{
					if (c != NumChar)
					{
						throw new FormatException("Invalid character!");
					}
				}

				_val = (uint)value.Length;
			}
		}

		//Constructors:
		public Number(uint val) => _val = val;
		public Number(string symbol) => Symbol = symbol;

		//Override System.Object methods:
		public override string ToString() => Symbol;

		public override bool Equals(object o)
		{
			var other = (o as Number);

			if (other == null)
			{
				return false;
			}

			return (other == this); //Use operator== for this!
		}

		public static Number operator+(Number lhs, Number rhs) => new Number(lhs._val + rhs._val);

		//TODO: -*/

		public static bool operator==(Number lhs, Number rhs) => lhs?._val == rhs?._val;
		public static bool operator!=(Number lhs, Number rhs) => !(lhs == rhs);

		public static bool operator<(Number lhs, Number rhs) => lhs._val < rhs._val;
		public static bool operator>(Number lhs, Number rhs) => lhs._val > rhs._val;

		public override int GetHashCode() => (int)_val;
	}
}
