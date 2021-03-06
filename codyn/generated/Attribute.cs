// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Attribute : GLib.Object {

		[Obsolete]
		protected Attribute(GLib.GType gtype) : base(gtype) {}
		public Attribute(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_attribute_new(IntPtr id);

		public Attribute (string id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Attribute)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("id");
				vals.Add (new GLib.Value (id));
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			Raw = cdn_attribute_new(native_id);
			GLib.Marshaller.Free (native_id);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_attribute_get_id(IntPtr raw);

		[GLib.Property ("id")]
		public string Id {
			get  {
				IntPtr raw_ret = cdn_attribute_get_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_attribute_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_attribute_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_attribute_get_argument(IntPtr raw, int i);

		public GLib.Object GetArgument(int i) {
			IntPtr raw_ret = cdn_attribute_get_argument(Handle, i);
			GLib.Object ret = GLib.Object.GetObject (raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_attribute_get_arguments(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_attribute_set_arguments(IntPtr raw, IntPtr arguments);

		public GLib.SList Arguments { 
			get {
				IntPtr raw_ret = cdn_attribute_get_arguments(Handle);
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
			set {
				cdn_attribute_set_arguments(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_attribute_num_arguments(IntPtr raw);

		public int NumArguments() {
			int raw_ret = cdn_attribute_num_arguments(Handle);
			int ret = raw_ret;
			return ret;
		}

#endregion
	}
}
