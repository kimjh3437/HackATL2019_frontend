using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HackATL_EEVM.Droid.CustomRenderer;
using HackATL_EEVM.Extension;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(Label), typeof(LabelCustomRenderer))]
[assembly: ExportRenderer(typeof(ExtEntry), typeof(ExtEntryCustomRenderer))]
namespace HackATL_EEVM.Droid.CustomRenderer
{
    public class LabelCustomRenderer : LabelRenderer
    {
        public LabelCustomRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            string fontFamily = e.NewElement?.FontFamily;
            if (!string.IsNullOrEmpty(fontFamily))
            {
                var label = (TextView)Control; // for example
                Typeface font = Typeface.CreateFromAsset(Context.Assets, fontFamily + ".otf");
                label.Typeface = font;
            }
        }
    }

    public class ExtEntryCustomRenderer : EntryRenderer
    {
        public ExtEntryCustomRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            string fontFamily = e.NewElement?.FontFamily;
            if (!string.IsNullOrEmpty(fontFamily))
            {
                var label = (TextView)Control; // for example
                Typeface font = Typeface.CreateFromAsset(Context.Assets, fontFamily + ".otf");
                label.Typeface = font;
            }

            var nativeedittextfield = (Android.Widget.EditText)this.Control;
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(0);
            // gd.SetStroke(0, Android.Graphics.Color.ParseColor("#66000000"));
            gd.SetColor(Android.Graphics.Color.Transparent);
            nativeedittextfield.Background = gd;

            Control.SetPadding(0, 5, 5, 5);
            Control.Gravity = Android.Views.GravityFlags.CenterVertical;

        }
    }
}