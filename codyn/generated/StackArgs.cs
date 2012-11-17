// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class StackArgs : GLib.Opaque {

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_stack_args_get_num(IntPtr raw);

		public uint Num { 
			get {
				uint raw_ret = cdn_stack_args_get_num(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_stack_args_append(IntPtr raw, IntPtr arg);

		public void Append(Cdn.StackArg arg) {
			cdn_stack_args_append(Handle, arg == null ? IntPtr.Zero : arg.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_stack_args_copy(IntPtr raw, IntPtr src);

		public void Copy(Cdn.StackArgs src) {
			cdn_stack_args_copy(Handle, src == null ? IntPtr.Zero : src.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_stack_args_init(IntPtr raw, int num);

		public void Init(int num) {
			cdn_stack_args_init(Handle, num);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_stack_args_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_stack_args_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public StackArgs(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_stack_args_new(int num);

		public StackArgs (int num) 
		{
			Raw = cdn_stack_args_new(num);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_stack_args_destroy(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			cdn_stack_args_destroy (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				cdn_stack_args_destroy (handle);
				return false;
			}
		}

		~StackArgs ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
