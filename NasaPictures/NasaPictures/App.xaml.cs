using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NasaPictures
{
    public partial class App : Application
    {
        // Go to https://api.nasa.gov/index.html to register
        // for your own API Key
        public static string ApiKey = "Your API KEY Here";
        public App()
        {
            InitializeComponent();

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
