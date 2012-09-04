// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class StackManipulation : GLib.Opaque {

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_stack_manipulation_get_pop(IntPtr raw);

		public Cdn.StackArgs Pop { 
			get {
				IntPtr raw_ret = cdn_stack_manipulation_get_pop(Handle);
				Cdn.StackArgs ret = raw_ret == IntPtr.Zero ? null : (Cdn.StackArgs) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.StackArgs), false);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_stack_manipulation_copy(IntPtr raw, IntPtr src);

		public void Copy(Cdn.StackManipulation src) {
			cdn_stack_manipulation_copy(Handle, src == null ? IntPtr.Zero : src.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_stack_manipulation_get_popn(IntPtr raw, int n);

		public Cdn.StackArg GetPopn(int n) {
			IntPtr raw_ret = cdn_stack_manipulation_get_popn(Handle, n);
			Cdn.StackArg ret = Cdn.StackArg.New (raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_stack_manipulation_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_stack_manipulation_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public StackManipulation(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern void cdn_stack_manipulation_destroy(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			cdn_stack_manipulation_destroy (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				cdn_stack_manipulation_destroy (handle);
				return false;
			}
		}

		~StackManipulation ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
