using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using Primos.Core.ViewModels;

namespace Primos.Android
{
    [Activity(Label = "@string/app_name")]
    public class PrimosView : MvxActivity<PrimosViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PrimosPage);
            // Create your application here
        }
    }
}