using System;
using System.Collections.Generic;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace auladesabado
{
	public partial class RecuperarSenhaTabPage : ContentPage
	{
		public RecuperarSenhaTabPage()
		{
			InitializeComponent();
		}

		void Recuperar_Click(object sender, System.EventArgs e)
		{

			UserDialogs.Instance.Alert("Senha enviada para o e-mail " + txtEmail.Text);
		}

		async void Cancelar_Click(object sender, System.EventArgs e)
		{
			await Navigation.PopAsync();
		}

	}
}

