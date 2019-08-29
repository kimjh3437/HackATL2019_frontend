using Android.Support.Design.BottomNavigation;
using Android.Support.Design.Widget;
using Android.Views;
using Xamarin.Forms;
using HackATL_EEVM.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(NoShiftEffects), "NoShiftEffect")]
namespace HackATL_EEVM.Droid
{
    public class NoShiftEffects : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (!(Container.GetChildAt(0) is ViewGroup layout))
                return;

            if (!(layout.GetChildAt(1) is BottomNavigationView bottomNavigationView))
                return;

            // This is what we set to adjust if the shifting happens
            bottomNavigationView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityLabeled;
        }

        protected override void OnDetached()
        {
        }
    }
}