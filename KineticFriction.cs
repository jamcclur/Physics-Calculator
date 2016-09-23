using System;
namespace PhysicsCalculator
{
	public class KineticFriction
	{
		public decimal _Kc;
		public decimal _Nf;
		public decimal _Kf;
		public KineticFriction()
		{
		}

		public string Calculate()
		{
			double Kc = (double)_Kc;
			double Nf = (double)_Nf;
			double Kf = (double)_Kf;
			if (Kc != 0.0 && Nf != 0.0)
			{
				_Kf = (decimal)Math.Round((Kc * Nf), 2);
			}
			else if (Kf != 0.0 && Nf != 0.0)
			{
				_Kc = (decimal)Math.Round((Kf / Nf), 2);
			}
			else if (Kc != 0.0 && Kf != 0.0)
			{
				_Nf = (decimal)Math.Round((Kf / Kc), 2);
			}
			else
			{
				return "Unable To Calculate\nPlease Try Again";
			}
			return "";
		}
	}
}

