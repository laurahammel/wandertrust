
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
	public class MatchesFragment : Fragment
	{
		ListView matchesList;
		MatchesAdapter matchesAdapter;

		List<Traveler> matches;

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			matches = DummyData.Matches;
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.Matches, container, false);

			return view;
		}

		public override void OnViewCreated(View view, Bundle savedInstanceState)
		{
			matchesList = view.FindViewById<ListView> (Resource.Id.matches_list);

			matchesAdapter = new MatchesAdapter (matches, Activity);
			matchesList.Adapter = matchesAdapter;

			matchesList.ItemClick += delegate {
				var fragment = new ProfileFragment ();
				var fragmentManager = this.FragmentManager;
				var ft = fragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, fragment);
				ft.Commit ();
			};
		}
	}
}

