using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhysicsCalculator
{
	public partial class MotionPage : ContentPage
	{
		double initialVelocity, finalVelocity, time, acceleration, displacement;
		bool check = true;
		public MotionPage()
		{
			InitializeComponent();
			Title = "Motion Calculator";
			BackgroundImage = "Background.9.png";
		}
		async void Calculate(object sender, EventArgs e)
		{
			if (check == true)
			{
				calcul();
				txtAcceleration.Text = acceleration.ToString();
				txtTime.Text = time.ToString();
				txtDisplacement.Text = displacement.ToString();
				txtInitialVelocity.Text = initialVelocity.ToString();
				txtFinalVelocity.Text = finalVelocity.ToString();
				check = false;
				calcButton.Text = "Reset";
			}
			else {
				txtAcceleration.Text = "";
				txtTime.Text = "";
				txtDisplacement.Text = "";
				txtInitialVelocity.Text = "";
				txtFinalVelocity.Text = "";
				error.Text = "";
				initialVelocity = 0; finalVelocity= 0; time= 0; acceleration= 0; displacement = 0;
				calcButton.Text = "Calculate";
				check = true;
			}
		}
		public void calcul()
		{
			bool valid = true;
			if (double.TryParse(txtInitialVelocity.Text, out initialVelocity) || txtInitialVelocity.Text == ""){
				if (double.TryParse(txtFinalVelocity.Text, out finalVelocity) || txtFinalVelocity.Text == ""){
					if (double.TryParse(txtTime.Text, out time) || txtTime.Text == ""){
						if (double.TryParse(txtAcceleration.Text, out acceleration) || txtDisplacement.Text == ""){
							if (double.TryParse(txtDisplacement.Text, out displacement) || txtDisplacement.Text == ""){
								valid = true;
							}else valid = false;
						}else valid = false;
					}else valid = false;
				}else valid = false;
			}else valid = false;
			/*double.TryParse(txtInitialVelocity.Text, out initialVelocity);
			double.TryParse(txtFinalVelocity.Text, out finalVelocity);
			double.TryParse(txtTime.Text, out time);
			double.TryParse(txtAcceleration.Text, out acceleration);
			double.TryParse(txtDisplacement.Text, out displacement);*/

			if (valid == true)
			{
				if (txtInitialVelocity.Text != "")
				{
					if (txtFinalVelocity.Text != "")
					{
						if (txtAcceleration.Text != "")
						{
							displacement = (Math.Pow(finalVelocity, 2) - Math.Pow(initialVelocity, 2)) / (2 * acceleration);
							time = (finalVelocity - initialVelocity) / acceleration;
						}
						else if (txtTime.Text != "")
						{
							acceleration = (finalVelocity - initialVelocity) / time;
							displacement = (finalVelocity + initialVelocity) / 2 * time;
						}
						else if (txtDisplacement.Text != "")
						{
							acceleration = (Math.Pow(finalVelocity, 2) - Math.Pow(initialVelocity, 2)) / (2 * displacement);
							time = (2 * displacement) / (initialVelocity + finalVelocity);
						}
					}
					else if (txtTime.Text != "")
					{
						if (txtAcceleration.Text != "")
						{
							finalVelocity = initialVelocity + acceleration * time;
							displacement = (initialVelocity * time) + (acceleration * time * time) / 2;
						}
						else if (txtDisplacement.Text != "")
						{
							finalVelocity = 2 * displacement / time - initialVelocity;
							acceleration = (2 * displacement - 2 * initialVelocity * time) / (time * time);
						}
					}
					else if (txtAcceleration.Text != "" && txtDisplacement.Text != "")
					{
						finalVelocity = Math.Sqrt((initialVelocity * initialVelocity) + 2 * acceleration * displacement);
						time = Math.Sqrt(displacement / (initialVelocity + .5 * acceleration));
					}
				}
				else if (txtFinalVelocity.Text != "")
				{
					if (txtAcceleration.Text != "")
					{
						if (txtTime.Text != "")
						{
							initialVelocity = finalVelocity - acceleration * time;
							displacement = (initialVelocity * time) + (acceleration * time * time) / 2;
						}
						if (txtDisplacement.Text != "")
						{
							initialVelocity = Math.Pow((finalVelocity * finalVelocity) - 2 * acceleration * displacement, 2);
							time = Math.Sqrt(displacement / (initialVelocity + .5 * acceleration));
						}
					}
					else if (txtTime.Text != "" && txtDisplacement.Text != "")
					{
						initialVelocity = 2 * displacement / time - finalVelocity;
						acceleration = (2 * displacement - 2 * initialVelocity * time) / (time * time);
					}
				}
				else if (txtAcceleration.Text != "" && txtTime.Text != "" && txtDisplacement.Text != "")
				{
					initialVelocity = (displacement - (acceleration * (time * time)) / 2) / time;
					finalVelocity = Math.Sqrt((initialVelocity * initialVelocity) + 2 * acceleration * displacement);
				}
				else error.Text = "Unable To Calculate\nPlease Try Again";
			}
			else error.Text = "Unable To Calculate\nPlease Try Again";
		}
	}
}

