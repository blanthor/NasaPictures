using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Distribute;

namespace NasaPictures
{
    public partial class App : Application
    {
        // Go to https://api.nasa.gov/index.html to register
        // for your own API Key
        public static string ApiKey = "GXdcwZ3dCxg2iJnJfuIpQomceJfKBpI0T0DpzBhv";
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // App Center Distribute 
            // TODO: (does this go before the crashes or after?)
            AppCenter.Start("ios=b001a65b-cc70-4c69-ad5f-51fefd3ea2c4;android=72f2672b-5b66-4e58-b21e-8c02a5df958e", typeof(Distribute));

            // Handle when your app starts
            AppCenter.Start("android=72f2672b-5b66-4e58-b21e-8c02a5df958e;" +
                  //"uwp={Your UWP App secret here};" +
                  "ios=b001a65b-cc70-4c69-ad5f-51fefd3ea2c4",
                  typeof(Analytics), typeof(Crashes));
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
