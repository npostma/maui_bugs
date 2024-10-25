using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace IntentFilterCrash
{
    [Activity(
        Theme = "@style/Maui.SplashTheme",
        MainLauncher = true,
        LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    [IntentFilter(
        new[] { Intent.ActionView },
        Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
        DataScheme = "activate",
        DataHost = "*",
        Icon = "@mipmap/appicon",

        AutoVerify = true)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            // This gets called on boot/startup but not when the intent opens the app or focuses the app
            base.OnCreate(savedInstanceState);
        }
    }
}



