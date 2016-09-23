using System;
namespace PhysicsCalculator
{
	public class ElectricityCalculator
	{
		public decimal Power;
		public decimal Current;
		public decimal Resistance;
		public decimal Voltage;

		public ElectricityCalculator()
		{
		}
		public string Calculate()
		{
			double power = (double) Power;
			double current = (double) Current;
			double resistance = (double) Resistance;
			double voltage = (double) Voltage;

			if (power != 0.0)
			{
				if (current != 0.0)
				{
					voltage = power / current;
					resistance = Math.Pow((power / current), 2);
				}
				else if (resistance != 0.0)
				{
					voltage = Math.Pow((power * resistance), 0.5);
					current = Math.Pow((power / resistance), 0.5);
				}
				else if (voltage != 0.0)
				{
					current = power / voltage;
					resistance = Math.Pow(voltage, 2) / power;
				}
			}
			else if (current != 0.0)
			{
				if (voltage != 0.0)
				{
					power = current * voltage;
					resistance = voltage / current;
				}
				else if (resistance != 0.0)
				{
					voltage = current * resistance;
					power = Math.Pow(current, 2) * resistance;
				}
			}
			else if (resistance != 0.0)
			{
				if (voltage != 0.0)
				{
					current = voltage / resistance;
					power = Math.Pow(voltage, 2) / resistance;
				}
			}
			else {
				return "Unable To Calculate\nPlease Try Again";
			}
			Power = Math.Round((decimal)power, 2);
			Current = Math.Round((decimal)current, 2);
			Voltage = Math.Round((decimal)voltage, 2);
			Resistance = Math.Round((decimal)resistance, 2);
			return "";
		}
	}
}

