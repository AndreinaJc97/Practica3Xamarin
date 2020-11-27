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
        public ICommand SignUpCommand { get; set; }

        private Page myPage;

        public SignUpPageViewModel(Page page)
        {
            myPage = page;
            SignUpCommand = new Command(async () => await SignUpAsync());
        }

        private async Task SignUpAsync()
        {
            if (!ValidationHelper.IsFormValid(SignUpModel, myPage)) { return; }
            await myPage.DisplayAlert("Success", "Validation Success!", "OK");
        }

    }
}
