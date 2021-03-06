// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class OperatorDelayed : Cdn.Operator {

		[Obsolete]
		protected OperatorDelayed(GLib.GType gtype) : base(gtype) {}
		public OperatorDelayed(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_operator_delayed_new();

		public OperatorDelayed () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (OperatorDelayed)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cdn_operator_delayed_new();
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_operator_delayed_get_expression(IntPtr raw);

		[GLib.Property ("expression")]
		public Cdn.Expression Expression {
			get  {
				IntPtr raw_ret = cdn_operator_delayed_get_expression(Handle);
				Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_operator_delayed_get_initial_value(IntPtr raw);

		[GLib.Property ("initial-value")]
		public Cdn.Expression InitialValue {
			get  {
				IntPtr raw_ret = cdn_operator_delayed_get_initial_value(Handle);
				Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_operator_delayed_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_operator_delayed_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
