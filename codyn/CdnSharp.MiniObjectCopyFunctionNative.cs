// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace CdnSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.CDeclCallback]
	internal delegate IntPtr MiniObjectCopyFunctionNative(IntPtr obj);

	internal class MiniObjectCopyFunctionInvoker {

		MiniObjectCopyFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~MiniObjectCopyFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal MiniObjectCopyFunctionInvoker (MiniObjectCopyFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal MiniObjectCopyFunctionInvoker (MiniObjectCopyFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal MiniObjectCopyFunctionInvoker (MiniObjectCopyFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Cdn.MiniObjectCopyFunction Handler {
			get {
				return new Cdn.MiniObjectCopyFunction(InvokeNative);
			}
		}

		Cdn.MiniObject InvokeNative (Cdn.MiniObject obj)
		{
			Cdn.MiniObject result = Cdn.MiniObject.GetObject(native_cb (obj == null ? IntPtr.Zero : obj.Handle)) as Cdn.MiniObject;
			return result;
		}
	}

	internal class MiniObjectCopyFunctionWrapper {

		public IntPtr NativeCallback (IntPtr obj)
		{
			try {
				Cdn.MiniObject __ret = managed (Cdn.MiniObject.GetObject(obj));
				if (release_on_call)
					gch.Free ();
				return __ret == null ? IntPtr.Zero : __ret.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal MiniObjectCopyFunctionNative NativeDelegate;
		Cdn.MiniObjectCopyFunction managed;

		public MiniObjectCopyFunctionWrapper (Cdn.MiniObjectCopyFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new MiniObjectCopyFunctionNative (NativeCallback);
		}

		public static Cdn.MiniObjectCopyFunction GetManagedDelegate (MiniObjectCopyFunctionNative native)
		{
			if (native == null)
				return null;
			MiniObjectCopyFunctionWrapper wrapper = (MiniObjectCopyFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}