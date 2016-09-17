using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using Acr.UserDialogs;
using Plugin.Geolocator;

using Xamarin.Forms;

namespace auladesabado
{
	public partial class EnderecoPage : ContentPage
	{
		public EnderecoPage()
		{
			InitializeComponent();
		
		}






		async void Handle_Unfocused(object sender, Xamarin.Forms.FocusEventArgs e)
		{

			string url = "http://viacep.com.br/ws/{0}/json/";

			HttpClient client = new HttpClient();

			var uri = new Uri(string.Format(url, cep.Text));

			var response = await client.GetAsync(uri);

			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();

				var output = JsonConvert.DeserializeObject<CepResultModel>(content);

				cep.Text = output.cep;
				rua.Text = output.rua;
				comp.Text = output.comp;
				bairro.Text = output.bairro;
				cidade.Text = output.cidade;
				uf.Text = output.uf;

			}

			else {
				UserDialogs.Instance.ShowError("cep nao encontrado...");
			}

		
		}
	}
}

