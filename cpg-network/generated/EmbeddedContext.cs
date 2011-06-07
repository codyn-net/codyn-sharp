// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class EmbeddedContext : GLib.Object {

		[Obsolete]
		protected EmbeddedContext(GLib.GType gtype) : base(gtype) {}
		public EmbeddedContext(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_context_new();

		public EmbeddedContext () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedContext)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cpg_embedded_context_new();
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_add_selection(IntPtr raw, IntPtr selection);

		public void AddSelection(Cpg.Selection selection) {
			cpg_embedded_context_add_selection(Handle, selection == null ? IntPtr.Zero : selection.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern System.IntPtr cpg_embedded_context_get_defines(IntPtr raw);

		public System.IntPtr Defines { 
			get {
				System.IntPtr raw_ret = cpg_embedded_context_get_defines(Handle);
				System.IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_context_get_expansions(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_set_expansions(IntPtr raw, IntPtr expansions);

		public GLib.SList Expansions { 
			get {
				IntPtr raw_ret = cpg_embedded_context_get_expansions(Handle);
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
			set {
				cpg_embedded_context_set_expansions(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_context_calculate(IntPtr raw, IntPtr equation);

		public string Calculate(string equation) {
			IntPtr native_equation = GLib.Marshaller.StringToPtrGStrdup (equation);
			IntPtr raw_ret = cpg_embedded_context_calculate(Handle, native_equation);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_equation);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_add_expansions(IntPtr raw, IntPtr expansions);

		public void AddExpansions(GLib.SList expansions) {
			cpg_embedded_context_add_expansions(Handle, expansions == null ? IntPtr.Zero : expansions.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_add_defines(IntPtr raw, System.IntPtr defines);

		public void AddDefines(System.IntPtr defines) {
			cpg_embedded_context_add_defines(Handle, defines);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_save(IntPtr raw);

		public void Save() {
			cpg_embedded_context_save(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_add_define(IntPtr raw, IntPtr name, IntPtr value);

		public void AddDefine(string name, string value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			cpg_embedded_context_add_define(Handle, native_name, native_value);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_value);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_context_get_define(IntPtr raw, IntPtr name);

		public string GetDefine(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_embedded_context_get_define(Handle, native_name);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern int cpg_embedded_context_increment_define(IntPtr raw, IntPtr name, int num);

		public int IncrementDefine(string name, int num) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = cpg_embedded_context_increment_define(Handle, native_name, num);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_add_expansion(IntPtr raw, IntPtr expansion);

		public void AddExpansion(Cpg.Expansion expansion) {
			cpg_embedded_context_add_expansion(Handle, expansion == null ? IntPtr.Zero : expansion.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern UIntPtr cpg_embedded_context_get_marker(IntPtr raw);

		public ulong Marker { 
			get {
				UIntPtr raw_ret = cpg_embedded_context_get_marker(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_set_selection(IntPtr raw, IntPtr selection);

		public Cpg.Selection Selection { 
			set {
				cpg_embedded_context_set_selection(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_context_get_expansion(IntPtr raw, int depth);

		public Cpg.Expansion GetExpansion(int depth) {
			IntPtr raw_ret = cpg_embedded_context_get_expansion(Handle, depth);
			Cpg.Expansion ret = GLib.Object.GetObject(raw_ret) as Cpg.Expansion;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_restore(IntPtr raw);

		public void Restore() {
			cpg_embedded_context_restore(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_embedded_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_context_set_defines(IntPtr raw, System.IntPtr defines, bool inherit);

		public void SetDefines(System.IntPtr defines, bool inherit) {
			cpg_embedded_context_set_defines(Handle, defines, inherit);
		}

#endregion
	}
}
