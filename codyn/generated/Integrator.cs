// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Integrator : Cdn.Object {

		[Obsolete]
		protected Integrator(GLib.GType gtype) : base(gtype) {}
		public Integrator(IntPtr raw) : base(raw) {}

		protected Integrator() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("minimum-timestep")]
		public double MinimumTimestep {
			get {
				GLib.Value val = GetProperty ("minimum-timestep");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("minimum-timestep", val);
				val.Dispose ();
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern double cdn_integrator_get_real_time(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_integrator_set_real_time(IntPtr raw, double real_time);

		[GLib.Property ("real-time")]
		public double RealTime {
			get  {
				double raw_ret = cdn_integrator_get_real_time(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				cdn_integrator_set_real_time(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrator_get_state(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_integrator_set_state(IntPtr raw, IntPtr state);

		[GLib.Property ("state")]
		public Cdn.IntegratorState State {
			get  {
				IntPtr raw_ret = cdn_integrator_get_state(Handle);
				Cdn.IntegratorState ret = GLib.Object.GetObject(raw_ret) as Cdn.IntegratorState;
				return ret;
			}
			set  {
				cdn_integrator_set_state(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern double cdn_integrator_get_time(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_integrator_set_time(IntPtr raw, double t);

		[GLib.Property ("time")]
		public double Time {
			get  {
				double raw_ret = cdn_integrator_get_time(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				cdn_integrator_set_time(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern double cdn_integrator_get_default_timestep(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_integrator_set_default_timestep(IntPtr raw, double timestep);

		[GLib.Property ("default-timestep")]
		public double DefaultTimestep {
			get  {
				double raw_ret = cdn_integrator_get_default_timestep(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				cdn_integrator_set_default_timestep(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrator_get_object(IntPtr raw);

		[GLib.Property ("object")]
		public Cdn.Object Object {
			get  {
				IntPtr raw_ret = cdn_integrator_get_object(Handle);
				Cdn.Object ret = GLib.Object.GetObject(raw_ret) as Cdn.Object;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("object", val);
				val.Dispose ();
			}
		}

		[GLib.CDeclCallback]
		delegate void SteppedVMDelegate (IntPtr inst, double timestep, double time);

		static SteppedVMDelegate SteppedVMCallback;

		static void stepped_cb (IntPtr inst, double timestep, double time)
		{
			try {
				Integrator inst_managed = GLib.Object.GetObject (inst, false) as Integrator;
				inst_managed.OnStepped (timestep, time);
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

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Integrator), ConnectionMethod="OverrideStepped")]
		protected virtual void OnStepped (double timestep, double time)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (timestep);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (time);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("step")]
		public event Cdn.SteppedHandler Stepped {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "step", typeof (Cdn.SteppedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "step", typeof (Cdn.SteppedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void EndedVMDelegate (IntPtr inst);

		static EndedVMDelegate EndedVMCallback;

		static void ended_cb (IntPtr inst)
		{
			try {
				Integrator inst_managed = GLib.Object.GetObject (inst, false) as Integrator;
				inst_managed.OnEnded ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideEnded (GLib.GType gtype)
		{
			if (EndedVMCallback == null)
				EndedVMCallback = new EndedVMDelegate (ended_cb);
			OverrideVirtualMethod (gtype, "end", EndedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Integrator), ConnectionMethod="OverrideEnded")]
		protected virtual void OnEnded ()
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
		public event System.EventHandler Ended {
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
		delegate void BegunVMDelegate (IntPtr inst, double from);

		static BegunVMDelegate BegunVMCallback;

		static void begun_cb (IntPtr inst, double from)
		{
			try {
				Integrator inst_managed = GLib.Object.GetObject (inst, false) as Integrator;
				inst_managed.OnBegun (from);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideBegun (GLib.GType gtype)
		{
			if (BegunVMCallback == null)
				BegunVMCallback = new BegunVMDelegate (begun_cb);
			OverrideVirtualMethod (gtype, "begin", BegunVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Integrator), ConnectionMethod="OverrideBegun")]
		protected virtual void OnBegun (double from)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (from);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("begin")]
		public event Cdn.BegunHandler Begun {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "begin", typeof (Cdn.BegunArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "begin", typeof (Cdn.BegunArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe bool cdn_integrator_end(IntPtr raw, out IntPtr error);

		public unsafe bool End() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_integrator_end(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrator_get_class_id(IntPtr raw);

		public string ClassId { 
			get {
				IntPtr raw_ret = cdn_integrator_get_class_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrator_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = cdn_integrator_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_integrator_get_terminate(IntPtr raw);

		public bool Terminate { 
			get {
				bool raw_ret = cdn_integrator_get_terminate(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_integrator_simulation_step_integrate(IntPtr raw, IntPtr actions);

		public void SimulationStepIntegrate(GLib.SList actions) {
			cdn_integrator_simulation_step_integrate(Handle, actions == null ? IntPtr.Zero : actions.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe bool cdn_integrator_begin(IntPtr raw, double start, out IntPtr error);

		public unsafe bool Begin(double start) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_integrator_begin(Handle, start, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_integrator_step_prepare(IntPtr raw, double t, double timestep);

		public bool StepPrepare(double t, double timestep) {
			bool raw_ret = cdn_integrator_step_prepare(Handle, t, timestep);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_integrator_reset(IntPtr raw);

		public new void Reset() {
			cdn_integrator_reset(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_integrator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_integrator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
