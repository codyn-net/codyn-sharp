// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class ParserContext : GLib.Object {

		[Obsolete]
		protected ParserContext(GLib.GType gtype) : base(gtype) {}
		public ParserContext(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_new(IntPtr network);

		public ParserContext (Cpg.Network network) : base (IntPtr.Zero)
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
			Raw = cpg_parser_context_new(network == null ? IntPtr.Zero : network.Handle);
		}

		[GLib.Property ("network")]
		public Cpg.Network Network {
			get {
				GLib.Value val = GetProperty ("network");
				Cpg.Network ret = (Cpg.Network) val;
				val.Dispose ();
				return ret;
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

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.ParserContext), ConnectionMethod="OverrideContextPushed")]
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

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.ParserContext), ConnectionMethod="OverrideContextPopped")]
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

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_set_column(IntPtr raw, int start, int end);

		public void SetColumn(int start, int end) {
			cpg_parser_context_set_column(Handle, start, end);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_current_selections(IntPtr raw);

		public GLib.SList CurrentSelections() {
			IntPtr raw_ret = cpg_parser_context_current_selections(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_set_line(IntPtr raw, IntPtr line, int lineno);

		public void SetLine(string line, int lineno) {
			IntPtr native_line = GLib.Marshaller.StringToPtrGStrdup (line);
			cpg_parser_context_set_line(Handle, native_line, lineno);
			GLib.Marshaller.Free (native_line);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_parser_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_equation_depth(IntPtr raw);

		public void PushEquationDepth() {
			cpg_parser_context_push_equation_depth(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_set_proxy(IntPtr raw, IntPtr objects);

		public GLib.SList Proxy { 
			set {
				cpg_parser_context_set_proxy(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_add_layout(IntPtr raw, int relation, IntPtr left, IntPtr right);

		public void AddLayout(Cpg.LayoutRelation relation, Cpg.Selector left, Cpg.Selector right) {
			cpg_parser_context_add_layout(Handle, (int) relation, left == null ? IntPtr.Zero : left.Handle, right == null ? IntPtr.Zero : right.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_input_file(IntPtr raw, IntPtr id, IntPtr path, IntPtr attributes);

		public void PushInputFile(Cpg.EmbeddedString id, Cpg.EmbeddedString path, GLib.SList attributes) {
			cpg_parser_context_push_input_file(Handle, id == null ? IntPtr.Zero : id.Handle, path == null ? IntPtr.Zero : path.Handle, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_input_from_path(IntPtr raw, IntPtr path);

		public void PushInputFromPath(Cpg.EmbeddedString path) {
			cpg_parser_context_push_input_from_path(Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_set_integrator(IntPtr raw, IntPtr value);

		public Cpg.EmbeddedString Integrator { 
			set {
				cpg_parser_context_set_integrator(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_add_layout_position(IntPtr raw, IntPtr selector, IntPtr x, IntPtr y, IntPtr of);

		public void AddLayoutPosition(Cpg.Selector selector, Cpg.EmbeddedString x, Cpg.EmbeddedString y, Cpg.Selector of) {
			cpg_parser_context_add_layout_position(Handle, selector == null ? IntPtr.Zero : selector.Handle, x == null ? IntPtr.Zero : x.Handle, y == null ? IntPtr.Zero : y.Handle, of == null ? IntPtr.Zero : of.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_get_error(IntPtr raw);

		public IntPtr Error { 
			get {
				IntPtr raw_ret = cpg_parser_context_get_error(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_get_column(IntPtr raw, out int start, out int end);

		public void GetColumn(out int start, out int end) {
			cpg_parser_context_get_column(Handle, out start, out end);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_get_embedded(IntPtr raw);

		public Cpg.EmbeddedContext Embedded { 
			get {
				IntPtr raw_ret = cpg_parser_context_get_embedded(Handle);
				Cpg.EmbeddedContext ret = GLib.Object.GetObject(raw_ret) as Cpg.EmbeddedContext;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_define(IntPtr raw, IntPtr name, IntPtr values, bool expand, bool optional);

		public void Define(Cpg.EmbeddedString name, GLib.SList values, bool expand, bool optional) {
			cpg_parser_context_define(Handle, name == null ? IntPtr.Zero : name.Handle, values == null ? IntPtr.Zero : values.Handle, expand, optional);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_previous_selections(IntPtr raw);

		public GLib.SList PreviousSelections() {
			IntPtr raw_ret = cpg_parser_context_previous_selections(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_pop(IntPtr raw);

		public GLib.SList Pop() {
			IntPtr raw_ret = cpg_parser_context_pop(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_selector_identifier(IntPtr raw, IntPtr identifier);

		public void PushSelectorIdentifier(Cpg.EmbeddedString identifier) {
			cpg_parser_context_push_selector_identifier(Handle, identifier == null ? IntPtr.Zero : identifier.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_push_string(IntPtr raw);

		public Cpg.EmbeddedString PushString() {
			IntPtr raw_ret = cpg_parser_context_push_string(Handle);
			Cpg.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cpg.EmbeddedString;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_delete_selector(IntPtr raw, IntPtr selector);

		public void DeleteSelector(Cpg.Selector selector) {
			cpg_parser_context_delete_selector(Handle, selector == null ? IntPtr.Zero : selector.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_parser_context_pop_equation_depth(IntPtr raw);

		public bool PopEquationDepth() {
			bool raw_ret = cpg_parser_context_pop_equation_depth(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_add_action(IntPtr raw, IntPtr target, IntPtr expression);

		public void AddAction(Cpg.EmbeddedString target, Cpg.EmbeddedString expression) {
			cpg_parser_context_add_action(Handle, target == null ? IntPtr.Zero : target.Handle, expression == null ? IntPtr.Zero : expression.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern int cpg_parser_context_steal_start_token(IntPtr raw);

		public int StealStartToken() {
			int raw_ret = cpg_parser_context_steal_start_token(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_add_interface(IntPtr raw, IntPtr name, IntPtr target);

		public void AddInterface(Cpg.EmbeddedString name, Cpg.Selector target) {
			cpg_parser_context_add_interface(Handle, name == null ? IntPtr.Zero : name.Handle, target == null ? IntPtr.Zero : target.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_group(IntPtr raw, IntPtr id, IntPtr templates, IntPtr attributes);

		public void PushGroup(Cpg.EmbeddedString id, IntPtr templates, GLib.SList attributes) {
			cpg_parser_context_push_group(Handle, id == null ? IntPtr.Zero : id.Handle, templates, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_define(IntPtr raw, IntPtr attributes);

		public void PushDefine(GLib.SList attributes) {
			cpg_parser_context_push_define(Handle, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_remove(IntPtr raw, IntPtr selectors);

		public void Remove(IntPtr selectors) {
			cpg_parser_context_remove(Handle, selectors);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_network(IntPtr raw, IntPtr attributes);

		public void PushNetwork(GLib.SList attributes) {
			cpg_parser_context_push_network(Handle, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_add_function(IntPtr raw, IntPtr name, IntPtr expression, IntPtr arguments);

		public Cpg.Function AddFunction(Cpg.EmbeddedString name, Cpg.EmbeddedString expression, IntPtr arguments) {
			IntPtr raw_ret = cpg_parser_context_add_function(Handle, name == null ? IntPtr.Zero : name.Handle, expression == null ? IntPtr.Zero : expression.Handle, arguments);
			Cpg.Function ret = GLib.Object.GetObject(raw_ret) as Cpg.Function;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_add_polynomial(IntPtr raw, IntPtr name, IntPtr pieces);

		public Cpg.FunctionPolynomial AddPolynomial(Cpg.EmbeddedString name, IntPtr pieces) {
			IntPtr raw_ret = cpg_parser_context_add_polynomial(Handle, name == null ? IntPtr.Zero : name.Handle, pieces);
			Cpg.FunctionPolynomial ret = GLib.Object.GetObject(raw_ret) as Cpg.FunctionPolynomial;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_peek_string(IntPtr raw);

		public Cpg.EmbeddedString PeekString() {
			IntPtr raw_ret = cpg_parser_context_peek_string(Handle);
			Cpg.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cpg.EmbeddedString;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_set_error(IntPtr raw, IntPtr message);

		public void SetError(string message) {
			IntPtr native_message = GLib.Marshaller.StringToPtrGStrdup (message);
			cpg_parser_context_set_error(Handle, native_message);
			GLib.Marshaller.Free (native_message);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_selector_regex(IntPtr raw, IntPtr regex);

		public void PushSelectorRegex(Cpg.EmbeddedString regex) {
			cpg_parser_context_push_selector_regex(Handle, regex == null ? IntPtr.Zero : regex.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_get_last_selector_item_line(IntPtr raw, out int line_start, out int line_end);

		public void GetLastSelectorItemLine(out int line_start, out int line_end) {
			cpg_parser_context_get_last_selector_item_line(Handle, out line_start, out line_end);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_pop_input(IntPtr raw);

		public void PopInput() {
			cpg_parser_context_pop_input(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_input_from_string(IntPtr raw, IntPtr s);

		public void PushInputFromString(string s) {
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			cpg_parser_context_push_input_from_string(Handle, native_s);
			GLib.Marshaller.Free (native_s);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_pop_string(IntPtr raw);

		public Cpg.EmbeddedString PopString() {
			IntPtr raw_ret = cpg_parser_context_pop_string(Handle);
			Cpg.EmbeddedString ret = GLib.Object.GetObject(raw_ret) as Cpg.EmbeddedString;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_layout(IntPtr raw, IntPtr attributes);

		public void PushLayout(GLib.SList attributes) {
			cpg_parser_context_push_layout(Handle, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_add_integrator_property(IntPtr raw, IntPtr name, IntPtr value);

		public void AddIntegratorProperty(Cpg.EmbeddedString name, Cpg.EmbeddedString value) {
			cpg_parser_context_add_integrator_property(Handle, name == null ? IntPtr.Zero : name.Handle, value == null ? IntPtr.Zero : value.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_get_scanner(IntPtr raw);

		public IntPtr Scanner { 
			get {
				IntPtr raw_ret = cpg_parser_context_get_scanner(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_parser_context_parse(IntPtr raw, out IntPtr error);

		public unsafe bool Parse() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_parser_context_parse(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_templates(IntPtr raw, IntPtr attributes);

		public void PushTemplates(GLib.SList attributes) {
			cpg_parser_context_push_templates(Handle, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_selection(IntPtr raw, IntPtr selector, int type, IntPtr attributes);

		public void PushSelection(Cpg.Selector selector, Cpg.SelectorType type, GLib.SList attributes) {
			cpg_parser_context_push_selection(Handle, selector == null ? IntPtr.Zero : selector.Handle, (int) type, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_object(IntPtr raw, IntPtr objects);

		public void PushObject(GLib.SList objects) {
			cpg_parser_context_push_object(Handle, objects == null ? IntPtr.Zero : objects.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_integrator(IntPtr raw, IntPtr attributes);

		public void PushIntegrator(GLib.SList attributes) {
			cpg_parser_context_push_integrator(Handle, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_pop_layout(IntPtr raw);

		public void PopLayout() {
			cpg_parser_context_pop_layout(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_selector_pseudo(IntPtr raw, int type, IntPtr arguments);

		public void PushSelectorPseudo(Cpg.SelectorPseudoType type, GLib.SList arguments) {
			cpg_parser_context_push_selector_pseudo(Handle, (int) type, arguments == null ? IntPtr.Zero : arguments.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_get_token(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_set_token(IntPtr raw, IntPtr token);

		public string Token { 
			get {
				IntPtr raw_ret = cpg_parser_context_get_token(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cpg_parser_context_set_token(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_annotation(IntPtr raw, IntPtr annotation);

		public void PushAnnotation(Cpg.EmbeddedString annotation) {
			cpg_parser_context_push_annotation(Handle, annotation == null ? IntPtr.Zero : annotation.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_read(IntPtr raw, IntPtr buffer, UIntPtr max_size);

		public long Read(string buffer, ulong max_size) {
			IntPtr raw_ret = cpg_parser_context_read(Handle, GLib.Marshaller.StringToPtrGStrdup(buffer), new UIntPtr (max_size));
			long ret = (long) raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_debug_context(IntPtr raw);

		public void DebugContext() {
			cpg_parser_context_debug_context(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_add_property(IntPtr raw, IntPtr name, IntPtr expression, int add_flags, int remove_flags, IntPtr integration);

		public void AddProperty(Cpg.EmbeddedString name, Cpg.EmbeddedString expression, Cpg.PropertyFlags add_flags, Cpg.PropertyFlags remove_flags, Cpg.EmbeddedString integration) {
			cpg_parser_context_add_property(Handle, name == null ? IntPtr.Zero : name.Handle, expression == null ? IntPtr.Zero : expression.Handle, (int) add_flags, (int) remove_flags, integration == null ? IntPtr.Zero : integration.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_scope(IntPtr raw, IntPtr attributes);

		public void PushScope(GLib.SList attributes) {
			cpg_parser_context_push_scope(Handle, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_state(IntPtr raw, IntPtr id, IntPtr templates, IntPtr attributes);

		public void PushState(Cpg.EmbeddedString id, IntPtr templates, GLib.SList attributes) {
			cpg_parser_context_push_state(Handle, id == null ? IntPtr.Zero : id.Handle, templates, attributes == null ? IntPtr.Zero : attributes.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_get_last_selector_item_column(IntPtr raw, out int start, out int end);

		public void GetLastSelectorItemColumn(out int start, out int end) {
			cpg_parser_context_get_last_selector_item_column(Handle, out start, out end);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_pop_selector(IntPtr raw);

		public Cpg.Selector PopSelector() {
			IntPtr raw_ret = cpg_parser_context_pop_selector(Handle);
			Cpg.Selector ret = GLib.Object.GetObject(raw_ret) as Cpg.Selector;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_import(IntPtr raw, IntPtr id, IntPtr path);

		public void Import(Cpg.EmbeddedString id, Cpg.EmbeddedString path) {
			cpg_parser_context_import(Handle, id == null ? IntPtr.Zero : id.Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_link(IntPtr raw, IntPtr id, IntPtr templates, IntPtr attributes, IntPtr fromto);

		public void PushLink(Cpg.EmbeddedString id, IntPtr templates, GLib.SList attributes, IntPtr fromto) {
			cpg_parser_context_push_link(Handle, id == null ? IntPtr.Zero : id.Handle, templates, attributes == null ? IntPtr.Zero : attributes.Handle, fromto);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_equation(IntPtr raw);

		public void PushEquation() {
			cpg_parser_context_push_equation(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern int cpg_parser_context_get_start_token(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_set_start_token(IntPtr raw, int token);

		public int StartToken { 
			get {
				int raw_ret = cpg_parser_context_get_start_token(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				cpg_parser_context_set_start_token(Handle, value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_debug_selector(IntPtr raw, IntPtr selector);

		public void DebugSelector(Cpg.Selector selector) {
			cpg_parser_context_debug_selector(Handle, selector == null ? IntPtr.Zero : selector.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_get_line(IntPtr raw, out int lineno);

		public string GetLine(out int lineno) {
			IntPtr raw_ret = cpg_parser_context_get_line(Handle, out lineno);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_begin_selector_item(IntPtr raw);

		public void BeginSelectorItem() {
			cpg_parser_context_begin_selector_item(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_push_selector(IntPtr raw);

		public void PushSelector() {
			cpg_parser_context_push_selector(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_parser_context_peek_selector(IntPtr raw);

		public Cpg.Selector PeekSelector() {
			IntPtr raw_ret = cpg_parser_context_peek_selector(Handle);
			Cpg.Selector ret = GLib.Object.GetObject(raw_ret) as Cpg.Selector;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_debug_string(IntPtr raw, IntPtr s);

		public void DebugString(Cpg.EmbeddedString s) {
			cpg_parser_context_debug_string(Handle, s == null ? IntPtr.Zero : s.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_parser_context_set_input_file_setting(IntPtr raw, IntPtr name, IntPtr value);

		public void SetInputFileSetting(Cpg.EmbeddedString name, Cpg.EmbeddedString value) {
			cpg_parser_context_set_input_file_setting(Handle, name == null ? IntPtr.Zero : name.Handle, value == null ? IntPtr.Zero : value.Handle);
		}

#endregion
	}
}