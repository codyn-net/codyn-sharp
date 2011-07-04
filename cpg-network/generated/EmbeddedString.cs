// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class EmbeddedString : GLib.Object {

		[Obsolete]
		protected EmbeddedString(GLib.GType gtype) : base(gtype) {}
		public EmbeddedString(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_new();

		public EmbeddedString () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedString)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cpg_embedded_string_new();
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_new_from_double(double s);

		public EmbeddedString (double s) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedString)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cpg_embedded_string_new_from_double(s);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_new_from_integer(int s);

		public EmbeddedString (int s) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedString)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cpg_embedded_string_new_from_integer(s);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_new_from_string(IntPtr s);

		public EmbeddedString (string s) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedString)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			Raw = cpg_embedded_string_new_from_string(native_s);
			GLib.Marshaller.Free (native_s);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_string_add_text(IntPtr raw, IntPtr text);

		public void AddText(string text) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			cpg_embedded_string_add_text(Handle, native_text);
			GLib.Marshaller.Free (native_text);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_expand_multiple(IntPtr raw, IntPtr ctx);

		public GLib.SList ExpandMultiple(Cpg.EmbeddedContext ctx) {
			IntPtr raw_ret = cpg_embedded_string_expand_multiple(Handle, ctx == null ? IntPtr.Zero : ctx.Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_push(IntPtr raw, int type, int depth);

		public Cpg.EmbeddedString Push(Cpg.EmbeddedStringNodeType type, int depth) {
			IntPtr raw_ret = cpg_embedded_string_push(Handle, (int) type, depth);
			Cpg.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cpg.EmbeddedString;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_embedded_string_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_pop(IntPtr raw);

		public Cpg.EmbeddedString Pop() {
			IntPtr raw_ret = cpg_embedded_string_pop(Handle);
			Cpg.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cpg.EmbeddedString;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_embedded_string_clear_cache(IntPtr raw);

		public void ClearCache() {
			cpg_embedded_string_clear_cache(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_expand(IntPtr raw, IntPtr ctx);

		public string Expand(Cpg.EmbeddedContext ctx) {
			IntPtr raw_ret = cpg_embedded_string_expand(Handle, ctx == null ? IntPtr.Zero : ctx.Handle);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_embedded_string_collapse(IntPtr s);

		public static string Collapse(string s) {
			IntPtr raw_ret = cpg_embedded_string_collapse(GLib.Marshaller.StringToPtrGStrdup(s));
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

#endregion
	}
}