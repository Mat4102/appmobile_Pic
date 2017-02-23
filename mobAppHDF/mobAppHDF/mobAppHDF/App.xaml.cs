using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mobAppHDF.Views;
using Xamarin.Forms;

namespace mobAppHDF
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; private set; }
        private static RootPage RootPage;
        public static bool MenuIsPresented
        {
            get
            {
                return RootPage.IsPresented;
            }
            set
            {
                RootPage.IsPresented = value;
            }
        }
        public App()
        {
            InitializeComponent();

          //  MainPage = new mobAppHDF.MainPage();
            var menuPage = new mobAppHDF.Views.MenuPage();
            var loginPage = new mobAppHDF.Views.LoginPage();
            NavigationPage = new NavigationPage(new mobAppHDF.Views.MainPage());
            RootPage = new mobAppHDF.Views.RootPage();
            RootPage.Master = menuPage;
            RootPage.Detail = NavigationPage;
            MainPage = RootPage;
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
