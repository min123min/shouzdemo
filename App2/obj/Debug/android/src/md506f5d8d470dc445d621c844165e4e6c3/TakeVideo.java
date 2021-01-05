package md506f5d8d470dc445d621c844165e4e6c3;


public class TakeVideo
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("App2.TakeVideo, App2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TakeVideo.class, __md_methods);
	}


	public TakeVideo () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TakeVideo.class)
			mono.android.TypeManager.Activate ("App2.TakeVideo, App2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
