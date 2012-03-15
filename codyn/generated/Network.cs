// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Network : Cdn.Node {

		[Obsolete]
		protected Network(GLib.GType gtype) : base(gtype) {}
		public Network(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_network_new();

		public Network () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Network)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = cdn_network_new();
		}

		[DllImport("codyn-3.0")]
		static extern unsafe IntPtr cdn_network_new_from_path(IntPtr path, out IntPtr error);

		public unsafe Network (string path) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Network)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			Raw = cdn_network_new_from_path(native_path, out error);
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("codyn-3.0")]
		static extern unsafe IntPtr cdn_network_new_from_string(IntPtr s, out IntPtr error);

		public static unsafe Network NewFromString(string s)
		{
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			IntPtr error = IntPtr.Zero;
			Network result = new Network (cdn_network_new_from_string(native_s, out error));
			GLib.Marshaller.Free (native_s);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return result;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_network_get_integrator(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_network_set_integrator(IntPtr raw, IntPtr integrator);

		[GLib.Property ("integrator")]
		public Cdn.Integrator Integrator {
			get  {
				IntPtr raw_ret = cdn_network_get_integrator(Handle);
				Cdn.Integrator ret = GLib.Object.GetObject(raw_ret) as Cdn.Integrator;
				return ret;
			}
			set  {
				cdn_network_set_integrator(Handle, value == null ? IntPtr.Zero : value.Handle);
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
				network_managed.OnCompileError (GLib.Object.GetObject(error) as Cdn.CompileError);
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

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Network), ConnectionMethod="OverrideCompileError")]
		protected virtual void OnCompileError (Cdn.CompileError error)
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
		public event Cdn.CompileErrorHandler CompileError {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "compile-error", typeof (Cdn.CompileErrorArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "compile-error", typeof (Cdn.CompileErrorArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_network_end(IntPtr raw, out IntPtr error);

		public unsafe bool End() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_network_end(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_network_load_from_string(IntPtr raw, IntPtr s, out IntPtr error);

		public unsafe bool LoadFromString(string s) {
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_network_load_from_string(Handle, native_s, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_s);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_network_begin(IntPtr raw, double start, out IntPtr error);

		public unsafe bool Begin(double start) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_network_begin(Handle, start, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_network_get_path(IntPtr raw);

		public string Path { 
			get {
				IntPtr raw_ret = cdn_network_get_path(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_network_load_error_quark();

		public static int LoadErrorQuark() {
			int raw_ret = cdn_network_load_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_network_run(IntPtr raw, double from, double timestep, double to, out IntPtr error);

		public unsafe bool Run(double from, double timestep, double to) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_network_run(Handle, from, timestep, to, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern unsafe void cdn_network_merge_from_path(IntPtr raw, IntPtr path, out IntPtr error);

		public unsafe void MergeFromPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			cdn_network_merge_from_path(Handle, native_path, out error);
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("codyn-3.0")]
		static extern unsafe void cdn_network_merge_from_string(IntPtr raw, IntPtr s, out IntPtr error);

		public unsafe void MergeFromString(string s) {
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			IntPtr error = IntPtr.Zero;
			cdn_network_merge_from_string(Handle, native_s, out error);
			GLib.Marshaller.Free (native_s);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_network_link_library(IntPtr raw, IntPtr path, out IntPtr error);

		public unsafe bool LinkLibrary(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_network_link_library(Handle, native_path, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_network_merge(IntPtr raw, IntPtr other);

		public void Merge(Cdn.Network other) {
			cdn_network_merge(Handle, other == null ? IntPtr.Zero : other.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_network_get_template_node(IntPtr raw);

		public Cdn.Node TemplateNode { 
			get {
				IntPtr raw_ret = cdn_network_get_template_node(Handle);
				Cdn.Node ret = GLib.Object.GetObject(raw_ret) as Cdn.Node;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_network_error_quark();

		public static new int ErrorQuark() {
			int raw_ret = cdn_network_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_network_load_from_path(IntPtr raw, IntPtr path, out IntPtr error);

		public unsafe bool LoadFromPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_network_load_from_path(Handle, native_path, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_network_get_import_from_path(IntPtr raw, IntPtr path);

		public Cdn.Import GetImportFromPath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = cdn_network_get_import_from_path(Handle, native_path);
			Cdn.Import ret = GLib.Object.GetObject(raw_ret) as Cdn.Import;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_network_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_network_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern double cdn_network_step(IntPtr raw, double timestep);

		public double Step(double timestep) {
			double raw_ret = cdn_network_step(Handle, timestep);
			double ret = raw_ret;
			return ret;
		}

#endregion
	}
}
