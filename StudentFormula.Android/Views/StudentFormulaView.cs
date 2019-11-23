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
using StudentFormula.Core.ViewModels;

namespace StudentFormula.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class StudentFormulaView : MvxActivity<StudentFormulaViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.StudentFormulaPage);
            // Create your application here
        }
    }
}