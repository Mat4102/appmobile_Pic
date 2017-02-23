using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mobAppHDF.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new mobAppHDF.ViewModel.MenuPageViewModel();
        }
        private void OnClicked_I(object sender, EventArgs args)
        {
            this.Navigation.PushModalAsync(new LoginPage());

        }
    }
}
