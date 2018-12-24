using Rg.Plugins.Popup.Interfaces.Animations;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XD_XamarinLoveXDPart1.Views.Informations
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgotInformationPage : PopupPage
	{
		public ForgotInformationPage ()
		{
			InitializeComponent ();

            BackgroundClicked += (sender, e) =>
            {
                Navigation.PushAsync(new ResetPasswordPage(), true);
            };
        }
    }
}