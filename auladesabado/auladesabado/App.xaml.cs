using Xamarin.Forms;

namespace auladesabado
{
	public partial class App : Application
	{

		private static NavigationPage navigationPage ;


		public static NavigationPage  NavigationPage
		{
			get { return navigationPage;  }
			set { navigationPage = value;}

		}


		public App()
		{
			InitializeComponent();

			//MainPage = new NavigationPage(new LoginPage());

			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

