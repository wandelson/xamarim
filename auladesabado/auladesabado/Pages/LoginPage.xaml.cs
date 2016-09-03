using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace auladesabado
{
	public partial class LoginPage : ContentPage
	{
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			UserDialogs.Instance.ShowLoading("Logando como " + TxtLogin.Text);

			await Task.Delay(3000);

			UserDialogs.Instance.HideLoading();


			Navigation.InsertPageBefore(new TabbedMainPage(), this);

			await Navigation.PopAsync();

		
		}

		public LoginPage()
		{
			InitializeComponent();
		}

	}
}

