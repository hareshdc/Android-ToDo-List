using Android.App;
using Android.Widget;
using Android.OS;

namespace Android_To_Do_List
{
    [Activity(Label = "Android_To_Do_List", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

