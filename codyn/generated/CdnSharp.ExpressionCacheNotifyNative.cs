// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace CdnSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.CDeclCallback]
	internal delegate void ExpressionCacheNotifyNative(IntPtr expression, IntPtr userdata);

	internal class ExpressionCacheNotifyInvoker {

		ExpressionCacheNotifyNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ExpressionCacheNotifyInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ExpressionCacheNotifyInvoker (ExpressionCacheNotifyNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ExpressionCacheNotifyInvoker (ExpressionCacheNotifyNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ExpressionCacheNotifyInvoker (ExpressionCacheNotifyNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Cdn.ExpressionCacheNotify Handler {
			get {
				return new Cdn.ExpressionCacheNotify(InvokeNative);
			}
		}

		void InvokeNative (Cdn.Expression expression)
		{
			native_cb (expression == null ? IntPtr.Zero : expression.Handle, __data);
		}
	}

	internal class ExpressionCacheNotifyWrapper {

		public void NativeCallback (IntPtr expression, IntPtr userdata)
		{
			try {
				managed (GLib.Object.GetObject(expression) as Cdn.Expression);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal ExpressionCacheNotifyNative NativeDelegate;
		Cdn.ExpressionCacheNotify managed;

		public ExpressionCacheNotifyWrapper (Cdn.ExpressionCacheNotify managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ExpressionCacheNotifyNative (NativeCallback);
		}

		public static Cdn.ExpressionCacheNotify GetManagedDelegate (ExpressionCacheNotifyNative native)
		{
			if (native == null)
				return null;
			ExpressionCacheNotifyWrapper wrapper = (ExpressionCacheNotifyWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
