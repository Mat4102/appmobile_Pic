using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mobAppHDF.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            BindingContext = new mobAppHDF.ViewModel.MenuPageViewModel();
            Title = "Menu";
            InitializeComponent();
        }
    }
}
