using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace auladesabado
{
	public partial class CadastrarMainPage : ContentPage
	{
		public CadastrarMainPage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{

			App.Current.MainPage = new LoginPage();

		}
	}
}

