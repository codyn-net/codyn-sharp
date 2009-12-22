// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class IntegratorState : GLib.Opaque {

		[DllImport("cpg-network-1.0")]
		static extern double cpg_integrator_state_get_update(IntPtr raw);

		public double Update { 
			get {
				double raw_ret = cpg_integrator_state_get_update(Handle);
				double ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_integrator_state_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_integrator_state_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_integrator_state_get_property(IntPtr raw);

		public Cpg.Property Property { 
			get {
				IntPtr raw_ret = cpg_integrator_state_get_property(Handle);
				Cpg.Property ret = raw_ret == IntPtr.Zero ? null : (Cpg.Property) GLib.Opaque.GetOpaque (raw_ret, typeof (Cpg.Property), false);
				return ret;
			}
		}

		public IntegratorState(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_integrator_state_new(IntPtr property);

		public IntegratorState (Cpg.Property property) 
		{
			Raw = cpg_integrator_state_new(property == null ? IntPtr.Zero : property.Handle);
		}

#endregion
	}
}