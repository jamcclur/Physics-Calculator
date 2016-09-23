using System;
namespace PhysicsCalculator
{
	public class PotentialEnergy
	{
		public decimal _PE;
		public decimal _mass;
		public decimal _acceleration;
		public decimal _height;
		public PotentialEnergy()
		{
		}
		public string Calculate()
		{
			double mass = (double)_mass;
			double acceleration = (double)_acceleration;
			double height = (double)_height;
			double PE = (double)_PE;
			if (mass != 0.0 && acceleration != 0.0 && height != 0.0)
			{
				_PE = (decimal)Math.Round((mass * acceleration * height), 2);
			}
			else if (PE != 0.0 && acceleration != 0.0 && height != 0.0)
			{
				_mass = (decimal)Math.Round((PE / (acceleration * height)), 2);
			}
			else if (PE != 0.0 && mass != 0.0 && height != 0.0)
			{
				_acceleration = (decimal)Math.Round((PE / (mass * height)), 2);
			}
			else if (PE != 0.0 && mass != 0.0 && acceleration != 0.0)
			{
				_height = (decimal)Math.Round((PE / (mass * acceleration)), 2);
			}else{
				return "Unable To Calculate\nPlease Try Again";
			}
			return "";
		}
	}
}

