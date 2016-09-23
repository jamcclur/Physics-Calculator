using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhysicsCalculator
{
	public partial class ImpulsePage : ContentPage
	{
		public ImpulsePage()
		{
			InitializeComponent();
			Title = "Impulse Calculator";
			BackgroundImage = "Background.9.png";
		}
		public ImpulseCalculator iCalc = new ImpulseCalculator();
		bool reset = false;
		async void Calculate(object sender, EventArgs e)
		{
			if (reset == false)
			{
				Decimal.TryParse(impulseEntry.Text, out iCalc._impulse);
				Decimal.TryParse(massEntry.Text, out iCalc._mass);
				Decimal.TryParse(iniVelEntry.Text, out iCalc._initialvelocity);
				Decimal.TryParse(finVelEntry.Text, out iCalc._finalvelocity);
				error.Text = iCalc.Calculate();
				impulseEntry.Text = iCalc._impulse.ToString();
				massEntry.Text = iCalc._mass.ToString();
				iniVelEntry.Text = iCalc._initialvelocity.ToString();
				finVelEntry.Text = iCalc._finalvelocity.ToString();
				calcButton.Text = "Reset";
				reset = true;
			}
			else {
				impulseEntry.Text = "";
				massEntry.Text = "";
				iniVelEntry.Text = "";
				finVelEntry.Text = "";
				error.Text = "";
				calcButton.Text = "Calculate";
				reset = false;
			}
		}
	}
}

