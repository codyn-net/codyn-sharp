// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Network : GLib.Object {

		[Obsolete]
		protected Network(GLib.GType gtype) : base(gtype) {}
		public Network(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_new();

		public Network () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Network)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cpg_network_new();
		}

		[DllImport("cpg-network-1.0")]
		static extern unsafe IntPtr cpg_network_new_from_file(IntPtr filename, out IntPtr error);

		public unsafe Network (string filename) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Network)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			IntPtr error = IntPtr.Zero;
			Raw = cpg_network_new_from_file(native_filename, out error);
			GLib.Marshaller.Free (native_filename);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("cpg-network-1.0")]
		static extern unsafe IntPtr cpg_network_new_from_xml(IntPtr xml, out IntPtr error);

		public static unsafe Network NewFromXml(string xml)
		{
			IntPtr native_xml = GLib.Marshaller.StringToPtrGStrdup (xml);
			IntPtr error = IntPtr.Zero;
			Network result = new Network (cpg_network_new_from_xml(native_xml, out error));
			GLib.Marshaller.Free (native_xml);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return result;
		}

		[DllImport("cpg-network-1.0")]
		static extern bool cpg_network_get_compiled(IntPtr raw);

		[GLib.Property ("compiled")]
		public bool Compiled {
			get  {
				bool raw_ret = cpg_network_get_compiled(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("compiled", val);
				val.Dispose ();
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_integrator(IntPtr raw);

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_set_integrator(IntPtr raw, IntPtr integrator);

		[GLib.Property ("integrator")]
		public Cpg.Integrator Integrator {
			get  {
				IntPtr raw_ret = cpg_network_get_integrator(Handle);
				Cpg.Integrator ret = GLib.Object.GetObject(raw_ret) as Cpg.Integrator;
				return ret;
			}
			set  {
				cpg_network_set_integrator(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.CDeclCallback]
		delegate void CompileErrorVMDelegate (IntPtr network, IntPtr error);

		static CompileErrorVMDelegate CompileErrorVMCallback;

		static void compileerror_cb (IntPtr network, IntPtr error)
		{
			try {
				Network network_managed = GLib.Object.GetObject (network, false) as Network;
				network_managed.OnCompileError (error == IntPtr.Zero ? null : (Cpg.CompileError) GLib.Opaque.GetOpaque (error, typeof (Cpg.CompileError), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideCompileError (GLib.GType gtype)
		{
			if (CompileErrorVMCallback == null)
				CompileErrorVMCallback = new CompileErrorVMDelegate (compileerror_cb);
			OverrideVirtualMethod (gtype, "compile-error", CompileErrorVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Network), ConnectionMethod="OverrideCompileError")]
		protected virtual void OnCompileError (Cpg.CompileError error)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (error);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("compile-error")]
		public event Cpg.CompileErrorHandler CompileError {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "compile-error", typeof (Cpg.CompileErrorArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "compile-error", typeof (Cpg.CompileErrorArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ResettedVMDelegate (IntPtr network);

		static ResettedVMDelegate ResettedVMCallback;

		static void resetted_cb (IntPtr network)
		{
			try {
				Network network_managed = GLib.Object.GetObject (network, false) as Network;
				network_managed.OnResetted ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideResetted (GLib.GType gtype)
		{
			if (ResettedVMCallback == null)
				ResettedVMCallback = new ResettedVMDelegate (resetted_cb);
			OverrideVirtualMethod (gtype, "reset", ResettedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Network), ConnectionMethod="OverrideResetted")]
		protected virtual void OnResetted ()
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

		[GLib.Signal("reset")]
		public event System.EventHandler Resetted {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "reset");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "reset");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern unsafe bool cpg_network_merge_from_partial_xml(IntPtr raw, IntPtr xml, out IntPtr error);

		public unsafe bool MergeFromPartialXml(string xml) {
			IntPtr native_xml = GLib.Marshaller.StringToPtrGStrdup (xml);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_network_merge_from_partial_xml(Handle, native_xml, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_xml);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_write_to_xml(IntPtr raw);

		public string WriteToXml() {
			IntPtr raw_ret = cpg_network_write_to_xml(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_network_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_function(IntPtr raw, IntPtr name);

		public Cpg.Function GetFunction(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_network_get_function(Handle, native_name);
			Cpg.Function ret = GLib.Object.GetObject(raw_ret) as Cpg.Function;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_object(IntPtr raw, IntPtr id);

		public Cpg.Object GetObject(string id) {
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			IntPtr raw_ret = cpg_network_get_object(Handle, native_id);
			Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
			GLib.Marshaller.Free (native_id);
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_remove_function(IntPtr raw, IntPtr function);

		public void RemoveFunction(Cpg.Function function) {
			cpg_network_remove_function(Handle, function == null ? IntPtr.Zero : function.Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_add_link_from_template(IntPtr raw, IntPtr name, IntPtr from, IntPtr to);

		public Cpg.Object AddLinkFromTemplate(string name, Cpg.Object from, Cpg.Object to) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_network_add_link_from_template(Handle, native_name, from == null ? IntPtr.Zero : from.Handle, to == null ? IntPtr.Zero : to.Handle);
			Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_write_to_file(IntPtr raw, IntPtr filename);

		public void WriteToFile(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			cpg_network_write_to_file(Handle, native_filename);
			GLib.Marshaller.Free (native_filename);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_set_global_constant(IntPtr raw, IntPtr name, double constant);

		public void SetGlobalConstant(string name, double constant) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			cpg_network_set_global_constant(Handle, native_name, constant);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_remove_object(IntPtr raw, IntPtr objekt);

		public void RemoveObject(Cpg.Object objekt) {
			cpg_network_remove_object(Handle, objekt == null ? IntPtr.Zero : objekt.Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_states(IntPtr raw);

		public Cpg.Object[] States { 
			get {
				IntPtr raw_ret = cpg_network_get_states(Handle);
				Cpg.Object[] ret = (Cpg.Object[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Object));
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_run(IntPtr raw, double from, double timestep, double to);

		public void Run(double from, double timestep, double to) {
			cpg_network_run(Handle, from, timestep, to);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_step(IntPtr raw, double timestep);

		public void Step(double timestep) {
			cpg_network_step(Handle, timestep);
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_globals(IntPtr raw);

		public Cpg.Object Globals { 
			get {
				IntPtr raw_ret = cpg_network_get_globals(Handle);
				Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_merge(IntPtr raw, IntPtr other);

		public void Merge(Cpg.Network other) {
			cpg_network_merge(Handle, other == null ? IntPtr.Zero : other.Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_add_function(IntPtr raw, IntPtr function);

		public void AddFunction(Cpg.Function function) {
			cpg_network_add_function(Handle, function == null ? IntPtr.Zero : function.Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern int cpg_network_load_error_quark();

		public static int LoadErrorQuark() {
			int raw_ret = cpg_network_load_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_template(IntPtr raw, IntPtr name);

		public Cpg.Object GetTemplate(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_network_get_template(Handle, native_name);
			Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern unsafe void cpg_network_merge_from_file(IntPtr raw, IntPtr filename, out IntPtr error);

		public unsafe void MergeFromFile(string filename) {
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			IntPtr error = IntPtr.Zero;
			cpg_network_merge_from_file(Handle, native_filename, out error);
			GLib.Marshaller.Free (native_filename);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_remove_template(IntPtr raw, IntPtr name);

		public void RemoveTemplate(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			cpg_network_remove_template(Handle, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("cpg-network-1.0")]
		static extern unsafe void cpg_network_merge_from_xml(IntPtr raw, IntPtr xml, out IntPtr error);

		public unsafe void MergeFromXml(string xml) {
			IntPtr native_xml = GLib.Marshaller.StringToPtrGStrdup (xml);
			IntPtr error = IntPtr.Zero;
			cpg_network_merge_from_xml(Handle, native_xml, out error);
			GLib.Marshaller.Free (native_xml);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_add_object(IntPtr raw, IntPtr objekt);

		public void AddObject(Cpg.Object objekt) {
			cpg_network_add_object(Handle, objekt == null ? IntPtr.Zero : objekt.Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_taint(IntPtr raw);

		public void Taint() {
			cpg_network_taint(Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_links(IntPtr raw);

		public Cpg.Link[] Links { 
			get {
				IntPtr raw_ret = cpg_network_get_links(Handle);
				Cpg.Link[] ret = (Cpg.Link[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Link));
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_integration_state(IntPtr raw);

		public GLib.SList IntegrationState { 
			get {
				IntPtr raw_ret = cpg_network_get_integration_state(Handle);
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_clear(IntPtr raw);

		public void Clear() {
			cpg_network_clear(Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_add_template(IntPtr raw, IntPtr name, IntPtr objekt);

		public void AddTemplate(string name, Cpg.Object objekt) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			cpg_network_add_template(Handle, native_name, objekt == null ? IntPtr.Zero : objekt.Handle);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_functions(IntPtr raw);

		public Cpg.Function[] Functions { 
			get {
				IntPtr raw_ret = cpg_network_get_functions(Handle);
				Cpg.Function[] ret = (Cpg.Function[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Function));
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_add_from_template(IntPtr raw, IntPtr name);

		public Cpg.Object AddFromTemplate(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_network_add_from_template(Handle, native_name);
			Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_network_get_templates(IntPtr raw);

		public string[] Templates { 
			get {
				IntPtr raw_ret = cpg_network_get_templates(Handle);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), true, false, typeof(string));
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_network_reset(IntPtr raw);

		public void Reset() {
			cpg_network_reset(Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern bool cpg_network_compile(IntPtr raw, IntPtr error);

		public bool Compile(Cpg.CompileError error) {
			bool raw_ret = cpg_network_compile(Handle, error == null ? IntPtr.Zero : error.Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
