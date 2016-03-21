package md51804c85d0127fc9e640d61dd9b1f9b8b;


public class DrawerAdapter_ViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Wandertrust.DrawerAdapter+ViewHolder, Wandertrust, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DrawerAdapter_ViewHolder.class, __md_methods);
	}


	public DrawerAdapter_ViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == DrawerAdapter_ViewHolder.class)
			mono.android.TypeManager.Activate ("Wandertrust.DrawerAdapter+ViewHolder, Wandertrust, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
