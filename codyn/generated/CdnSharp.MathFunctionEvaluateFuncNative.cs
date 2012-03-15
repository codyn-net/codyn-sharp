// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace CdnSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.CDeclCallback]
	internal delegate void MathFunctionEvaluateFuncNative(IntPtr stack, int numargs, out int argdim, IntPtr userdata);

	internal class MathFunctionEvaluateFuncInvoker {

		MathFunctionEvaluateFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~MathFunctionEvaluateFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal MathFunctionEvaluateFuncInvoker (MathFunctionEvaluateFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal MathFunctionEvaluateFuncInvoker (MathFunctionEvaluateFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal MathFunctionEvaluateFuncInvoker (MathFunctionEvaluateFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Cdn.MathFunctionEvaluateFunc Handler {
			get {
				return new Cdn.MathFunctionEvaluateFunc(InvokeNative);
			}
		}

		void InvokeNative (Cdn.Stack stack, int numargs, out int argdim)
		{
			native_cb (stack == null ? IntPtr.Zero : stack.Handle, numargs, out argdim, __data);
		}
	}

	internal class MathFunctionEvaluateFuncWrapper {

		public void NativeCallback (IntPtr stack, int numargs, out int argdim, IntPtr userdata)
		{
			try {
				managed (stack == IntPtr.Zero ? null : (Cdn.Stack) GLib.Opaque.GetOpaque (stack, typeof (Cdn.Stack), false), numargs, out argdim);
				if (release_on_call)
					gch.Free ();
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

		internal MathFunctionEvaluateFuncNative NativeDelegate;
		Cdn.MathFunctionEvaluateFunc managed;

		public MathFunctionEvaluateFuncWrapper (Cdn.MathFunctionEvaluateFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new MathFunctionEvaluateFuncNative (NativeCallback);
		}

		public static Cdn.MathFunctionEvaluateFunc GetManagedDelegate (MathFunctionEvaluateFuncNative native)
		{
			if (native == null)
				return null;
			MathFunctionEvaluateFuncWrapper wrapper = (MathFunctionEvaluateFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
