
using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using Taylor.Core.ViewModels;

namespace Taylor.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class TaylorView : MvxActivity<TaylorViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TaylorPage);
            // Create your application here
        }
    }
}