using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XD_XamarinLoveXDPart1.Customs;
using XD_XamarinLoveXDPart1.Droid.Renderers;

// LÓGICA DE ENSAMBLADO DE UN CUSTOM RENDERER
[assembly: ExportRenderer(typeof(SimpleCustomButton), typeof(SimpleCustomButtonRendererDroid))]
namespace XD_XamarinLoveXDPart1.Droid.Renderers
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class SimpleCustomButtonRendererDroid : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            var gradientDrawable = new GradientDrawable();
            // RADIO DE BORDE
            gradientDrawable.SetCornerRadius(30f);
            // SetStroke(Ancho del Borde, Color de Borde)
            gradientDrawable.SetStroke(6, Android.Graphics.Color.Rgb(67, 146, 216));
            // COLOR DE LLENADO
            gradientDrawable.SetColor(Android.Graphics.Color.Argb(125, 0, 76, 252));
            //gradientDrawable.SetSize(186, 49);
            // SetBackground(Contenedor UI)
            Control.SetBackground(gradientDrawable);
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}