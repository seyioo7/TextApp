using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using Android.Runtime;
using System;

namespace TestApp
{
    [Activity(Label = "TestApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private object cars;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //Button
            SetContentView (Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate { button.Text = "Hello Sheyman Your First App"; };

            //CheckBox
            CheckBox checkMe = FindViewById<CheckBox>(Resource.Id.checkBox1);
            checkMe.CheckedChange += (object sender, CompoundButton.CheckedChangeEventArgs e)
               =>
            {
                CheckBox check = (CheckBox)sender;
                if (check.Checked)
                {
                    check.Text = "CheckBox Has Been Checked";
                }
                else
                {
                    check.Text = "CheckBox Has Not Been Checked";
                }
            };
            //ProgressBar
            ProgressBar pb = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            pb.Progress = 50;

            //RadioButton
            private void onClickRadioButton(Object sender, EventArgs e)
            {
                RadioButton cars = (RadioButton)sender;
                Toast.MakeText(this cars.Text,ToastLength.Short
            }
            RadioButton radio_Ferrari = FindViewById<RadioButton>(Resource.Id.radioFerrari);
            RadioButton radio_mercedes = FindViewById<RadioButton>(Resource.Id.radioMercedes);
            RadioButton radio_Laborghini = FindViewById<RadioButton>(Resource.Id.radioLamborghini);
            RadioButton radio_Audi = FindViewById<RadioButton>(Resource.Id.radioAudi);
            radio_Ferrari.Click += onClickRadioButton;
            radio_mercedes.Click += onClickRadioButton;
            radio_Laborghini.Click += onClickRadioButton;
            radio_Audi.Click += onClickRadioButton;
        }
    }
}

