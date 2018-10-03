using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HelloMultiScreen
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // load UI from axml
            SetContentView(Resource.Layout.Second);

            // get ui
            var aLabel = FindViewById<TextView>(Resource.Id.screen2Label);

            // set label
            aLabel.Text = Intent.GetStringExtra("FirstData") ?? "Nadda";
        }
    }
}