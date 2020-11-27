using Practica3Xamarin.Models;
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
    public partial class SignUpPage : ContentPage
    {

        public SignUpPage()
        {
            InitializeComponent();
            this.BindingContext = new SignUpPageViewModel(this);
        }

        private async void Register_ButtonClicked(object sender, EventArgs e)
        {
          //  await App.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
}