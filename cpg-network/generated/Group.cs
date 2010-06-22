// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Group : Cpg.State {

		[Obsolete]
		protected Group(GLib.GType gtype) : base(gtype) {}
		public Group(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_new(IntPtr id, IntPtr proxy);

		public Group (string id, Cpg.Object proxy) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Group)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("id");
				vals.Add (new GLib.Value (id));
				if (proxy != null) {
					names.Add ("proxy");
					vals.Add (new GLib.Value (proxy));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			Raw = cpg_group_new(native_id, proxy == null ? IntPtr.Zero : proxy.Handle);
			GLib.Marshaller.Free (native_id);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_get_proxy(IntPtr raw);

		[GLib.Property ("proxy")]
		public Cpg.Object Proxy {
			get  {
				IntPtr raw_ret = cpg_group_get_proxy(Handle);
				Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_group_remove(IntPtr raw, IntPtr objekt);

		public bool Remove(Cpg.Object objekt) {
			bool raw_ret = cpg_group_remove(Handle, objekt == null ? IntPtr.Zero : objekt.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_find_object(IntPtr raw, IntPtr path);

		public Cpg.Object FindObject(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = cpg_group_find_object(Handle, native_path);
			Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_find_property(IntPtr raw, IntPtr path);

		public Cpg.Property FindProperty(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = cpg_group_find_property(Handle, native_path);
			Cpg.Property ret = GLib.Object.GetObject(raw_ret) as Cpg.Property;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_group_add(IntPtr raw, IntPtr objekt);

		public bool Add(Cpg.Object objekt) {
			bool raw_ret = cpg_group_add(Handle, objekt == null ? IntPtr.Zero : objekt.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_group_set_proxy(IntPtr raw, IntPtr proxy);

		public bool SetProxy(Cpg.Object proxy) {
			bool raw_ret = cpg_group_set_proxy(Handle, proxy == null ? IntPtr.Zero : proxy.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_get_children(IntPtr raw);

		public Cpg.Object[] Children { 
			get {
				IntPtr raw_ret = cpg_group_get_children(Handle);
				Cpg.Object[] ret = (Cpg.Object[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Object));
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_group_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_get_child(IntPtr raw, IntPtr name);

		public Cpg.Object GetChild(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_group_get_child(Handle, native_name);
			Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

#endregion
	}
}
