using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace HelloMultiScreen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class FirstScreen : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // load UI from axml
            SetContentView(Resource.Layout.activity_main);

            // get button
            var showSecondButton = FindViewById<Button>(Resource.Id.showSecond);

            // event handler for button
            showSecondButton.Click += (sender, e) =>
            {
                // intent
                var second = new Intent(this, typeof(SecondActivity));
                // add data to intent
                second.PutExtra("FirstData", "Data from first.");

                StartActivity(second);
            };
        }
    }
}