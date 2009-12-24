// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Integrator : Cpg.Object {

		[Obsolete]
		protected Integrator(GLib.GType gtype) : base(gtype) {}
		public Integrator(IntPtr raw) : base(raw) {}

		protected Integrator() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("cpg-network-1.0")]
		static extern double cpg_integrator_get_time(IntPtr raw);

		[GLib.Property ("time")]
		public double Time {
			get  {
				double raw_ret = cpg_integrator_get_time(Handle);
				double ret = raw_ret;
				return ret;
			}
		}

		[GLib.Property ("network")]
		public Cpg.Network Network {
			get {
				GLib.Value val = GetProperty ("network");
				Cpg.Network ret = (Cpg.Network) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("network", val);
				val.Dispose ();
			}
		}

		[GLib.CDeclCallback]
		delegate void SteppedVMDelegate (IntPtr inst);

		static SteppedVMDelegate SteppedVMCallback;

		static void stepped_cb (IntPtr inst)
		{
			try {
				Integrator inst_managed = GLib.Object.GetObject (inst, false) as Integrator;
				inst_managed.OnStepped ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideStepped (GLib.GType gtype)
		{
			if (SteppedVMCallback == null)
				SteppedVMCallback = new SteppedVMDelegate (stepped_cb);
			OverrideVirtualMethod (gtype, "step", SteppedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Integrator), ConnectionMethod="OverrideStepped")]
		protected virtual void OnStepped ()
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

		[GLib.Signal("step")]
		public event System.EventHandler Stepped {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "step");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "step");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void EndVMDelegate (IntPtr inst);

		static EndVMDelegate EndVMCallback;

		static void end_cb (IntPtr inst)
		{
			try {
				Integrator inst_managed = GLib.Object.GetObject (inst, false) as Integrator;
				inst_managed.OnEnd ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideEnd (GLib.GType gtype)
		{
			if (EndVMCallback == null)
				EndVMCallback = new EndVMDelegate (end_cb);
			OverrideVirtualMethod (gtype, "end", EndVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Integrator), ConnectionMethod="OverrideEnd")]
		protected virtual void OnEnd ()
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

		[GLib.Signal("end")]
		public event System.EventHandler End {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "end");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "end");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void BeginVMDelegate (IntPtr inst);

		static BeginVMDelegate BeginVMCallback;

		static void begin_cb (IntPtr inst)
		{
			try {
				Integrator inst_managed = GLib.Object.GetObject (inst, false) as Integrator;
				inst_managed.OnBegin ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideBegin (GLib.GType gtype)
		{
			if (BeginVMCallback == null)
				BeginVMCallback = new BeginVMDelegate (begin_cb);
			OverrideVirtualMethod (gtype, "begin", BeginVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Integrator), ConnectionMethod="OverrideBegin")]
		protected virtual void OnBegin ()
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

		[GLib.Signal("begin")]
		public event System.EventHandler Begin {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "begin");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "begin");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_integrator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_integrator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_integrator_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = cpg_integrator_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_integrator_reset(IntPtr raw);

		public new void Reset() {
			cpg_integrator_reset(Handle);
		}

#endregion
#region Customized extensions
#line 1 "Integrator.custom"
		[DllImport("cpg-network-1.0")]
		static extern void cpg_integrator_evaluate(IntPtr raw, IntPtr state, double t, double timestep);

		public void Evaluate(Cpg.IntegratorState[] state, double t, double timestep)
		{
			GLib.SList slist = state == null ? null : new GLib.SList(state, typeof(Cpg.IntegratorState), true, false);
			cpg_integrator_evaluate(Handle, slist == null ? IntPtr.Zero : slist.Handle, t, timestep);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_integrator_run(IntPtr raw, IntPtr state, double from, double timestep, double to);

		public void Run(Cpg.IntegratorState[] state, double from, double timestep, double to)
		{
			GLib.SList slist = state == null ? null : new GLib.SList(state, typeof(Cpg.IntegratorState), true, false);
			cpg_integrator_run(Handle, slist == null ? IntPtr.Zero : slist.Handle, from, timestep, to);
		}

		[DllImport("cpg-network-1.0")]
		static extern double cpg_integrator_step(IntPtr raw, IntPtr state, double t, double timestep);

		public double Step(Cpg.IntegratorState[] state, double t, double timestep)
		{
			GLib.SList slist = state == null ? null : new GLib.SList(state, typeof(Cpg.IntegratorState), true, false);
			double raw_ret = cpg_integrator_step(Handle, slist == null ? IntPtr.Zero : slist.Handle, t, timestep);
			double ret = raw_ret;
			return ret;
		}

#endregion
	}
}
