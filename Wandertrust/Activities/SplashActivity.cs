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
using Android.Support.V7.App;
using System.Threading.Tasks;

namespace Wandertrust
{
	[Activity(Theme = "@style/WandertrustTheme")]//, MainLauncher = true, NoHistory = true)]
	public class SplashActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Splash);
		}

		protected override void OnResume()
		{
			base.OnResume();

			Task startupWork = new Task(() => {
				Task.Delay(10000);
			});

			startupWork.ContinueWith(t => {
				StartActivity(new Intent(Application.Context, typeof(ScreenActivity)));
			}, TaskScheduler.FromCurrentSynchronizationContext());

			startupWork.Start();
		}
	}
}

