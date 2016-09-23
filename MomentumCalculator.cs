using System;
namespace PhysicsCalculator
{
	public class MomentumCalculator
	{
		public decimal Momentum, Mass, Velocity;
		public string error;
		public MomentumCalculator()
		{
		}
		public void Calc()
		{
			double momentum = (double)Momentum;
			double mass = (double)Mass;
			double velocity = (double)Velocity;
			if (mass != 0.0 && velocity != 0.0)
			{
				momentum = mass * velocity;
				Momentum = (decimal)momentum;
				error =  "";
			}
			else if (momentum != 0.0 && velocity != 0.0)
			{
				mass = momentum / velocity;
				Mass = (decimal)mass;
				error =  "";
			}
			else if (momentum != 0.0 && mass != 0.0)
			{
				velocity = momentum / mass;
				Velocity = (decimal)velocity;
				error =  "";
			}
			else { error =  "Unable To Calculate\nPlease Try Again";}
		}
	}
}

