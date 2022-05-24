using Phone_Program.Services;
using Phone_Program.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phone_Program
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
