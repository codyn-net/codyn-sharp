// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

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

		[DllImport("codyn-3.0")]
		static extern void cdn_operator_step(IntPtr raw, double t, double timestep);

		public void Step(double t, double timestep) {
			cdn_operator_step(Handle, t, timestep);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_operator_foreach_function(IntPtr raw, CdnSharp.ForeachFunctionFuncNative func, IntPtr userdata);

		public void ForeachFunction(Cdn.ForeachFunctionFunc func) {
			CdnSharp.ForeachFunctionFuncWrapper func_wrapper = new CdnSharp.ForeachFunctionFuncWrapper (func);
			cdn_operator_foreach_function(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = cdn_operator_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_operator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_operator_initialize(IntPtr raw, IntPtr expressions, int num_expressions, IntPtr indices, int num_indices, int num_arguments, out int argdim, out IntPtr error);

		public unsafe bool Initialize(GLib.SList expressions, int num_expressions, GLib.SList indices, int num_indices, int num_arguments, out int argdim) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_operator_initialize(Handle, expressions == null ? IntPtr.Zero : expressions.Handle, num_expressions, indices == null ? IntPtr.Zero : indices.Handle, num_indices, num_arguments, out argdim, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_operator_equal(IntPtr raw, IntPtr other);

		public bool Equal(Cdn.Operator other) {
			bool raw_ret = cdn_operator_equal(Handle, other == null ? IntPtr.Zero : other.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_operator_reset(IntPtr raw);

		public void Reset() {
			cdn_operator_reset(Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_all_indices(IntPtr raw);

		public GLib.SList AllIndices() {
			IntPtr raw_ret = cdn_operator_all_indices(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_operator_get_num_arguments(IntPtr raw);

		public int NumArguments { 
			get {
				int raw_ret = cdn_operator_get_num_arguments(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_operator_execute(IntPtr raw, IntPtr stack);

		public void Execute(Cdn.Stack stack) {
			cdn_operator_execute(Handle, stack == null ? IntPtr.Zero : stack.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_all_expressions(IntPtr raw);

		public GLib.SList AllExpressions() {
			IntPtr raw_ret = cdn_operator_all_expressions(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_get_indices(IntPtr raw, int idx);

		public GLib.SList GetIndices(int idx) {
			IntPtr raw_ret = cdn_operator_get_indices(Handle, idx);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_operator_initialize_integrate(IntPtr raw, IntPtr integrator);

		public void InitializeIntegrate(Cdn.Integrator integrator) {
			cdn_operator_initialize_integrate(Handle, integrator == null ? IntPtr.Zero : integrator.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_operator_num_indices(IntPtr raw);

		public int NumIndices() {
			int raw_ret = cdn_operator_num_indices(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_get_primary_function(IntPtr raw);

		public Cdn.Function PrimaryFunction { 
			get {
				IntPtr raw_ret = cdn_operator_get_primary_function(Handle);
				Cdn.Function ret = GLib.Object.GetObject(raw_ret) as Cdn.Function;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_operator_error_quark();

		public static int ErrorQuark() {
			int raw_ret = cdn_operator_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_get_function(IntPtr raw, out int idx, int numidx);

		public Cdn.Function GetFunction(out int idx, int numidx) {
			IntPtr raw_ret = cdn_operator_get_function(Handle, out idx, numidx);
			Cdn.Function ret = GLib.Object.GetObject(raw_ret) as Cdn.Function;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_get_expressions(IntPtr raw, int idx);

		public Cdn.Expression[] GetExpressions(int idx) {
			IntPtr raw_ret = cdn_operator_get_expressions(Handle, idx);
			Cdn.Expression[] ret = (Cdn.Expression[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Expression));
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_operator_num_expressions(IntPtr raw);

		public int NumExpressions() {
			int raw_ret = cdn_operator_num_expressions(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_get_stack_manipulation(IntPtr raw);

		public Cdn.StackManipulation StackManipulation { 
			get {
				IntPtr raw_ret = cdn_operator_get_stack_manipulation(Handle);
				Cdn.StackManipulation ret = Cdn.StackManipulation.New (raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_operator_get_arguments_dimension(IntPtr raw);

		public int ArgumentsDimension { 
			get {
				int raw_ret = cdn_operator_get_arguments_dimension(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_operator_copy(IntPtr raw);

		public Cdn.Operator Copy() {
			IntPtr raw_ret = cdn_operator_copy(Handle);
			Cdn.Operator ret = GLib.Object.GetObject(raw_ret, true) as Cdn.Operator;
			return ret;
		}

#endregion
	}
}
