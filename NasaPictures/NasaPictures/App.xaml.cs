using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NasaPictures
{
    public partial class App : Application
    {
        public static string ApiKey = "NNKOjkoul8n1CH18TWA9gwngW1s1SmjESPjNoUFo";
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
