// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace CdnSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.CDeclCallback]
	internal delegate void ExpressionEvaluateNotifyNative(IntPtr expression, IntPtr userdata);

	internal class ExpressionEvaluateNotifyInvoker {

		ExpressionEvaluateNotifyNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ExpressionEvaluateNotifyInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ExpressionEvaluateNotifyInvoker (ExpressionEvaluateNotifyNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ExpressionEvaluateNotifyInvoker (ExpressionEvaluateNotifyNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ExpressionEvaluateNotifyInvoker (ExpressionEvaluateNotifyNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Cdn.ExpressionEvaluateNotify Handler {
			get {
				return new Cdn.ExpressionEvaluateNotify(InvokeNative);
			}
		}

		void InvokeNative (Cdn.Expression expression)
		{
			native_cb (expression == null ? IntPtr.Zero : expression.Handle, __data);
		}
	}

	internal class ExpressionEvaluateNotifyWrapper {

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

		internal ExpressionEvaluateNotifyNative NativeDelegate;
		Cdn.ExpressionEvaluateNotify managed;

		public ExpressionEvaluateNotifyWrapper (Cdn.ExpressionEvaluateNotify managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ExpressionEvaluateNotifyNative (NativeCallback);
		}

		public static Cdn.ExpressionEvaluateNotify GetManagedDelegate (ExpressionEvaluateNotifyNative native)
		{
			if (native == null)
				return null;
			ExpressionEvaluateNotifyWrapper wrapper = (ExpressionEvaluateNotifyWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}