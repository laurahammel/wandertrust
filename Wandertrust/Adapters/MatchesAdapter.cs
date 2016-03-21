using System;
using Android.Widget;
using System.Collections.Generic;
using Android.Views;
using Android.App;

namespace Wandertrust
{
	public class MatchesAdapter : BaseAdapter
	{
		public List<Traveler> Matches { get; set; }
		public Activity Context;

		public MatchesAdapter (List<Traveler> matches, Activity context)
		{
			Matches = matches;
			Context = context;
		}

		public override int Count
		{
			get { return Matches.Count; }
		}

		public override Java.Lang.Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View view = convertView ?? 
				Context.LayoutInflater.Inflate(Resource.Layout.MatchesListItem, null);
			
			view.FindViewById<TextView>(Resource.Id.match_name).Text = Matches[position].Name;
			view.FindViewById<TextView>(Resource.Id.match_level).Text = Matches[position].Level;
			view.FindViewById<TextView>(Resource.Id.match_interests).Text = String.Join(", ",Matches[position].Interests);

			return view;
		}
	}
}

