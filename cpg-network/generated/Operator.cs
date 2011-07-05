// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Operator : GLib.Object {

		[Obsolete]
		protected Operator(GLib.GType gtype) : base(gtype) {}
		public Operator(IntPtr raw) : base(raw) {}

		protected Operator() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_operator_step(IntPtr raw, IntPtr integrator, double t, double timestep);

		public void Step(Cpg.Integrator integrator, double t, double timestep) {
			cpg_operator_step(Handle, integrator == null ? IntPtr.Zero : integrator.Handle, t, timestep);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_operator_reset(IntPtr raw);

		public void Reset() {
			cpg_operator_reset(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_operator_reset_variadic(IntPtr raw);

		public void ResetVariadic() {
			cpg_operator_reset_variadic(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_operator_step_prepare(IntPtr raw, IntPtr integrator, double t, double timestep);

		public void StepPrepare(Cpg.Integrator integrator, double t, double timestep) {
			cpg_operator_step_prepare(Handle, integrator == null ? IntPtr.Zero : integrator.Handle, t, timestep);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_operator_execute(IntPtr raw, IntPtr stack);

		public void Execute(Cpg.Stack stack) {
			cpg_operator_execute(Handle, stack == null ? IntPtr.Zero : stack.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_operator_initialize(IntPtr raw, IntPtr expressions);

		public void Initialize(GLib.SList expressions) {
			cpg_operator_initialize(Handle, expressions == null ? IntPtr.Zero : expressions.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_operator_step_evaluate(IntPtr raw, IntPtr integrator, double t, double timestep);

		public void StepEvaluate(Cpg.Integrator integrator, double t, double timestep) {
			cpg_operator_step_evaluate(Handle, integrator == null ? IntPtr.Zero : integrator.Handle, t, timestep);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_operator_get_expressions(IntPtr raw);

		public Cpg.Expression[] Expressions { 
			get {
				IntPtr raw_ret = cpg_operator_get_expressions(Handle);
				Cpg.Expression[] ret = (Cpg.Expression[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Expression));
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_operator_reset_cache(IntPtr raw);

		public void ResetCache() {
			cpg_operator_reset_cache(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_operator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_operator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_operator_copy(IntPtr raw);

		public Cpg.Operator Copy() {
			IntPtr raw_ret = cpg_operator_copy(Handle);
			Cpg.Operator ret = GLib.Object.GetObject(raw_ret, true) as Cpg.Operator;
			return ret;
		}

#endregion
	}
}
