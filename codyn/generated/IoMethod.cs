// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class IoMethod : GLib.Object {

		[Obsolete]
		protected IoMethod(GLib.GType gtype) : base(gtype) {}
		public IoMethod(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_io_method_new(IntPtr path);

		public IoMethod (string path) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (IoMethod)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("path");
				vals.Add (new GLib.Value (path));
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			Raw = cdn_io_method_new(native_path);
			GLib.Marshaller.Free (native_path);
		}

		[GLib.Property ("path")]
		public string Path {
			get {
				GLib.Value val = GetProperty ("path");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_io_method_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_io_method_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_io_method_find(IntPtr name, int mode);

		public static GLib.GType Find(string name, Cdn.IoMode mode) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cdn_io_method_find(native_name, (int) mode);
			GLib.GType ret = new GLib.GType(raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_io_method_initialize();

		public static void Initialize() {
			cdn_io_method_initialize();
		}

#endregion
	}
}
