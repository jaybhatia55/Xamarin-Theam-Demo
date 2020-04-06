using System;
using TheamDemo.Theam;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheamDemo
{
    public partial class App : Application
    {
        public static void ApplyTheme()
        {
            if (AppInfo.RequestedTheme == AppTheme.Dark)
            {
                // Change to dark theme
               App.Current.Resources = new DarkTheme();
            }
            else
            {
                // Change to light theme
                App.Current.Resources = new LightTheme();
            }
        }
        public App()
        {
            ApplyTheme();
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
