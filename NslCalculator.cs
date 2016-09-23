using System;
namespace PhysicsCalculator
{
	public class NslCalculator
	{
		public decimal Force, Mass, Acc;
		public NslCalculator()
		{
		}
		public string Calc()
		{
			double force = (double)Force;
			double mass = (double)Mass;
			double acc = (double)Acc;
			if (mass != 0.0 && acc != 0.0)
			{
				force = mass * acc;
				Force = (decimal)force;
				return "";
			}
			else if (force != 0.0 && acc != 0.0)
			{
				mass = force / acc;
				Mass = (decimal)mass;
				return "";
			}
			else if (force != 0.0 && mass != 0.0)
			{
				acc = force / mass;
				Acc = (decimal)acc;
				return "";
			}
			else return "Unable To Calculate\nPlease Try Again";
		}
	}
}

