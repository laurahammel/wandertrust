
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Wandertrust
{
	public class WelcomeFragment : Fragment
	{
		Button facebookConnect;

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.Welcome, container, false);

			return view;
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);

			facebookConnect = view.FindViewById<Button> (Resource.Id.facebook_connect);

			facebookConnect.Click += delegate {
				var fragment = new EditProfileFragment ();
				var ft = FragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.login_content_frame, fragment);
				ft.AddToBackStack(null);
				ft.Commit ();
			};
		}
	}
}

