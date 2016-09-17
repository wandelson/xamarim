using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace auladesabado
{
	public partial class LoginPage : ContentPage
	{
		async void entrarClick(object sender, System.EventArgs e)
		{
			UserDialogs.Instance.ShowLoading("Logando como " + txtLogin.Text);

			await Task.Delay(3000);

			UserDialogs.Instance.HideLoading();


		/*	Navigation.InsertPageBefore(new TabbedMainPage(), this);

			await Navigation.PopAsync();*/

			await Navigation.PushAsync(new NavigationPage(new TabbedMainPage()));

		
		}

	     async void recuperarClick(object sender, System.EventArgs e)
		{
			await Navigation.PushModalAsync(new NavigationPage(new RecuperarSenhaTabPage()));
		}


		public LoginPage()
		{
			InitializeComponent();
		}

	}
}

