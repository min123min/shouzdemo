package md506f5d8d470dc445d621c844165e4e6c3;


public class VideoList_VideoViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App2.VideoList+VideoViewHolder, App2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", VideoList_VideoViewHolder.class, __md_methods);
	}


	public VideoList_VideoViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == VideoList_VideoViewHolder.class)
			mono.android.TypeManager.Activate ("App2.VideoList+VideoViewHolder, App2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
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
