package md5e82d3ff06f0a8c3d7ccf516ee4e8d768;


public class InvoicesEditActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onOptionsItemSelected:(Landroid/view/MenuItem;)Z:GetOnOptionsItemSelected_Landroid_view_MenuItem_Handler\n" +
			"";
		mono.android.Runtime.register ("InvoiceJe.Droid.Activities.InvoicesEditActivity, InvoiceJe.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", InvoicesEditActivity.class, __md_methods);
	}


	public InvoicesEditActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == InvoicesEditActivity.class)
			mono.android.TypeManager.Activate ("InvoiceJe.Droid.Activities.InvoicesEditActivity, InvoiceJe.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public boolean onOptionsItemSelected (android.view.MenuItem p0)
	{
		return n_onOptionsItemSelected (p0);
	}

	private native boolean n_onOptionsItemSelected (android.view.MenuItem p0);

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
