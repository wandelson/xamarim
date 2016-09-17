using System;
using System.Collections.Generic;
using System.Net.Http;
using Acr.UserDialogs;
using Newtonsoft.Json;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace auladesabado
{
	public partial class DadosPage : ContentPage
	{
		public DadosPage()
		{
			InitializeComponent();

			Geo();
		}
		//http://api.geonames.org/findNearByWeatherJSON?lat=37.785834&lng=37.785834&username=deznetfiap


		async void Geo()
		{
			var locator = CrossGeolocator.Current;
			//refinar localizacao
			locator.DesiredAccuracy = 100;

			var position = await locator.GetPositionAsync(1000);

			string lat = position.Latitude.ToString();
			string log = position.Longitude.ToString();


			string url = "http://api.geonames.org/findNearByWeatherJSON?lat=" + lat + "&lng=" + log + "&username=deznetfiap";

			var maps = MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude),Distance.FromMiles(1));

			map.MoveToRegion(maps);

			var pin = new Pin { 
				Type = PinType.Place,
				Position = new Position(position.Latitude, position.Longitude),
				Label =  "Onde estou",
				Address = "Terra do Nunca"
			};

			map.Pins.Add(pin);


		 //	DisplayAlert("latitude e long","lat:" + lat + "," + "long:" + log,"ok");

			HttpClient client = new HttpClient();

			var uri = new Uri(url);


			var response = await client.GetAsync(uri);

			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();

				var output = JsonConvert.DeserializeObject<TempResultModel>(content);

				txtLat.Text = output.weatherObservation.lat.ToString();
				txtLong.Text = output.weatherObservation.lng.ToString();
				txtCountry.Text = output.weatherObservation.stationName.ToString();
				txtTemp.Text = output.weatherObservation.temperature;
			

			}

			else {
				UserDialogs.Instance.ShowError("cep nao encontrado...");
			}





		}

	}
}

