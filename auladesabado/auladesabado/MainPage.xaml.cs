using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace auladesabado
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			BindingContext = new MainPageViewModel();
			InitializeComponent();
		}
	}
}
