using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhysicsCalculator
{
	public partial class PotentialEnergyPage : ContentPage
	{
		public PotentialEnergyPage()
		{
			InitializeComponent();
			Title = "Potential Energy Calculator";
			BackgroundImage = "Background.9.png";
		}
		public PotentialEnergy peCalc = new PotentialEnergy();
		bool reset = false;
		async void Calculate(object sender, EventArgs e)
		{
			if (reset == false)
			{
				Decimal.TryParse(peEntry.Text, out peCalc._PE);
				Decimal.TryParse(massEntry.Text, out peCalc._mass);
				Decimal.TryParse(accEntry.Text, out peCalc._acceleration);
				Decimal.TryParse(heightEntry.Text, out peCalc._height);
				output.Text = peCalc.Calculate();
				peEntry.Text = peCalc._PE.ToString();
				massEntry.Text = peCalc._mass.ToString();
				accEntry.Text = peCalc._acceleration.ToString();
				heightEntry.Text = peCalc._height.ToString();
				calcButton.Text = "Reset";
				reset = true;
			}
			else {
				peEntry.Text = "";
				massEntry.Text = "";
				accEntry.Text = "";
				heightEntry.Text = "";
				output.Text = "";
				calcButton.Text = "Calculate";
				reset = false;
			}
		}
	}
}

