// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class OperatorPDiff : Cdn.Operator {

		[Obsolete]
		protected OperatorPDiff(GLib.GType gtype) : base(gtype) {}
		public OperatorPDiff(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_pdiff_new();

		public OperatorPDiff () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (OperatorPDiff)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cdn_operator_pdiff_new();
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_pdiff_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_operator_pdiff_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}