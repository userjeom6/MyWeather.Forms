using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Android.App;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Plugin.Permissions;
using Android.Content.PM;

namespace MyWeather.Droid
{
    [Activity(Label = "@string/app_name",
    Icon = "@mipmap/ic_launcher",
    LaunchMode = LaunchMode.SingleTask,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {

		protected override void OnCreate (Bundle bundle)
		{
            AppCenter.Start("c5065832-ab34-4e0f-ba6d-8c1d526940db", typeof(Analytics), typeof(Crashes));

		    ToolbarResource = Resource.Layout.Toolbar;
		    TabLayoutResource = Resource.Layout.Tabbar;

		    base.OnCreate (bundle);

		    Forms.Init(this, bundle);
		
		    LoadApplication(new App());
            
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}


