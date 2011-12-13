// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Monitor : GLib.Object {

		[Obsolete]
		protected Monitor(GLib.GType gtype) : base(gtype) {}
		public Monitor(IntPtr raw) : base(raw) {}

		protected Monitor() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("property")]
		public Cdn.Variable Property {
			get {
				GLib.Value val = GetProperty ("property");
				Cdn.Variable ret = (Cdn.Variable) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("network")]
		public Cdn.Network Network {
			get {
				GLib.Value val = GetProperty ("network");
				Cdn.Network ret = (Cdn.Network) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_monitor_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_monitor_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_monitor_get_variable(IntPtr raw);

		public Cdn.Variable Variable { 
			get {
				IntPtr raw_ret = cdn_monitor_get_variable(Handle);
				Cdn.Variable ret = raw_ret == IntPtr.Zero ? null : (Cdn.Variable) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.Variable), false);
				return ret;
			}
		}

#endregion
#region Customized extensions
#line 1 "Monitor.custom"
		[DllImport("codyn-3.0")]
		static extern bool cdn_monitor_get_data_resampled(IntPtr raw, double[] sites, uint n_size, double[] data);

		public double[] GetDataResampled(double[] sites) {
			int len = sites != null ? sites.Length : 0;
			
			double[] data = new double[len];
			
			cdn_monitor_get_data_resampled(Handle, sites, (uint) (sites == null ? 0 : sites.Length), data);
			
			return data;
		}
		
		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_monitor_get_data(IntPtr raw, out uint n_size);

		public double[] GetData() {
			uint n_size;
			IntPtr ret = cdn_monitor_get_data (Handle, out n_size);
			
			double[] data = new double[n_size];
			Marshal.Copy(ret, data, 0, (int)n_size);
			
			return data;
		}
		
		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_monitor_get_sites(IntPtr raw, out uint n_size);

		public double[] GetSites() {
			uint n_size;
			IntPtr ret = cdn_monitor_get_sites (Handle, out n_size);
			
			double[] data = new double[n_size];
			Marshal.Copy(ret, data, 0, (int)n_size);
			
			return data;
		}

#endregion
	}
}
