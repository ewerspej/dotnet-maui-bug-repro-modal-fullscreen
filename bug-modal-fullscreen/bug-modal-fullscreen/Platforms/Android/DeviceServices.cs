using Android.App;
using Android.Views;

namespace bug_modal_fullscreen.Services;

public partial class DeviceServices
{
    protected static Activity Activity;

    public static void SetActivity(Activity activity)
    {
        Activity = activity;
    }

    public partial void HideSystemControls()
    {
        Activity?.Window?.AddFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.LayoutInScreen);
        Activity?.Window?.ClearFlags(WindowManagerFlags.ForceNotFullscreen);

        var controller = Activity?.Window?.InsetsController;
        controller?.Hide(WindowInsets.Type.SystemBars());
    }

    public partial void ShowSystemControls()
    {
        Activity?.Window?.AddFlags(WindowManagerFlags.ForceNotFullscreen);
        Activity?.Window?.ClearFlags(WindowManagerFlags.Fullscreen | WindowManagerFlags.LayoutInScreen);

        var controller = Activity?.Window?.InsetsController;
        controller?.Show(WindowInsets.Type.SystemBars());
    }
}