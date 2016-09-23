using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhysicsCalculator
{
	public partial class KineticFrictionPage : ContentPage
	{
		public KineticFrictionPage()
		{
			InitializeComponent();
			Title = "Kinetic Friction Calculator";
			BackgroundImage = "Background.9.png";
		}
		public KineticFriction kfCalc = new KineticFriction();
		bool reset = false;
		async void Calculate(object sender, EventArgs e)
		{
			if (reset == false)
			{
				Decimal.TryParse(kfcEntry.Text, out kfCalc._Kc);
				Decimal.TryParse(nfEntry.Text, out kfCalc._Nf);
				Decimal.TryParse(kfEntry.Text, out kfCalc._Kf);
				output.Text = kfCalc.Calculate();
				kfcEntry.Text = kfCalc._Kc.ToString();
				nfEntry.Text = kfCalc._Nf.ToString();
				kfEntry.Text = kfCalc._Kf.ToString();
				calcButton.Text = "Reset";
				reset = true;
			}
			else {
				kfcEntry.Text = "";
				nfEntry.Text = "";
				kfEntry.Text = "";
				output.Text = "";
				calcButton.Text = "Calculate";
				reset = false;
			}
		}

	}
}

