// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class EmbeddedString : GLib.Object, Cdn.Statement {

		[Obsolete]
		protected EmbeddedString(GLib.GType gtype) : base(gtype) {}
		public EmbeddedString(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_new();

		public EmbeddedString () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedString)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cdn_embedded_string_new();
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_new_from_double(double s);

		public EmbeddedString (double s) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedString)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cdn_embedded_string_new_from_double(s);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_new_from_integer(int s);

		public EmbeddedString (int s) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedString)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cdn_embedded_string_new_from_integer(s);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_new_from_string(IntPtr s);

		public EmbeddedString (string s) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EmbeddedString)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			Raw = cdn_embedded_string_new_from_string(native_s);
			GLib.Marshaller.Free (native_s);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_prepend_text(IntPtr raw, IntPtr text);

		public Cdn.EmbeddedString PrependText(string text) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			IntPtr raw_ret = cdn_embedded_string_prepend_text(Handle, native_text);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			GLib.Marshaller.Free (native_text);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_push_brace(IntPtr raw);

		public Cdn.EmbeddedString PushBrace() {
			IntPtr raw_ret = cdn_embedded_string_push_brace(Handle);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_add_string(IntPtr raw, IntPtr other);

		public Cdn.EmbeddedString AddString(Cdn.EmbeddedString other) {
			IntPtr raw_ret = cdn_embedded_string_add_string(Handle, other == null ? IntPtr.Zero : other.Handle);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_embedded_string_clear_cache(IntPtr raw);

		public void ClearCache() {
			cdn_embedded_string_clear_cache(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe IntPtr cdn_embedded_string_expand(IntPtr raw, IntPtr ctx, out IntPtr error);

		public unsafe string Expand(Cdn.ExpansionContext ctx) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = cdn_embedded_string_expand(Handle, ctx == null ? IntPtr.Zero : ctx.Handle, out error);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_push(IntPtr raw, int type, int depth);

		public Cdn.EmbeddedString Push(Cdn.EmbeddedStringNodeType type, int depth) {
			IntPtr raw_ret = cdn_embedded_string_push(Handle, (int) type, depth);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_add_text(IntPtr raw, IntPtr text);

		public Cdn.EmbeddedString AddText(string text) {
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			IntPtr raw_ret = cdn_embedded_string_add_text(Handle, native_text);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			GLib.Marshaller.Free (native_text);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_embedded_string_brace_level(IntPtr raw);

		public int BraceLevel() {
			int raw_ret = cdn_embedded_string_brace_level(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_embedded_string_error_quark();

		public static int ErrorQuark() {
			int raw_ret = cdn_embedded_string_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe IntPtr cdn_embedded_string_expand_escape(IntPtr raw, IntPtr ctx, out IntPtr error);

		public unsafe string ExpandEscape(Cdn.ExpansionContext ctx) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = cdn_embedded_string_expand_escape(Handle, ctx == null ? IntPtr.Zero : ctx.Handle, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe IntPtr cdn_embedded_string_expand_multiple(IntPtr raw, IntPtr ctx, out IntPtr error);

		public unsafe GLib.SList ExpandMultiple(Cdn.ExpansionContext ctx) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = cdn_embedded_string_expand_multiple(Handle, ctx == null ? IntPtr.Zero : ctx.Handle, out error);
			GLib.SList ret = new GLib.SList(raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_pop(IntPtr raw);

		public Cdn.EmbeddedString Pop() {
			IntPtr raw_ret = cdn_embedded_string_pop(Handle);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_pop_brace(IntPtr raw);

		public Cdn.EmbeddedString PopBrace() {
			IntPtr raw_ret = cdn_embedded_string_pop_brace(Handle);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_escape(IntPtr item);

		public static string Escape(string item) {
			IntPtr native_item = GLib.Marshaller.StringToPtrGStrdup (item);
			IntPtr raw_ret = cdn_embedded_string_escape(native_item);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_item);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_collapse(IntPtr s);

		public static string Collapse(string s) {
			IntPtr raw_ret = cdn_embedded_string_collapse(GLib.Marshaller.StringToPtrGStrdup(s));
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_embedded_string_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_embedded_string_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_statement_set_column(IntPtr raw, int start, int end);

		public void SetColumn(int start, int end) {
			cdn_statement_set_column(Handle, start, end);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_statement_get_column(IntPtr raw, out int start, out int end);

		public void GetColumn(out int start, out int end) {
			cdn_statement_get_column(Handle, out start, out end);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_statement_set_line(IntPtr raw, int start, int end);

		public void SetLine(int start, int end) {
			cdn_statement_set_line(Handle, start, end);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_statement_get_line(IntPtr raw, out int start, out int end);

		public void GetLine(out int start, out int end) {
			cdn_statement_get_line(Handle, out start, out end);
		}

#endregion
	}
}
