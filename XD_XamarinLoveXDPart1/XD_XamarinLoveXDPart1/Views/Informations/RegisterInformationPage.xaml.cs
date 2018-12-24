using Rg.Plugins.Popup.Pages;
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
	public partial class RegisterInformationPage : PopupPage
	{
		public RegisterInformationPage ()
		{
			InitializeComponent ();
            BackgroundClicked += (sender, e) =>
            {
                Navigation.PushAsync(new GeneralLoginPage(), true);
            };
        }
	}
}