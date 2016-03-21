
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
	public class EditProfileFragment : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.EditProfile, container, false);

			return view;
		}

		public override void OnViewCreated(View view, Bundle savedInstanceState)
		{
			view.FindViewById<Button> (Resource.Id.show_me_my_matches).Click += delegate {
				Activity.StartActivity(typeof(MainActivity));
			};
		}
	}
}

