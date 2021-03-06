// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Selector : GLib.Object, Cdn.Statement {

		[Obsolete]
		protected Selector(GLib.GType gtype) : base(gtype) {}
		public Selector(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_new(IntPtr root);

		public Selector (Cdn.Object root) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Selector)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				if (root != null) {
					names.Add ("root");
					vals.Add (new GLib.Value (root));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = cdn_selector_new(root == null ? IntPtr.Zero : root.Handle);
		}

		[GLib.Property ("root")]
		public Cdn.Object Root {
			get {
				GLib.Value val = GetProperty ("root");
				Cdn.Object ret = (Cdn.Object) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.CDeclCallback]
		delegate void SelectedVMDelegate (IntPtr inst, uint p0);

		static SelectedVMDelegate SelectedVMCallback;

		static void selected_cb (IntPtr inst, uint p0)
		{
			try {
				Selector inst_managed = GLib.Object.GetObject (inst, false) as Selector;
				inst_managed.OnSelected (p0);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideSelected (GLib.GType gtype)
		{
			if (SelectedVMCallback == null)
				SelectedVMCallback = new SelectedVMDelegate (selected_cb);
			OverrideVirtualMethod (gtype, "select", SelectedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Selector), ConnectionMethod="OverrideSelected")]
		protected virtual void OnSelected (uint p0)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("select")]
		public event Cdn.SelectedHandler Selected {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "select", typeof (Cdn.SelectedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "select", typeof (Cdn.SelectedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_get_parts(IntPtr raw);

		public GLib.SList Parts { 
			get {
				IntPtr raw_ret = cdn_selector_get_parts(Handle);
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_selector_append_regex_partial(IntPtr raw, IntPtr regex);

		public uint AppendRegexPartial(Cdn.EmbeddedString regex) {
			uint raw_ret = cdn_selector_append_regex_partial(Handle, regex == null ? IntPtr.Zero : regex.Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_selector_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_get_out_context(IntPtr raw, uint id);

		public GLib.SList GetOutContext(uint id) {
			IntPtr raw_ret = cdn_selector_get_out_context(Handle, id);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_selector_append_partial(IntPtr raw, IntPtr identifier);

		public uint AppendPartial(Cdn.EmbeddedString identifier) {
			uint raw_ret = cdn_selector_append_partial(Handle, identifier == null ? IntPtr.Zero : identifier.Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_select_set(IntPtr raw, IntPtr parents, int type);

		public GLib.SList SelectSet(GLib.SList parents, Cdn.SelectorType type) {
			IntPtr raw_ret = cdn_selector_select_set(Handle, parents == null ? IntPtr.Zero : parents.Handle, (int) type);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_get_in_context(IntPtr raw, uint id);

		public GLib.SList GetInContext(uint id) {
			IntPtr raw_ret = cdn_selector_get_in_context(Handle, id);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_select(IntPtr raw, IntPtr parent, int type, IntPtr context);

		public Cdn.Selection[] Select(GLib.Object parent, Cdn.SelectorType type, Cdn.ExpansionContext context) {
			IntPtr raw_ret = cdn_selector_select(Handle, parent == null ? IntPtr.Zero : parent.Handle, (int) type, context == null ? IntPtr.Zero : context.Handle);
			Cdn.Selection[] ret = (Cdn.Selection[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Selection));
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_selector_set_partial(IntPtr raw, bool partial);

		public bool Partial { 
			set {
				cdn_selector_set_partial(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_selector_set_define_context(IntPtr raw, IntPtr id);

		public string DefineContext { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cdn_selector_set_define_context(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_selector_set_self(IntPtr raw, IntPtr selection);

		public Cdn.Selection Self { 
			set {
				cdn_selector_set_self(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_selector_get_implicit_children(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_selector_set_implicit_children(IntPtr raw, bool isimplicit);

		public bool ImplicitChildren { 
			get {
				bool raw_ret = cdn_selector_get_implicit_children(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cdn_selector_set_implicit_children(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_selector_append_regex(IntPtr raw, IntPtr regex);

		public uint AppendRegex(Cdn.EmbeddedString regex) {
			uint raw_ret = cdn_selector_append_regex(Handle, regex == null ? IntPtr.Zero : regex.Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_selector_append_pseudo(IntPtr raw, int type, IntPtr arguments);

		public uint AppendPseudo(Cdn.SelectorPseudoType type, GLib.SList arguments) {
			uint raw_ret = cdn_selector_append_pseudo(Handle, (int) type, arguments == null ? IntPtr.Zero : arguments.Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_selector_append(IntPtr raw, IntPtr identifier);

		public uint Append(Cdn.EmbeddedString identifier) {
			uint raw_ret = cdn_selector_append(Handle, identifier == null ? IntPtr.Zero : identifier.Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_selector_is_pseudo_name(IntPtr name);

		public static bool IsPseudoName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = cdn_selector_is_pseudo_name(native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_selector_set_from_set(IntPtr raw, IntPtr selections);

		public GLib.SList FromSet { 
			set {
				cdn_selector_set_from_set(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_as_string(IntPtr raw);

		public string AsString() {
			IntPtr raw_ret = cdn_selector_as_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe IntPtr cdn_selector_parse(IntPtr root, IntPtr s, out IntPtr error);

		public static unsafe Cdn.Selector Parse(Cdn.Object root, string s) {
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = cdn_selector_parse(root == null ? IntPtr.Zero : root.Handle, native_s, out error);
			Cdn.Selector ret = GLib.Object.GetObject(raw_ret) as Cdn.Selector;
			GLib.Marshaller.Free (native_s);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_selector_get_last_id(IntPtr raw);

		public uint LastId { 
			get {
				uint raw_ret = cdn_selector_get_last_id(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_escape_identifier(IntPtr name);

		public static string EscapeIdentifier(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cdn_selector_escape_identifier(native_name);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
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
