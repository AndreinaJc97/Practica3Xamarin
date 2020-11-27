using Practica3Xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica3Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginPageViewModel(this);
        }

        private async void LoginValidation_ButtonClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Okay", "Bienvenido!", "OK");

        }

        private async void RegisterValidation_ButtonClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }
}