using Practica3Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica3Xamarin.ViewModels
{
    public class SignUpPageViewModel
    {
        public SignUpModel SignUpModel { get; set; } = new SignUpModel();
        public ICommand SignCommand { get; set; }

        private Page myPage;

        public SignUpPageViewModel(Page page)
        {
            myPage = page;
            SignCommand = new Command(async () => await SignUpAsync());
        }

        private async Task SignUpAsync()
        {
            if (!ValidationHelper.IsFormValid(SignUpModel, myPage)) 
            { 
                return; 
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
        }

    }
}
