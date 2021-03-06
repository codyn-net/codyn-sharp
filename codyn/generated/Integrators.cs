// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Integrators : GLib.Object {

		[Obsolete]
		protected Integrators(GLib.GType gtype) : base(gtype) {}
		public Integrators(IntPtr raw) : base(raw) {}

		protected Integrators() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrators_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_integrators_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrators_find(IntPtr id);

		public static GLib.GType Find(string id) {
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			IntPtr raw_ret = cdn_integrators_find(native_id);
			GLib.GType ret = new GLib.GType(raw_ret);
			GLib.Marshaller.Free (native_id);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrators_list();

		public static GLib.GType[] List() {
			IntPtr raw_ret = cdn_integrators_list();
			GLib.GType[] ret = (GLib.GType[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(GLib.GType));
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_integrators_register(IntPtr gtype);

		public static void Register(GLib.GType gtype) {
			cdn_integrators_register(gtype.Val);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrators_create();

		public static Cdn.Integrator[] Create() {
			IntPtr raw_ret = cdn_integrators_create();
			Cdn.Integrator[] ret = (Cdn.Integrator[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Integrator));
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_integrators_unregister(IntPtr gtype);

		public static void Unregister(GLib.GType gtype) {
			cdn_integrators_unregister(gtype.Val);
		}

#endregion
	}
}
