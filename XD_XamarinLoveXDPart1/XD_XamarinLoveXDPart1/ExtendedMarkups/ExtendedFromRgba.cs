using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XD_XamarinLoveXDPart1.ExtendedMarkups
{
    public class ExtendedFromRgba : IMarkupExtension
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }

        /*
        public ExtendedFromRgba()
        {

        }
        public ExtendedFromRgba(byte r, byte g, byte b, byte a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }
        */
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgba(R,G,B,A);
        }
    }
}
