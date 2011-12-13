// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class EmbeddedContext : GLib.Object {

		[Obsolete]
		protected EmbeddedContext(GLib.GType gtype) : base(gtype) {}
		public EmbeddedContext(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_embedded_context_new();

		public EmbeddedContext () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedContext)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cdn_embedded_context_new();
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_add_selection(IntPtr raw, IntPtr selection);

		public void AddSelection(Cdn.Selection selection) {
			cdn_embedded_context_add_selection(Handle, selection == null ? IntPtr.Zero : selection.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_set_expansions(IntPtr raw, IntPtr expansions);

		public void SetExpansions(GLib.SList expansions) {
			cdn_embedded_context_set_expansions(Handle, expansions == null ? IntPtr.Zero : expansions.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern System.IntPtr cdn_embedded_context_get_defines(IntPtr raw);

		public System.IntPtr Defines { 
			get {
				System.IntPtr raw_ret = cdn_embedded_context_get_defines(Handle);
				System.IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_embedded_context_get_expansions(IntPtr raw);

		public Cdn.Expansion[] Expansions { 
			get {
				IntPtr raw_ret = cdn_embedded_context_get_expansions(Handle);
				Cdn.Expansion[] ret = (Cdn.Expansion[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Expansion));
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern unsafe IntPtr cdn_embedded_context_calculate(IntPtr raw, IntPtr equation, out IntPtr error);

		public unsafe string Calculate(string equation) {
			IntPtr native_equation = GLib.Marshaller.StringToPtrGStrdup (equation);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = cdn_embedded_context_calculate(Handle, native_equation, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_equation);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_add_expansions(IntPtr raw, IntPtr expansions);

		public void AddExpansions(GLib.SList expansions) {
			cdn_embedded_context_add_expansions(Handle, expansions == null ? IntPtr.Zero : expansions.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_add_defines(IntPtr raw, System.IntPtr defines);

		public void AddDefines(System.IntPtr defines) {
			cdn_embedded_context_add_defines(Handle, defines);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_embedded_context_copy_top(IntPtr raw);

		public Cdn.EmbeddedContext CopyTop() {
			IntPtr raw_ret = cdn_embedded_context_copy_top(Handle);
			Cdn.EmbeddedContext ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedContext;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_save_defines(IntPtr raw, bool copy_defines);

		public void SaveDefines(bool copy_defines) {
			cdn_embedded_context_save_defines(Handle, copy_defines);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_save(IntPtr raw);

		public void Save() {
			cdn_embedded_context_save(Handle);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_add_define(IntPtr raw, IntPtr name, IntPtr expansion);

		public void AddDefine(string name, Cdn.Expansion expansion) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			cdn_embedded_context_add_define(Handle, native_name, expansion == null ? IntPtr.Zero : expansion.Handle);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_embedded_context_get_define(IntPtr raw, IntPtr name);

		public Cdn.Expansion GetDefine(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cdn_embedded_context_get_define(Handle, native_name);
			Cdn.Expansion ret = raw_ret == IntPtr.Zero ? null : (Cdn.Expansion) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.Expansion), false);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_embedded_context_increment_define(IntPtr raw, IntPtr name, int num);

		public int IncrementDefine(string name, int num) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = cdn_embedded_context_increment_define(Handle, native_name, num);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_add_expansion(IntPtr raw, IntPtr expansion);

		public void AddExpansion(Cdn.Expansion expansion) {
			cdn_embedded_context_add_expansion(Handle, expansion == null ? IntPtr.Zero : expansion.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern UIntPtr cdn_embedded_context_get_marker(IntPtr raw);

		public ulong Marker { 
			get {
				UIntPtr raw_ret = cdn_embedded_context_get_marker(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_set_selection(IntPtr raw, IntPtr selection);

		public Cdn.Selection Selection { 
			set {
				cdn_embedded_context_set_selection(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_embedded_context_get_expansion(IntPtr raw, int depth);

		public Cdn.Expansion GetExpansion(int depth) {
			IntPtr raw_ret = cdn_embedded_context_get_expansion(Handle, depth);
			Cdn.Expansion ret = raw_ret == IntPtr.Zero ? null : (Cdn.Expansion) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.Expansion), false);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_restore(IntPtr raw);

		public void Restore() {
			cdn_embedded_context_restore(Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_embedded_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_embedded_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_embedded_context_set_defines(IntPtr raw, System.IntPtr defines, bool inherit);

		public void SetDefines(System.IntPtr defines, bool inherit) {
			cdn_embedded_context_set_defines(Handle, defines, inherit);
		}

#endregion
	}
}
