using Android.App;
using Android.OS;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace HelloXamarinFormsWorld.Droid
{
    [Activity(Label = "HelloXamarinFormsWorld", MainLauncher = true)]
	public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            AppCenter.Start("2ce106b9-d38f-41c7-8e9f-086b983abaf3", typeof(Analytics), typeof(Crashes));

            base.OnCreate(bundle);

            Forms.Init(this, bundle);

			LoadApplication (new App ());
        }
    }
}
