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
using Android.Support.V4.Widget;
using Android.Support.V7.Widget;
using Android.Content.Res;

namespace Wandertrust
{
	[Activity (Theme = "@style/WandertrustTheme")]			
	public class MainActivity : AppCompatActivity, DrawerAdapter.OnItemClickListener
	{
		Toolbar toolbar;

		DrawerLayout mDrawerLayout;
		RecyclerView mDrawerList;
		ActionBarDrawerToggle mDrawerToggle;

		string mDrawerTitle;
		string[] mDrawerItems;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);

			toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
			SetSupportActionBar(toolbar);

			mDrawerTitle = this.Title;
			mDrawerItems = Resources.GetStringArray (Resource.Array.navigation_drawer_items);
			mDrawerLayout = FindViewById<DrawerLayout> (Resource.Id.drawer_layout);
			mDrawerList = FindViewById<RecyclerView> (Resource.Id.left_drawer);

//			mDrawerLayout.SetDrawerShadow (Resource.Drawable.drawer_shadow, GravityCompat.Start);
			mDrawerList.HasFixedSize = true;
			mDrawerList.SetLayoutManager (new LinearLayoutManager (this));

			mDrawerList.SetAdapter (new DrawerAdapter (mDrawerItems, this));
			this.SupportActionBar.SetDisplayHomeAsUpEnabled (true);
			this.SupportActionBar.SetHomeButtonEnabled (true);

			mDrawerToggle = new MyActionBarDrawerToggle (this, mDrawerLayout, 0, 0);

			mDrawerLayout.SetDrawerListener (mDrawerToggle);
			if (savedInstanceState == null) //first launch
				selectItem (4);
		}

		internal class MyActionBarDrawerToggle : ActionBarDrawerToggle
		{
			MainActivity owner;

			public MyActionBarDrawerToggle (MainActivity activity, DrawerLayout layout, int openRes, int closeRes)
				: base (activity, layout, openRes, closeRes)
			{
				owner = activity;
			}

			public override void OnDrawerClosed (View drawerView)
			{
				owner.SupportActionBar.Title = owner.Title;
				owner.InvalidateOptionsMenu ();
			}

			public override void OnDrawerOpened (View drawerView)
			{
				owner.SupportActionBar.Title = owner.mDrawerTitle;
				owner.InvalidateOptionsMenu ();
			}
		}

		public override bool OnCreateOptionsMenu (IMenu menu)
		{
//			this.MenuInflater.Inflate (Resource.Menu.navigation_drawer, menu);
			return true;
		}

		public override bool OnPrepareOptionsMenu (IMenu menu)
		{
//			bool drawerOpen = mDrawerLayout.IsDrawerOpen (mDrawerList);
//			menu.FindItem (Resource.Id.action_websearch).SetVisible (!drawerOpen);
			return base.OnPrepareOptionsMenu (menu);
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			if (mDrawerToggle.OnOptionsItemSelected (item)) {
				return true;
			}

			switch (item.ItemId) {
//			case Resource.Id.action_websearch:
//				// create intent to perform web search for this planet
//				Intent intent = new Intent (Intent.ActionWebSearch);
//				intent.PutExtra (SearchManager.Query, this.SupportActionBar.Title);
//				// catch event that there's no activity to handle intent
//				if (intent.ResolveActivity (this.PackageManager) != null) {
//					StartActivity (intent);
//				} else {
//					Toast.MakeText (this, Resource.String.app_not_available, ToastLength.Long).Show ();
//				}
//				return true;
			default:
				return base.OnOptionsItemSelected (item);
			}
		}

		/* The click listener for RecyclerView in the navigation drawer */
		public void OnClick (View view, int position)
		{
			selectItem (position);
		}

		private void selectItem (int position)
		{
			switch (position)
			{
			case 4:
				var fragment = new MatchesFragment ();
				var fragmentManager = this.FragmentManager;
				var ft = fragmentManager.BeginTransaction ();
				ft.Replace (Resource.Id.content_frame, fragment);
				ft.Commit ();
				break;
			default:
				break;
			}

			Title = mDrawerItems [position];
			mDrawerLayout.CloseDrawer (mDrawerList);
		}

		private void SetTitle (string title)
		{
			this.Title = title;
			this.SupportActionBar.Title = title;
		}

		protected override void OnTitleChanged (Java.Lang.ICharSequence title, Android.Graphics.Color color)
		{
			base.OnTitleChanged (title, color);
			this.SupportActionBar.Title = title.ToString ();
		}
			
		protected override void OnPostCreate (Bundle savedInstanceState)
		{
			base.OnPostCreate (savedInstanceState);
			mDrawerToggle.SyncState ();
		}

		public override void OnConfigurationChanged (Configuration newConfig)
		{
			base.OnConfigurationChanged (newConfig);
			mDrawerToggle.OnConfigurationChanged (newConfig);
		}
	}
}

