using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhysicsCalculator
{
	public partial class NslPage : ContentPage
	{
		public NslPage()
		{
			InitializeComponent();
			Title = "Newton's 2nd Law Calculator";
			BackgroundImage = "Background.9.png";
		}
		NslCalculator nsl = new NslCalculator();
		bool check = true;
		async void Calculate(object sender, EventArgs e)
		{
			if (check == true)
			{
				Decimal.TryParse(forceEntry.Text, out nsl.Force);
				Decimal.TryParse(massEntry.Text, out nsl.Mass);
				Decimal.TryParse(accelerationEntry.Text, out nsl.Acc);
				output.Text = nsl.Calc();
				forceEntry.Text = nsl.Force.ToString();
				massEntry.Text = nsl.Mass.ToString();
				accelerationEntry.Text = nsl.Acc.ToString();
				calculateButton.Text = "Reset";
				check = false;
			}else
			{
				forceEntry.Text = "";
				massEntry.Text = "";
				accelerationEntry.Text = "";
				output.Text = "";
				calculateButton.Text = "Calculate";
				check = true;
			}
		}
	}
}

