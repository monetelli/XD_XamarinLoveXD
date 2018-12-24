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
	public partial class RegisterPage : ContentPage
	{
        private bool clicked = false;
		public RegisterPage ()
		{
			InitializeComponent ();

            BindingContext = new MainViewModel(Navigation);

            btnREGISTER.Clicked += (sender, e) =>
              {
                  clicked = true;
              };
		}

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();

            if (clicked == true) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}