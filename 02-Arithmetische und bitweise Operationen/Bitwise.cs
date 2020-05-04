using System;

namespace BitOp
{
	class Program
	{
		static void Main()
		{
			//Input:
			int x = 0b0001_0001, y=0b1000_1000, z=0b1111;

			//Queries:

			/*
				00010001
				10001000
				00001111
				--------
				00000000
			*/
			var q0 = x & y & z;
			Console.WriteLine("q0 = {0:X}", q0);

			/*
				00010001
				10001000
				00001111
				--------
				00001001
			*/
			var q1 = (x | y) & z;
			Console.WriteLine("q1 = {0:X}", q1);

			/*
				00010001
				10001000
				--------
		111 ... 01100110
			*/
			var q2 = ~(x ^ y);
			Console.WriteLine("q2 = {0:X}", q2);

			/*
				00010001
				10001000
				--------
				01100110
			*/
			var q3 = ~(x ^ y) & byte.MaxValue;
			Console.WriteLine("q3 = {0:X}", q3);
		}
	}
}
