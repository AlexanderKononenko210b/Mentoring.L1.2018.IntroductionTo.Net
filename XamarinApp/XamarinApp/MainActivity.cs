using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using ModuleStandart;

namespace XamarinApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        /// <summary>
        /// 
        /// </summary>
        private string _name;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText editText = FindViewById<EditText>(Resource.Id.editText1);
            editText.KeyPress += EditText_KeyPress;

            Button helloButton = FindViewById<Button>(Resource.Id.button1);
            helloButton.Click += HelloButton_Click;
        }

        /// <summary>
        /// Handle edit text.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arguments</param>
        private void EditText_KeyPress(object sender, View.KeyEventArgs e)
        {
            e.Handled = false;
            if (e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter)
            {
                EditText editText = (EditText)sender;
                _name = editText.Text;
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handle hello button click.
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event arguments</param>
        private void HelloButton_Click(object sender, EventArgs e)
        {
            TextView textView = FindViewById<TextView>(Resource.Id.textView1);

            textView.Text = string.IsNullOrEmpty(_name) ? "Empty name or press Enter!" : $"{Greeting.GetGreeting(_name)}";
        }
    }
}