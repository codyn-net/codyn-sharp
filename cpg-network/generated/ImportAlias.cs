// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class ImportAlias : Cpg.Import {

		[Obsolete]
		protected ImportAlias(GLib.GType gtype) : base(gtype) {}
		public ImportAlias(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_import_alias_new(IntPtr source);

		public ImportAlias (Cpg.Import source) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ImportAlias)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				if (source != null) {
					names.Add ("source");
					vals.Add (new GLib.Value (source));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = cpg_import_alias_new(source == null ? IntPtr.Zero : source.Handle);
		}

		[GLib.Property ("source")]
		public Cpg.Import Source {
			get {
				GLib.Value val = GetProperty ("source");
				Cpg.Import ret = (Cpg.Import) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_import_alias_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_import_alias_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}