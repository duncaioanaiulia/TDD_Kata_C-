using Android.App;
using Android.OS;
using Android.Widget;

namespace FizzBuzz
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            TextView TxtFizzBuzz = FindViewById<TextView>(Resource.Id.text_fizz_buzz);
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();
            TxtFizzBuzz.Text = fizzBuzz.GetText();
        }

    }
}
