using System;
using AplicacionPrueba.M0200_UserAuthentication.M0201_LogIn;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplicacionPrueba
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new LogIn_View());
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
