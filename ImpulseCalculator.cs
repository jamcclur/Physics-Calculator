using System;
namespace PhysicsCalculator
{
	public class ImpulseCalculator
	{
		public decimal _impulse, _mass, _initialvelocity, _finalvelocity;
		public ImpulseCalculator()
		{
		}
		public string Calculate()
		{
			double impulse = (double)_impulse;
			double mass = (double)_mass;
			double velInitial = (double)_initialvelocity;
			double velFinal = (double)_finalvelocity;
			if (mass != 0.0 && velFinal != 0.0 && velInitial != 0.0)
			{
				_impulse = (decimal)((mass * velFinal) - (mass * velInitial));
			}
			else if (impulse != 0.0 && velFinal != 0.0 && velInitial != 0.0)
			{
				_mass = (decimal)((impulse) / (velFinal - velInitial));
			}
			else if (mass != 0.0 && velFinal != 0.0 && impulse != 0.0)
			{
				_finalvelocity = (decimal)(((mass * velFinal) - impulse) / mass);
			}
			else if (mass != 0.0 && velInitial != 0.0 && impulse != 0.0)
			{
				double x = ((mass * velInitial) + impulse);
				_finalvelocity = (decimal)(x / mass);
			}
			else {
				return "Unable To Calculate\nPlease Try Again";
			}
			return "";
		}
	}
}

