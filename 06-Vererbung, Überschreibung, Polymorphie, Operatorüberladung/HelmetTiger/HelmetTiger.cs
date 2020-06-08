using System;

namespace Tigers
{
	// HelmetTiger inherits from Tiger => Every HelmetTiger is also a Tiger!
	class HelmetTiger: Tiger
	{
		private Helmet _helmet;

		public override int Firmness
		{
			get
			{
				int helmetFirmness = Helmet?.Firmness ?? 0;
				return base.Firmness + helmetFirmness;
			}
		}

		public Helmet Helmet
		{
			get => _helmet;

			set
			{
				//Calculate the helmet's circumference:
				var helmetCircumference = value.Diameter * Math.PI;

				//Compare with tiger's skull circumference:
				_helmet = (helmetCircumference >= Circumference) ? value : null;
			}
		}

		public HelmetTiger(int regID, double circumference, int firmness)
			: base(regID, circumference, firmness)
		{

		}

		public HelmetTiger(int regID, double circumference, int firmness, Helmet helmet)
			: base(regID, circumference, firmness)
		{
			Helmet = helmet;
		}

		//TODO: ToString
	}
}
