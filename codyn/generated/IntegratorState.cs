// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class IntegratorState : GLib.Object {

		[Obsolete]
		protected IntegratorState(GLib.GType gtype) : base(gtype) {}
		public IntegratorState(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_new(IntPtr objekt);

		public IntegratorState (Cdn.Object objekt) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (IntegratorState)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				if (objekt != null) {
					names.Add ("objekt");
					vals.Add (new GLib.Value (objekt));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = cdn_integrator_state_new(objekt == null ? IntPtr.Zero : objekt.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_get_phase(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_integrator_state_set_phase(IntPtr raw, IntPtr phase);

		[GLib.Property ("phase")]
		public string Phase {
			get  {
				IntPtr raw_ret = cdn_integrator_state_get_phase(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cdn_integrator_state_set_phase(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_get_object(IntPtr raw);

		[GLib.Property ("object")]
		public Cdn.Object Object {
			get  {
				IntPtr raw_ret = cdn_integrator_state_get_object(Handle);
				Cdn.Object ret = GLib.Object.GetObject(raw_ret) as Cdn.Object;
				return ret;
			}
		}

		[GLib.CDeclCallback]
		delegate void UpdatedVMDelegate (IntPtr inst);

		static UpdatedVMDelegate UpdatedVMCallback;

		static void updated_cb (IntPtr inst)
		{
			try {
				IntegratorState inst_managed = GLib.Object.GetObject (inst, false) as IntegratorState;
				inst_managed.OnUpdated ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideUpdated (GLib.GType gtype)
		{
			if (UpdatedVMCallback == null)
				UpdatedVMCallback = new UpdatedVMDelegate (updated_cb);
			OverrideVirtualMethod (gtype, "updated", UpdatedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.IntegratorState), ConnectionMethod="OverrideUpdated")]
		protected virtual void OnUpdated ()
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

		[GLib.Signal("updated")]
		public event System.EventHandler Updated {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "updated");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "updated");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_inputs(IntPtr raw);

		public Cdn.Input[] Inputs() {
			IntPtr raw_ret = cdn_integrator_state_inputs(Handle);
			Cdn.Input[] ret = (Cdn.Input[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Input));
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_operators(IntPtr raw);

		public GLib.SList Operators() {
			IntPtr raw_ret = cdn_integrator_state_operators(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_all_properties(IntPtr raw);

		public Cdn.Variable[] AllProperties() {
			IntPtr raw_ret = cdn_integrator_state_all_properties(Handle);
			Cdn.Variable[] ret = (Cdn.Variable[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Variable));
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_rand_expressions(IntPtr raw);

		public GLib.SList RandExpressions() {
			IntPtr raw_ret = cdn_integrator_state_rand_expressions(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_phase_integrated_edge_actions(IntPtr raw);

		public GLib.SList PhaseIntegratedEdgeActions() {
			IntPtr raw_ret = cdn_integrator_state_phase_integrated_edge_actions(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_functions(IntPtr raw);

		public GLib.SList Functions() {
			IntPtr raw_ret = cdn_integrator_state_functions(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_rand_instructions(IntPtr raw);

		public GLib.SList RandInstructions() {
			IntPtr raw_ret = cdn_integrator_state_rand_instructions(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_phase_events(IntPtr raw);

		public GLib.SList PhaseEvents() {
			IntPtr raw_ret = cdn_integrator_state_phase_events(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_direct_edge_actions(IntPtr raw);

		public Cdn.EdgeAction[] DirectEdgeActions() {
			IntPtr raw_ret = cdn_integrator_state_direct_edge_actions(Handle);
			Cdn.EdgeAction[] ret = (Cdn.EdgeAction[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.EdgeAction));
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_expressions(IntPtr raw);

		public GLib.SList Expressions() {
			IntPtr raw_ret = cdn_integrator_state_expressions(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_integrated_properties(IntPtr raw);

		public Cdn.Variable[] IntegratedProperties() {
			IntPtr raw_ret = cdn_integrator_state_integrated_properties(Handle);
			Cdn.Variable[] ret = (Cdn.Variable[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Variable));
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_events(IntPtr raw);

		public GLib.SList Events() {
			IntPtr raw_ret = cdn_integrator_state_events(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_integrator_state_update(IntPtr raw);

		public void Update() {
			cdn_integrator_state_update(Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_phase_direct_edge_actions(IntPtr raw);

		public GLib.SList PhaseDirectEdgeActions() {
			IntPtr raw_ret = cdn_integrator_state_phase_direct_edge_actions(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_direct_properties(IntPtr raw);

		public Cdn.Variable[] DirectProperties() {
			IntPtr raw_ret = cdn_integrator_state_direct_properties(Handle);
			Cdn.Variable[] ret = (Cdn.Variable[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Variable));
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_integrator_state_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_integrator_state_integrated_edge_actions(IntPtr raw);

		public Cdn.EdgeAction[] IntegratedEdgeActions() {
			IntPtr raw_ret = cdn_integrator_state_integrated_edge_actions(Handle);
			Cdn.EdgeAction[] ret = (Cdn.EdgeAction[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.EdgeAction));
			return ret;
		}

#endregion
	}
}