// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class OperatorLinsolve : Cdn.Operator {

		[Obsolete]
		protected OperatorLinsolve(GLib.GType gtype) : base(gtype) {}
		public OperatorLinsolve(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_operator_linsolve_new();

		public OperatorLinsolve () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (OperatorLinsolve)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cdn_operator_linsolve_new();
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_operator_linsolve_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_operator_linsolve_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
