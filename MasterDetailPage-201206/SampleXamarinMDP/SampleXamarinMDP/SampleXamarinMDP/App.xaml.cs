using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleXamarinMDP.UI.Views;

namespace SampleXamarinMDP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetailPage1();
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
