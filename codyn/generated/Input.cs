// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Input : Cdn.Object {

		[Obsolete]
		protected Input(GLib.GType gtype) : base(gtype) {}
		public Input(IntPtr raw) : base(raw) {}

		protected Input() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_input_update(IntPtr raw, IntPtr integrator);

		public void Update(Cdn.Integrator integrator) {
			cdn_input_update(Handle, integrator == null ? IntPtr.Zero : integrator.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_input_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_input_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}