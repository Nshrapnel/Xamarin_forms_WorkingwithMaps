using Android.App;
using Android.OS;
using Android.Content.PM;


namespace WorkingWithMaps.Android {

    [Activity(Label = "WorkingWithMaps.Android.Android", Icon = "@drawable/icon", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity:
    Xamarin.Forms.Platform.Android.FormsApplicationActivity 
    {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
            Xamarin.FormsMaps.Init(this, bundle);
            LoadApplication(new App()); 
        }
    }

}

