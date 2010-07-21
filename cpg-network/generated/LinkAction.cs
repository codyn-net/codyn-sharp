// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class LinkAction : GLib.Object {

		[Obsolete]
		protected LinkAction(GLib.GType gtype) : base(gtype) {}
		public LinkAction(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_new(IntPtr target, IntPtr equation);

		public LinkAction (Cpg.Property target, Cpg.Expression equation) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (LinkAction)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				if (target != null) {
					names.Add ("target");
					vals.Add (new GLib.Value (target));
				}
				if (equation != null) {
					names.Add ("equation");
					vals.Add (new GLib.Value (equation));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = cpg_link_action_new(target == null ? IntPtr.Zero : target.Handle, equation == null ? IntPtr.Zero : equation.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_get_target(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_link_action_set_target(IntPtr raw, IntPtr target);

		[GLib.Property ("target")]
		public Cpg.Property Target {
			get  {
				IntPtr raw_ret = cpg_link_action_get_target(Handle);
				Cpg.Property ret = GLib.Object.GetObject(raw_ret) as Cpg.Property;
				return ret;
			}
			set  {
				cpg_link_action_set_target(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_get_equation(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_link_action_set_equation(IntPtr raw, IntPtr equation);

		[GLib.Property ("equation")]
		public Cpg.Expression Equation {
			get  {
				IntPtr raw_ret = cpg_link_action_get_equation(Handle);
				Cpg.Expression ret = GLib.Object.GetObject(raw_ret) as Cpg.Expression;
				return ret;
			}
			set  {
				cpg_link_action_set_equation(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_link_action_depends(IntPtr raw, IntPtr property);

		public bool Depends(Cpg.Property property) {
			bool raw_ret = cpg_link_action_depends(Handle, property == null ? IntPtr.Zero : property.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_link_action_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
