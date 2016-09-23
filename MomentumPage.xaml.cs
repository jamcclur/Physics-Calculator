using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhysicsCalculator
{
	public partial class MomentumPage : ContentPage
	{
		public MomentumPage()
		{
			InitializeComponent();
			Title = "Momentum Calculator";
			//BackgroundImage = "Background.9.png";

		}
		MomentumCalculator mc = new MomentumCalculator();
		bool mtn = false;
		async void Calculate(object sender, EventArgs e)
		{
			if (mtn == false){
				mtn = true;
				Decimal.TryParse(momentumEntry.Text, out mc.Momentum);
				Decimal.TryParse(massEntry.Text, out mc.Mass);
				Decimal.TryParse(velocityEntry.Text, out mc.Velocity);
				mc.Calc();
				output.Text = mc.error;
				momentumEntry.Text = mc.Momentum.ToString();
				massEntry.Text = mc.Mass.ToString();
				velocityEntry.Text = mc.Velocity.ToString();
				calculateButton.Text = "Reset";
			}
			else 
			{
				mtn = false;
				momentumEntry.Text= "";
				massEntry.Text = "";
				velocityEntry.Text = "";
				output.Text = "";
				calculateButton.Text = "Calculate";
			}
		}
	}
}

