using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhysicsCalculator
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();

			BackgroundColor = Color.Gray;

			NavigationPage.SetHasNavigationBar(this, false);
		}
		async void ElectricityPageNavigate(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ElectricityPage());
		}
		async void MotionPageNavigate(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MotionPage());
		}
		async void NslPageNavigate(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new NslPage());
		}
		async void ImpulsePageNavigate(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ImpulsePage());
		}
		async void MomentumPageNavigate(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MomentumPage());
		}
		async void PotentialEnergyPageNavigate(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new PotentialEnergyPage());
		}
		async void KineticFrictionPageNavigate(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new KineticFrictionPage());
		}
	}
}

