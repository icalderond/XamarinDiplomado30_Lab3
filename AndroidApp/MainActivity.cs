using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidApp
{
	[Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		//protected override void OnCreate(Bundle savedInstanceState)
		//{
		//	base.OnCreate(savedInstanceState);

		//	// Set our view from the "main" layout resource
		//	SetContentView(Resource.Layout.Main);

		//	// Get our button from the layout resource,
		//	// and attach an event to it
		//	Button button = FindViewById<Button>(Resource.Id.myButton);

		//	button.Click += delegate { button.Text = $"{count++} clicks!"; };
		//}
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			var Helper = new SharedProject.MySharedCode();
			new AlertDialog.Builder(this)
				.SetMessage(Helper.GetFilePath("demo.dat"))
				.Show();
			// Set our view from the "main" layout resource
			// SetContentView (Resource.Layout.Main);
		}
	}
}

