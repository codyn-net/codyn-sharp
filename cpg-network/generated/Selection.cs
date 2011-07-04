// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Selection : GLib.Object {

		[Obsolete]
		protected Selection(GLib.GType gtype) : base(gtype) {}
		public Selection(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_selection_new(IntPtr objekt, IntPtr expansions, System.IntPtr defines);

		public Selection (IntPtr objekt, GLib.SList expansions, System.IntPtr defines) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Selection)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cpg_selection_new(objekt, expansions == null ? IntPtr.Zero : expansions.Handle, defines);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_selection_new_defines(IntPtr objekt, IntPtr expansions, System.IntPtr defines, bool copy_defines);

		public Selection (IntPtr objekt, GLib.SList expansions, System.IntPtr defines, bool copy_defines) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Selection)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cpg_selection_new_defines(objekt, expansions == null ? IntPtr.Zero : expansions.Handle, defines, copy_defines);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_selection_add_define(IntPtr raw, IntPtr key, IntPtr value);

		public void AddDefine(string key, string value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			cpg_selection_add_define(Handle, native_key, native_value);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_value);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_selection_copy_defines(IntPtr raw, bool copy_defines);

		public Cpg.Selection CopyDefines(bool copy_defines) {
			IntPtr raw_ret = cpg_selection_copy_defines(Handle, copy_defines);
			Cpg.Selection ret = GLib.Object.GetObject(raw_ret) as Cpg.Selection;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_selection_copy(IntPtr raw);

		public Cpg.Selection Copy() {
			IntPtr raw_ret = cpg_selection_copy(Handle);
			Cpg.Selection ret = GLib.Object.GetObject(raw_ret, true) as Cpg.Selection;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_selection_get_define(IntPtr raw, IntPtr key);

		public string GetDefine(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = cpg_selection_get_define(Handle, native_key);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_selection_get_expansions(IntPtr raw);

		public Cpg.Expansion[] Expansions { 
			get {
				IntPtr raw_ret = cpg_selection_get_expansions(Handle);
				Cpg.Expansion[] ret = (Cpg.Expansion[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Expansion));
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern System.IntPtr cpg_selection_get_defines(IntPtr raw);

		public System.IntPtr Defines { 
			get {
				System.IntPtr raw_ret = cpg_selection_get_defines(Handle);
				System.IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_selection_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_selection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_selection_get_object(IntPtr raw);

		public IntPtr Object { 
			get {
				IntPtr raw_ret = cpg_selection_get_object(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}
