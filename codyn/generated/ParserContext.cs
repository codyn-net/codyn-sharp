// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class ParserContext : GLib.Object {

		[Obsolete]
		protected ParserContext(GLib.GType gtype) : base(gtype) {}
		public ParserContext(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_new(IntPtr network);

		public ParserContext (Cdn.Network network) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ParserContext)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				if (network != null) {
					names.Add ("network");
					vals.Add (new GLib.Value (network));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = cdn_parser_context_new(network == null ? IntPtr.Zero : network.Handle);
		}

		[GLib.Property ("network")]
		public Cdn.Network Network {
			get {
				GLib.Value val = GetProperty ("network");
				Cdn.Network ret = (Cdn.Network) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.CDeclCallback]
		delegate void SelectorItemPushedVMDelegate (IntPtr inst, IntPtr p0);

		static SelectorItemPushedVMDelegate SelectorItemPushedVMCallback;

		static void selectoritempushed_cb (IntPtr inst, IntPtr p0)
		{
			try {
				ParserContext inst_managed = GLib.Object.GetObject (inst, false) as ParserContext;
				inst_managed.OnSelectorItemPushed (GLib.Object.GetObject(p0) as Cdn.Selector);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideSelectorItemPushed (GLib.GType gtype)
		{
			if (SelectorItemPushedVMCallback == null)
				SelectorItemPushedVMCallback = new SelectorItemPushedVMDelegate (selectoritempushed_cb);
			OverrideVirtualMethod (gtype, "selector-item-pushed", SelectorItemPushedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.ParserContext), ConnectionMethod="OverrideSelectorItemPushed")]
		protected virtual void OnSelectorItemPushed (Cdn.Selector p0)
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

		[GLib.Signal("selector-item-pushed")]
		public event Cdn.SelectorItemPushedHandler SelectorItemPushed {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "selector-item-pushed", typeof (Cdn.SelectorItemPushedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "selector-item-pushed", typeof (Cdn.SelectorItemPushedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ContextPushedVMDelegate (IntPtr inst);

		static ContextPushedVMDelegate ContextPushedVMCallback;

		static void contextpushed_cb (IntPtr inst)
		{
			try {
				ParserContext inst_managed = GLib.Object.GetObject (inst, false) as ParserContext;
				inst_managed.OnContextPushed ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideContextPushed (GLib.GType gtype)
		{
			if (ContextPushedVMCallback == null)
				ContextPushedVMCallback = new ContextPushedVMDelegate (contextpushed_cb);
			OverrideVirtualMethod (gtype, "context-pushed", ContextPushedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.ParserContext), ConnectionMethod="OverrideContextPushed")]
		protected virtual void OnContextPushed ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("context-pushed")]
		public event System.EventHandler ContextPushed {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "context-pushed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "context-pushed");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ContextPoppedVMDelegate (IntPtr inst);

		static ContextPoppedVMDelegate ContextPoppedVMCallback;

		static void contextpopped_cb (IntPtr inst)
		{
			try {
				ParserContext inst_managed = GLib.Object.GetObject (inst, false) as ParserContext;
				inst_managed.OnContextPopped ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideContextPopped (GLib.GType gtype)
		{
			if (ContextPoppedVMCallback == null)
				ContextPoppedVMCallback = new ContextPoppedVMDelegate (contextpopped_cb);
			OverrideVirtualMethod (gtype, "context-popped", ContextPoppedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.ParserContext), ConnectionMethod="OverrideContextPopped")]
		protected virtual void OnContextPopped ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("context-popped")]
		public event System.EventHandler ContextPopped {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "context-popped");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "context-popped");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_get_error_location(IntPtr raw, out int lstart, out int lend, out int cstart, out int cend);

		public void GetErrorLocation(out int lstart, out int lend, out int cstart, out int cend) {
			cdn_parser_context_get_error_location(Handle, out lstart, out lend, out cstart, out cend);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_current_selections(IntPtr raw);

		public GLib.SList CurrentSelections() {
			IntPtr raw_ret = cdn_parser_context_current_selections(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_line(IntPtr raw, IntPtr line, int lineno);

		public void SetLine(string line, int lineno) {
			IntPtr native_line = GLib.Marshaller.StringToPtrGStrdup (line);
			cdn_parser_context_set_line(Handle, native_line, lineno);
			GLib.Marshaller.Free (native_line);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_parser_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_equation_depth(IntPtr raw);

		public void PushEquationDepth() {
			cdn_parser_context_push_equation_depth(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_push_string(IntPtr raw);

		public Cdn.EmbeddedString PushString() {
			IntPtr raw_ret = cdn_parser_context_push_string(Handle);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_io_setting(IntPtr raw, IntPtr nameptr, IntPtr valueptr);

		public void SetIoSetting(GLib.PtrArray nameptr, GLib.PtrArray valueptr) {
			cdn_parser_context_set_io_setting(Handle, nameptr == null ? IntPtr.Zero : nameptr.Handle, valueptr == null ? IntPtr.Zero : valueptr.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_get_line_at(IntPtr raw, int lineno);

		public string GetLineAt(int lineno) {
			IntPtr raw_ret = cdn_parser_context_get_line_at(Handle, lineno);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_get_column(IntPtr raw, out int start, out int end);

		public void GetColumn(out int start, out int end) {
			cdn_parser_context_get_column(Handle, out start, out end);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_input_from_path(IntPtr raw, IntPtr filename, bool only_in_context, bool isonce);

		public void PushInputFromPath(Cdn.EmbeddedString filename, bool only_in_context, bool isonce) {
			cdn_parser_context_push_input_from_path(Handle, filename == null ? IntPtr.Zero : filename.Handle, only_in_context, isonce);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_function(IntPtr raw, IntPtr id, IntPtr args, IntPtr expression, bool optional);

		public void PushFunction(Cdn.EmbeddedString id, GLib.SList args, Cdn.EmbeddedString expression, bool optional) {
			cdn_parser_context_push_function(Handle, id == null ? IntPtr.Zero : id.Handle, args == null ? IntPtr.Zero : args.Handle, expression == null ? IntPtr.Zero : expression.Handle, optional);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_add_layout_position(IntPtr raw, IntPtr selector, IntPtr x, IntPtr y, IntPtr of, bool cartesian);

		public void AddLayoutPosition(Cdn.Selector selector, GLib.PtrArray x, GLib.PtrArray y, Cdn.Selector of, bool cartesian) {
			cdn_parser_context_add_layout_position(Handle, selector == null ? IntPtr.Zero : selector.Handle, x == null ? IntPtr.Zero : x.Handle, y == null ? IntPtr.Zero : y.Handle, of == null ? IntPtr.Zero : of.Handle, cartesian);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_get_error(IntPtr raw);

		public IntPtr Error { 
			get {
				IntPtr raw_ret = cdn_parser_context_get_error(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_apply_template(IntPtr raw, IntPtr templates, IntPtr targets);

		public void ApplyTemplate(Cdn.Selector templates, Cdn.Selector targets) {
			cdn_parser_context_apply_template(Handle, templates == null ? IntPtr.Zero : templates.Handle, targets == null ? IntPtr.Zero : targets.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_define(IntPtr raw, IntPtr nameptr, IntPtr valueptr, bool optional, bool fromenv);

		public void Define(GLib.PtrArray nameptr, GLib.PtrArray valueptr, bool optional, bool fromenv) {
			cdn_parser_context_define(Handle, nameptr == null ? IntPtr.Zero : nameptr.Handle, valueptr == null ? IntPtr.Zero : valueptr.Handle, optional, fromenv);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_previous_selections(IntPtr raw);

		public GLib.SList PreviousSelections() {
			IntPtr raw_ret = cdn_parser_context_previous_selections(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_pop(IntPtr raw);

		public void Pop() {
			cdn_parser_context_pop(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_selector_identifier(IntPtr raw, IntPtr identifier);

		public void PushSelectorIdentifier(Cdn.EmbeddedString identifier) {
			cdn_parser_context_push_selector_identifier(Handle, identifier == null ? IntPtr.Zero : identifier.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_objects(IntPtr raw, IntPtr objects);

		public void PushObjects(GLib.SList objects) {
			cdn_parser_context_push_objects(Handle, objects == null ? IntPtr.Zero : objects.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_delete_selector(IntPtr raw, IntPtr selector);

		public void DeleteSelector(Cdn.Selector selector) {
			cdn_parser_context_delete_selector(Handle, selector == null ? IntPtr.Zero : selector.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_parser_context_pop_equation_depth(IntPtr raw);

		public bool PopEquationDepth() {
			bool raw_ret = cdn_parser_context_pop_equation_depth(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_node(IntPtr raw, IntPtr id, IntPtr templates);

		public void PushNode(Cdn.EmbeddedString id, GLib.SList templates) {
			cdn_parser_context_push_node(Handle, id == null ? IntPtr.Zero : id.Handle, templates == null ? IntPtr.Zero : templates.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_add_action(IntPtr raw, IntPtr target, IntPtr expression, IntPtr phases, bool integrated);

		public void AddAction(GLib.PtrArray target, GLib.PtrArray expression, Cdn.EmbeddedString phases, bool integrated) {
			cdn_parser_context_add_action(Handle, target == null ? IntPtr.Zero : target.Handle, expression == null ? IntPtr.Zero : expression.Handle, phases == null ? IntPtr.Zero : phases.Handle, integrated);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_selector_define_context(IntPtr raw, IntPtr id);

		public void PushSelectorDefineContext(string id) {
			cdn_parser_context_push_selector_define_context(Handle, GLib.Marshaller.StringToPtrGStrdup(id));
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_unapply_template(IntPtr raw, IntPtr templates, IntPtr targets);

		public void UnapplyTemplate(Cdn.Selector templates, Cdn.Selector targets) {
			cdn_parser_context_unapply_template(Handle, templates == null ? IntPtr.Zero : templates.Handle, targets == null ? IntPtr.Zero : targets.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_add_interface(IntPtr raw, IntPtr name, IntPtr child_name, IntPtr property_name, bool is_optional);

		public void AddInterface(Cdn.EmbeddedString name, Cdn.EmbeddedString child_name, Cdn.EmbeddedString property_name, bool is_optional) {
			cdn_parser_context_add_interface(Handle, name == null ? IntPtr.Zero : name.Handle, child_name == null ? IntPtr.Zero : child_name.Handle, property_name == null ? IntPtr.Zero : property_name.Handle, is_optional);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_parser_context_get_first_eof(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_first_eof(IntPtr raw, bool firsteof);

		public bool FirstEof { 
			get {
				bool raw_ret = cdn_parser_context_get_first_eof(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cdn_parser_context_set_first_eof(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_network(IntPtr raw);

		public void PushNetwork() {
			cdn_parser_context_push_network(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_add_event_set_variable(IntPtr raw, IntPtr selector, IntPtr value);

		public void AddEventSetVariable(Cdn.Selector selector, Cdn.EmbeddedString value) {
			cdn_parser_context_add_event_set_variable(Handle, selector == null ? IntPtr.Zero : selector.Handle, value == null ? IntPtr.Zero : value.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_read(IntPtr raw, IntPtr buffer, UIntPtr max_size);

		public long Read(string buffer, ulong max_size) {
			IntPtr raw_ret = cdn_parser_context_read(Handle, GLib.Marshaller.StringToPtrGStrdup(buffer), new UIntPtr (max_size));
			long ret = (long) raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_add_polynomial(IntPtr raw, IntPtr name, IntPtr pieces);

		public void AddPolynomial(Cdn.EmbeddedString name, GLib.SList pieces) {
			cdn_parser_context_add_polynomial(Handle, name == null ? IntPtr.Zero : name.Handle, pieces == null ? IntPtr.Zero : pieces.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_link_library(IntPtr raw, IntPtr filename);

		public void LinkLibrary(Cdn.EmbeddedString filename) {
			cdn_parser_context_link_library(Handle, filename == null ? IntPtr.Zero : filename.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_error(IntPtr raw, IntPtr message);

		public void SetError(string message) {
			IntPtr native_message = GLib.Marshaller.StringToPtrGStrdup (message);
			cdn_parser_context_set_error(Handle, native_message);
			GLib.Marshaller.Free (native_message);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_selector_regex(IntPtr raw, IntPtr regex);

		public void PushSelectorRegex(Cdn.EmbeddedString regex) {
			cdn_parser_context_push_selector_regex(Handle, regex == null ? IntPtr.Zero : regex.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_parser_context_peek_equation_depth(IntPtr raw);

		public int PeekEquationDepth() {
			int raw_ret = cdn_parser_context_peek_equation_depth(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_get_last_selector_item_line(IntPtr raw, out int line_start, out int line_end);

		public void GetLastSelectorItemLine(out int line_start, out int line_end) {
			cdn_parser_context_get_last_selector_item_line(Handle, out line_start, out line_end);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_pop_input(IntPtr raw);

		public void PopInput() {
			cdn_parser_context_pop_input(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_column(IntPtr raw, int start, int end);

		public void SetColumn(int start, int end) {
			cdn_parser_context_set_column(Handle, start, end);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_peek_string(IntPtr raw);

		public Cdn.EmbeddedString PeekString() {
			IntPtr raw_ret = cdn_parser_context_peek_string(Handle);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_layout(IntPtr raw);

		public void PushLayout() {
			cdn_parser_context_push_layout(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_input_from_string(IntPtr raw, IntPtr s, bool only_in_context);

		public void PushInputFromString(string s, bool only_in_context) {
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			cdn_parser_context_push_input_from_string(Handle, native_s, only_in_context);
			GLib.Marshaller.Free (native_s);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_io_type(IntPtr raw, int mode, IntPtr id, IntPtr type);

		public void PushIoType(Cdn.IoMode mode, Cdn.EmbeddedString id, Cdn.EmbeddedString type) {
			cdn_parser_context_push_io_type(Handle, (int) mode, id == null ? IntPtr.Zero : id.Handle, type == null ? IntPtr.Zero : type.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_get_scanner(IntPtr raw);

		public IntPtr Scanner { 
			get {
				IntPtr raw_ret = cdn_parser_context_get_scanner(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe bool cdn_parser_context_parse(IntPtr raw, bool push_network, out IntPtr error);

		public unsafe bool Parse(bool push_network) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_parser_context_parse(Handle, push_network, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_emit(IntPtr raw, bool emit);

		public bool Emit { 
			set {
				cdn_parser_context_set_emit(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_selection(IntPtr raw, IntPtr selector, int type, IntPtr templates);

		public void PushSelection(Cdn.Selector selector, Cdn.SelectorType type, GLib.SList templates) {
			cdn_parser_context_push_selection(Handle, selector == null ? IntPtr.Zero : selector.Handle, (int) type, templates == null ? IntPtr.Zero : templates.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_remove_record(IntPtr raw, int len, int offset);

		public void RemoveRecord(int len, int offset) {
			cdn_parser_context_remove_record(Handle, len, offset);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_add_integrator_variable(IntPtr raw, IntPtr name, IntPtr value);

		public void AddIntegratorVariable(Cdn.EmbeddedString name, Cdn.EmbeddedString value) {
			cdn_parser_context_add_integrator_variable(Handle, name == null ? IntPtr.Zero : name.Handle, value == null ? IntPtr.Zero : value.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_edge(IntPtr raw, IntPtr id, IntPtr templates, IntPtr attributes, IntPtr fromto, IntPtr phase);

		public void PushEdge(Cdn.EmbeddedString id, GLib.SList templates, GLib.SList attributes, GLib.SList fromto, Cdn.EmbeddedString phase) {
			cdn_parser_context_push_edge(Handle, id == null ? IntPtr.Zero : id.Handle, templates == null ? IntPtr.Zero : templates.Handle, attributes == null ? IntPtr.Zero : attributes.Handle, fromto == null ? IntPtr.Zero : fromto.Handle, phase == null ? IntPtr.Zero : phase.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_pop_layout(IntPtr raw);

		public void PopLayout() {
			cdn_parser_context_pop_layout(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_selector_pseudo(IntPtr raw, int type, IntPtr arguments);

		public void PushSelectorPseudo(Cdn.SelectorPseudoType type, GLib.SList arguments) {
			cdn_parser_context_push_selector_pseudo(Handle, (int) type, arguments == null ? IntPtr.Zero : arguments.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_get_token(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_token(IntPtr raw, IntPtr token);

		public string Token { 
			get {
				IntPtr raw_ret = cdn_parser_context_get_token(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cdn_parser_context_set_token(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_pop_string(IntPtr raw);

		public Cdn.EmbeddedString PopString() {
			IntPtr raw_ret = cdn_parser_context_pop_string(Handle);
			Cdn.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cdn.EmbeddedString;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_include(IntPtr raw, IntPtr filename, bool isonce);

		public void Include(Cdn.EmbeddedString filename, bool isonce) {
			cdn_parser_context_include(Handle, filename == null ? IntPtr.Zero : filename.Handle, isonce);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_annotation(IntPtr raw, IntPtr annotation);

		public void PushAnnotation(Cdn.EmbeddedString annotation) {
			cdn_parser_context_push_annotation(Handle, annotation == null ? IntPtr.Zero : annotation.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_integrator(IntPtr raw);

		public void PushIntegrator() {
			cdn_parser_context_push_integrator(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_event(IntPtr raw, IntPtr from_phase, IntPtr to_phase, IntPtr condition, bool terminal, IntPtr approximation, IntPtr templates);

		public void PushEvent(Cdn.EmbeddedString from_phase, Cdn.EmbeddedString to_phase, Cdn.EmbeddedString condition, bool terminal, Cdn.EmbeddedString approximation, GLib.SList templates) {
			cdn_parser_context_push_event(Handle, from_phase == null ? IntPtr.Zero : from_phase.Handle, to_phase == null ? IntPtr.Zero : to_phase.Handle, condition == null ? IntPtr.Zero : condition.Handle, terminal, approximation == null ? IntPtr.Zero : approximation.Handle, templates == null ? IntPtr.Zero : templates.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_debug_context(IntPtr raw);

		public void DebugContext() {
			cdn_parser_context_debug_context(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_define(IntPtr raw);

		public void PushDefine() {
			cdn_parser_context_push_define(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_scope(IntPtr raw);

		public void PushScope() {
			cdn_parser_context_push_scope(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_node_state(IntPtr raw, IntPtr states);

		public GLib.PtrArray NodeState { 
			set {
				cdn_parser_context_set_node_state(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_get_last_selector_item_column(IntPtr raw, out int start, out int end);

		public void GetLastSelectorItemColumn(out int start, out int end) {
			cdn_parser_context_get_last_selector_item_column(Handle, out start, out end);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_pop_selector(IntPtr raw);

		public Cdn.Selector PopSelector() {
			IntPtr raw_ret = cdn_parser_context_pop_selector(Handle);
			Cdn.Selector ret = GLib.Object.GetObject(raw_ret) as Cdn.Selector;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_import(IntPtr raw, IntPtr id, IntPtr path);

		public void Import(Cdn.EmbeddedString id, Cdn.EmbeddedString path) {
			cdn_parser_context_import(Handle, id == null ? IntPtr.Zero : id.Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_templates(IntPtr raw);

		public void PushTemplates() {
			cdn_parser_context_push_templates(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_add_variable(IntPtr raw, IntPtr nameptr, IntPtr expressionptr, int add_flags, int remove_flags, bool assign_optional, IntPtr constraint, IntPtr state);

		public void AddVariable(GLib.PtrArray nameptr, GLib.PtrArray expressionptr, Cdn.VariableFlags add_flags, Cdn.VariableFlags remove_flags, bool assign_optional, Cdn.EmbeddedString constraint, Cdn.EmbeddedString state) {
			cdn_parser_context_add_variable(Handle, nameptr == null ? IntPtr.Zero : nameptr.Handle, expressionptr == null ? IntPtr.Zero : expressionptr.Handle, (int) add_flags, (int) remove_flags, assign_optional, constraint == null ? IntPtr.Zero : constraint.Handle, state == null ? IntPtr.Zero : state.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_variable(IntPtr raw, IntPtr selectorptr, IntPtr expressionptr, int add_flags, int remove_flags);

		public void SetVariable(GLib.PtrArray selectorptr, GLib.PtrArray expressionptr, Cdn.VariableFlags add_flags, Cdn.VariableFlags remove_flags) {
			cdn_parser_context_set_variable(Handle, selectorptr == null ? IntPtr.Zero : selectorptr.Handle, expressionptr == null ? IntPtr.Zero : expressionptr.Handle, (int) add_flags, (int) remove_flags);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_get_error_lines(IntPtr raw);

		public string ErrorLines { 
			get {
				IntPtr raw_ret = cdn_parser_context_get_error_lines(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_parser_context_steal_start_token(IntPtr raw);

		public int StealStartToken() {
			int raw_ret = cdn_parser_context_steal_start_token(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_equation(IntPtr raw);

		public void PushEquation() {
			cdn_parser_context_push_equation(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_parser_context_get_start_token(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_start_token(IntPtr raw, int token);

		public int StartToken { 
			get {
				int raw_ret = cdn_parser_context_get_start_token(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				cdn_parser_context_set_start_token(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_debug_selector(IntPtr raw, IntPtr selector);

		public void DebugSelector(Cdn.Selector selector) {
			cdn_parser_context_debug_selector(Handle, selector == null ? IntPtr.Zero : selector.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_get_line(IntPtr raw, out int lineno);

		public string GetLine(out int lineno) {
			IntPtr raw_ret = cdn_parser_context_get_line(Handle, out lineno);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_begin_selector_item(IntPtr raw);

		public void BeginSelectorItem() {
			cdn_parser_context_begin_selector_item(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_push_selector(IntPtr raw, bool with);

		public void PushSelector(bool with) {
			cdn_parser_context_push_selector(Handle, with);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_parser_context_peek_selector(IntPtr raw);

		public Cdn.Selector PeekSelector() {
			IntPtr raw_ret = cdn_parser_context_peek_selector(Handle);
			Cdn.Selector ret = GLib.Object.GetObject(raw_ret) as Cdn.Selector;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_debug_string(IntPtr raw, IntPtr s);

		public void DebugString(Cdn.EmbeddedString s) {
			cdn_parser_context_debug_string(Handle, s == null ? IntPtr.Zero : s.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_parser_context_set_integrator(IntPtr raw, IntPtr value);

		public Cdn.EmbeddedString Integrator { 
			set {
				cdn_parser_context_set_integrator(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

#endregion
	}
}
