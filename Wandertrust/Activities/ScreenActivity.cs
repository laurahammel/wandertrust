
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
	[Activity (Theme = "@style/WandertrustTheme", MainLauncher = true, NoHistory = true)]			
	public class ScreenActivity : AppCompatActivity
	{
		FrameLayout screenContentFrame;
		ImageView screenContentImage;

		int count;
		int id;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Screen);

			count = 0;
			id = 0;

			screenContentImage = FindViewById<ImageView> (Resource.Id.screen_content_image);

			screenContentFrame = FindViewById<FrameLayout> (Resource.Id.screen_content_frame);
			screenContentFrame.Click += delegate {
				NextScreen();
			};

		}

		protected override void OnResume()
		{
			base.OnResume();
			NextScreen ();
//
//			Task startupWork = new Task(() => {
//				Task.Delay(10000);
//			});
//
//			startupWork.ContinueWith(t => {
//				NextScreen();
//			}, TaskScheduler.FromCurrentSynchronizationContext());
//
//			startupWork.Start();
		}

		public void NextScreen() {
			switch (count)
			{
			case 0:
				id = Resource.Drawable.splash;
				break;
			case 1:
				id = Resource.Drawable.connectfacebook;
				break;
			case 2:
				id = Resource.Drawable.tripprofilequestions;
				break;
			case 3:
				id = Resource.Drawable.results;
				break;
			case 4:
				id = Resource.Drawable.profile;
				break;
			case 5:
				id = Resource.Drawable.chatinbox;
				break;
			case 6:
				id = Resource.Drawable.chat;
				break;
			case 7:
				id = Resource.Drawable.emilysearch;
				break;
			case 8:
				id = Resource.Drawable.chatresponse;
				break;
			case 9:
				id = Resource.Drawable.chataddtolist;
				break;
			case 10:
				id = Resource.Drawable.rate;
				break;
			default:
				break;
			}
				
			screenContentImage.SetImageDrawable(Resources.GetDrawable (id));
			count++;
		}
	}
}

