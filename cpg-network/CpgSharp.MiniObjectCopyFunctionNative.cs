// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace CpgSharp {

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

		internal Cpg.MiniObjectCopyFunction Handler {
			get {
				return new Cpg.MiniObjectCopyFunction(InvokeNative);
			}
		}

		Cpg.MiniObject InvokeNative (Cpg.MiniObject obj)
		{
			Cpg.MiniObject result = Cpg.MiniObject.GetObject(native_cb (obj == null ? IntPtr.Zero : obj.Handle)) as Cpg.MiniObject;
			return result;
		}
	}

	internal class MiniObjectCopyFunctionWrapper {

		public IntPtr NativeCallback (IntPtr obj)
		{
			try {
				Cpg.MiniObject __ret = managed (Cpg.MiniObject.GetObject(obj));
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
		Cpg.MiniObjectCopyFunction managed;

		public MiniObjectCopyFunctionWrapper (Cpg.MiniObjectCopyFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new MiniObjectCopyFunctionNative (NativeCallback);
		}

		public static Cpg.MiniObjectCopyFunction GetManagedDelegate (MiniObjectCopyFunctionNative native)
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
