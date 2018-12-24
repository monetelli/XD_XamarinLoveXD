using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XD_XamarinLoveXDPart1.ViewModels;

namespace XD_XamarinLoveXDPart1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResetPasswordPage : ContentPage
	{
        private bool clicked = false;
		public ResetPasswordPage ()
		{
			InitializeComponent ();

            BindingContext = new MainViewModel(Navigation);

		}

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();

            return true;
        }
    }
}