using System;

namespace Tigers
{
	class Tiger
	{
		public int RegID { get; }
		public double Circumference { get; }
		public virtual int Firmness { get; }

		public Tiger(int regID, double circumference, int firmness)
		{
			RegID = regID;
			Circumference = circumference;
			Firmness = firmness;
		}

		public override string ToString()
		{
			return string.Format($"Tiger(regID: { RegID }, circumference: { Circumference }, firmness: { Firmness })");
		}
	}
}
