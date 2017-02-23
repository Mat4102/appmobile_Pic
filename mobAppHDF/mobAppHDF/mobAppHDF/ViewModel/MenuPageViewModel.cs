using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace mobAppHDF.ViewModel
{
    class MenuPageViewModel
    {
        public ICommand GoHomeCommand { get; set; }
        public ICommand GoSecondCommand { get; set; }
        public ICommand GoGeoCommand { get; set; }

        public MenuPageViewModel()
        {
            GoHomeCommand = new Command(GoHome);
            GoSecondCommand = new Command(GoSecond);
            //GoGeoCommand = new Command(GoGeo);
        }

        void GoHome(object obj)
        {
            App.NavigationPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

        void GoSecond(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new mobAppHDF.Views.LoginPage());
            App.MenuIsPresented = false;
        }
        //void GoGeo(object obj)
        //{
        //    App.NavigationPage.Navigation.PushAsync(new mobAppHDF.Views.Geolocalisation());
        //    App.MenuIsPresented = false;
        //}
    }
}
