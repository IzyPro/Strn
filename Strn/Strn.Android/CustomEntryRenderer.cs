﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Strn;
using Strn.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Strn.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context) { }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                CustomEntry view = (CustomEntry)Element;
                var _gradientBackground = new GradientDrawable();
                _gradientBackground.SetShape(ShapeType.Rectangle);
                _gradientBackground.SetColor(Color.White.ToAndroid());

                _gradientBackground.SetStroke(view.BorderWidth, view.BorderColor.ToAndroid());

                _gradientBackground.SetCornerRadius(DpToPixels(this.Context, Convert.ToSingle(view.BorderRadius)));

                Control.SetBackground(_gradientBackground);
            }
            Control.SetPadding(
                (int)DpToPixels(this.Context, Convert.ToSingle(12)),
                Control.PaddingTop,
                (int)DpToPixels(this.Context, Convert.ToSingle(12)),
                Control.PaddingBottom
                );
        }

        public static float DpToPixels(Context context, float v)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, v, metrics);
        }
    }
}