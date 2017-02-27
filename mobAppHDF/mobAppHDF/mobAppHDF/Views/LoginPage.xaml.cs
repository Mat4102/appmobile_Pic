using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mobAppHDF.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void OnClicked_Co(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new MainPage());

            //  ServiceAuthentification.Authentification auth = new Authentification();
            //  auth.loginIndividu = "354579";
            //  auth.pwd = "a123456789";

            // ServiceAuthentification.AuthentificationClient servClient = new AuthentificationClient();

            //servClient.AuthentificationExtranetAsync("1060",auth);

        }
        private void OnClicked_R(object sender, EventArgs args)
        {
            this.Navigation.PushModalAsync(new MainPage());

        }
    }
}
