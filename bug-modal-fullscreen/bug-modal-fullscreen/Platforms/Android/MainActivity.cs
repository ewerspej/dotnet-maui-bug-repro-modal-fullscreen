using Android.App;
using Android.Content.PM;
using Android.OS;
using bug_modal_fullscreen.Services;

namespace bug_modal_fullscreen;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        //if necessary, make custom changes here
        DeviceServices.SetActivity(this);
    }
}
