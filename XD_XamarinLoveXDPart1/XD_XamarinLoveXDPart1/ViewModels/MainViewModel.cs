using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;

using XD_XamarinLoveXDPart1.Views.Informations;
using XD_XamarinLoveXDPart1.Views;
using Rg.Plugins.Popup.Pages;

namespace XD_XamarinLoveXDPart1.ViewModels
{
    public class MainViewModel:PopupPage
    {
        private INavigation _navigation;

        public MainViewModel()
        {

        }

        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;


            #region Execution MainPages

            RegisterCommand =
            new Command(async () =>
            await GetRegister());

            ForgotPasswordCommnand =
            new Command(async () =>
            await GetForgotPassword());

            ResetPasswordCommand =
            new Command(async () =>
            await GetResetPassword());

            #endregion

            #region Execution InformationPages

            InformationMainCommand =
            new Command(async () =>
            await GetInformationMain());

            RegisterInformationCommand =
            new Command(async () =>
            await GetRegisterInformation());

            ForgotInformationCommand =
            new Command(async () =>
            await GetForgotInformation());

            ResetPasswordInformationCommnad =
            new Command(async () =>
            await GetResetPasswordInformation());

            #endregion
        }


        #region Commands MainPages
        public Command RegisterCommand { get; set; }
        public Command ForgotPasswordCommnand { get; set; }
        public Command ResetPasswordCommand { get; set; }
        #endregion

        #region Tasks MainPages
        private async Task GetRegister()
        {
            await _navigation.PushAsync(new RegisterPage());
            
        }
        private async Task GetForgotPassword()
        {
            await _navigation.PushAsync(new ForgotPasswordPage());
        }
        private async Task GetResetPassword()
        {
            await _navigation.PushAsync(new ResetPasswordPage());
        }
        #endregion


        #region Commands InformationPages
        public Command InformationMainCommand { get; set; }
        public Command RegisterInformationCommand { get; set; }
        public Command ForgotInformationCommand { get; set; }
        public Command ResetPasswordInformationCommnad { get; set; }
        #endregion

        #region Tasks InformationPages
        private async Task GetInformationMain()
        {
            await PopupNavigation.Instance.PushAsync(new InformationMainPage());
        }
        private async Task GetRegisterInformation()
        {
            await PopupNavigation.Instance.PushAsync(new RegisterInformationPage());
        }
        private async Task GetForgotInformation()
        {
            await PopupNavigation.Instance.PushAsync(new ForgotInformationPage());
            //BackgroundClicked += (sender, e) =>
            //{
            //    Navigation.PushAsync(new ResetPasswordPage(), true);
            //};
        }
        
         private async Task GetResetPasswordInformation()
        {
            await PopupNavigation.Instance.PushAsync(new ResetPasswordInformationPage());
        }
        #endregion


       

       

    }
}
