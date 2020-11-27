using Practica3Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica3Xamarin.ViewModels
{
    public class LoginPageViewModel
    {
        public LoginModel LoginModel { get; set; } = new LoginModel();
        public ICommand LoginInCommand { get; }
        private Page myPage;

        public LoginPageViewModel(Page page)
        {
            myPage = page;
            LoginInCommand = new Command(async () => await LoginAsync());
        }

        private async Task LoginAsync()
        {
            if (!ValidationHelper.IsFormValid(LoginModel, myPage)) { return; }
            await myPage.DisplayAlert("Okay", "Bienvenido!", "OK");
        }
    }
}
