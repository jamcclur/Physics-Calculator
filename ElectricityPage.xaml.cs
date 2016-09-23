using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhysicsCalculator
{
	public partial class ElectricityPage : ContentPage
	{
		public ElectricityPage()
		{
			InitializeComponent();
			Title = "Electricity Calculator";
			BackgroundImage = "Background.9.png";


		}


		ElectricityCalculator ec = new ElectricityCalculator();
		bool atem = false;
		async void Calculate(object sender, EventArgs e)
		{
			if (atem == false)
			{
				Decimal.TryParse(currentEntry.Text, out ec.Current);
				Decimal.TryParse(voltageEntry.Text, out ec.Voltage);
				Decimal.TryParse(resistanceEntry.Text, out ec.Resistance);
				Decimal.TryParse(powerEntry.Text, out ec.Power);

				output.Text = ec.Calculate();
				currentEntry.Text = ec.Current.ToString();
				voltageEntry.Text = ec.Voltage.ToString();
				resistanceEntry.Text = ec.Resistance.ToString();
				powerEntry.Text = ec.Power.ToString();
				calculateButton.Text = "Reset";
				atem = true;
			}
			else 
			{
				currentEntry.Text= "";
				voltageEntry.Text = "";
				resistanceEntry.Text = "";
				powerEntry.Text = "";
				output.Text = "";
				calculateButton.Text = "Calculate";
				atem = false;
			}
		}
	}
}

