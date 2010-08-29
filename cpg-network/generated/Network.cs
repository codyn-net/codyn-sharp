// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Network : Cpg.Group {

		[Obsolete]
		protected Network(GLib.GType gtype) : base(gtype) {}
		public Network(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_network_new();

		public Network () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Network)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cpg_network_new();
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe IntPtr cpg_network_new_from_path(IntPtr path, out IntPtr error);

		public unsafe Network (string path) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Network)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			Raw = cpg_network_new_from_path(native_path, out error);
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("cpg-network-2.0")]
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

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_network_get_integrator(IntPtr raw);

		[DllImport("cpg-network-2.0")]
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

		[GLib.Property ("filename")]
		public string Filename {
			get {
				GLib.Value val = GetProperty ("filename");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.CDeclCallback]
		delegate void CompileErrorVMDelegate (IntPtr network, IntPtr error);

		static CompileErrorVMDelegate CompileErrorVMCallback;

		static void compileerror_cb (IntPtr network, IntPtr error)
		{
			try {
				Network network_managed = GLib.Object.GetObject (network, false) as Network;
				network_managed.OnCompileError (GLib.Object.GetObject(error) as Cpg.CompileError);
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

		[DllImport("cpg-network-2.0")]
		static extern int cpg_network_load_error_quark();

		public static int LoadErrorQuark() {
			int raw_ret = cpg_network_load_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_network_get_template_group(IntPtr raw);

		public Cpg.Group TemplateGroup { 
			get {
				IntPtr raw_ret = cpg_network_get_template_group(Handle);
				Cpg.Group ret = GLib.Object.GetObject(raw_ret) as Cpg.Group;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_network_merge(IntPtr raw, IntPtr other);

		public void Merge(Cpg.Network other) {
			cpg_network_merge(Handle, other == null ? IntPtr.Zero : other.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe void cpg_network_merge_from_path(IntPtr raw, IntPtr path, out IntPtr error);

		public unsafe void MergeFromPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			cpg_network_merge_from_path(Handle, native_path, out error);
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_network_get_function_group(IntPtr raw);

		public Cpg.Group FunctionGroup { 
			get {
				IntPtr raw_ret = cpg_network_get_function_group(Handle);
				Cpg.Group ret = GLib.Object.GetObject(raw_ret) as Cpg.Group;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern int cpg_network_error_quark();

		public static new int ErrorQuark() {
			int raw_ret = cpg_network_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_network_load_from_path(IntPtr raw, IntPtr path, out IntPtr error);

		public unsafe bool LoadFromPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_network_load_from_path(Handle, native_path, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_network_run(IntPtr raw, double from, double timestep, double to);

		public void Run(double from, double timestep, double to) {
			cpg_network_run(Handle, from, timestep, to);
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_network_load_from_xml(IntPtr raw, IntPtr xml, out IntPtr error);

		public unsafe bool LoadFromXml(string xml) {
			IntPtr native_xml = GLib.Marshaller.StringToPtrGStrdup (xml);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_network_load_from_xml(Handle, native_xml, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_xml);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_network_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_network_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe void cpg_network_merge_from_xml(IntPtr raw, IntPtr xml, out IntPtr error);

		public unsafe void MergeFromXml(string xml) {
			IntPtr native_xml = GLib.Marshaller.StringToPtrGStrdup (xml);
			IntPtr error = IntPtr.Zero;
			cpg_network_merge_from_xml(Handle, native_xml, out error);
			GLib.Marshaller.Free (native_xml);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_network_step(IntPtr raw, double timestep);

		public void Step(double timestep) {
			cpg_network_step(Handle, timestep);
		}

#endregion
	}
}
