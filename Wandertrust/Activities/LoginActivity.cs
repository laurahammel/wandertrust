using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Wandertrust
{
	[Activity (Theme = "@style/WandertrustTheme")]
	public class LoginActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Login);

			var fragment = new WelcomeFragment ();
			var ft = FragmentManager.BeginTransaction ();
			ft.Add (Resource.Id.login_content_frame, fragment);
			ft.Commit ();
		}
	}
}


