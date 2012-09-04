// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Math {

		[DllImport("codyn-3.0")]
		static extern bool cdn_math_function_is_commutative(int type, IntPtr argdim);

		public static bool FunctionIsCommutative(Cdn.MathFunctionType type, Cdn.StackArgs argdim) {
			bool raw_ret = cdn_math_function_is_commutative((int) type, argdim == null ? IntPtr.Zero : argdim.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_math_function_lookup(IntPtr name, out int arguments);

		public static Cdn.MathFunctionType FunctionLookup(string name, out int arguments) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = cdn_math_function_lookup(native_name, out arguments);
			Cdn.MathFunctionType ret = (Cdn.MathFunctionType) raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_math_function_lookup_by_id(int type, out int arguments);

		public static string FunctionLookupById(Cdn.MathFunctionType type, out int arguments) {
			IntPtr raw_ret = cdn_math_function_lookup_by_id((int) type, out arguments);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_math_compute_sparsity(int type, IntPtr inargs, IntPtr outarg);

		public static void ComputeSparsity(Cdn.MathFunctionType type, Cdn.StackArgs inargs, Cdn.StackArg outarg) {
			IntPtr native_outarg = GLib.Marshaller.StructureToPtrAlloc (outarg);
			cdn_math_compute_sparsity((int) type, inargs == null ? IntPtr.Zero : inargs.Handle, native_outarg);
			outarg = Cdn.StackArg.New (native_outarg);
			Marshal.FreeHGlobal (native_outarg);
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_math_function_get_stack_manipulation(int type, IntPtr inargs, IntPtr outarg, out int extra_space, out IntPtr error);

		public static unsafe bool FunctionGetStackManipulation(Cdn.MathFunctionType type, Cdn.StackArgs inargs, Cdn.StackArg outarg, out int extra_space) {
			IntPtr native_outarg = GLib.Marshaller.StructureToPtrAlloc (outarg);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_math_function_get_stack_manipulation((int) type, inargs == null ? IntPtr.Zero : inargs.Handle, native_outarg, out extra_space, out error);
			bool ret = raw_ret;
			outarg = Cdn.StackArg.New (native_outarg);
			Marshal.FreeHGlobal (native_outarg);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern double cdn_math_constant_lookup(IntPtr name, out bool found);

		public static double ConstantLookup(string name, out bool found) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			double raw_ret = cdn_math_constant_lookup(native_name, out found);
			double ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_math_function_execute(int type, IntPtr argdim, IntPtr stack);

		public static void FunctionExecute(Cdn.MathFunctionType type, Cdn.StackArgs argdim, Cdn.Stack stack) {
			cdn_math_function_execute((int) type, argdim == null ? IntPtr.Zero : argdim.Handle, stack == null ? IntPtr.Zero : stack.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern uint cdn_math_register_builtin_function(IntPtr name, int numargs, CdnSharp.MathFunctionEvaluateFuncNative evaluate, CdnSharp.MathStackManipulationFuncNative smanipcb, IntPtr userdata, GLib.DestroyNotify destroy_notify);

		public static uint RegisterBuiltinFunction(string name, int numargs, Cdn.MathFunctionEvaluateFunc evaluate, Cdn.MathStackManipulationFunc smanipcb) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			CdnSharp.MathFunctionEvaluateFuncWrapper evaluate_wrapper = new CdnSharp.MathFunctionEvaluateFuncWrapper (evaluate);
			CdnSharp.MathStackManipulationFuncWrapper smanipcb_wrapper = new CdnSharp.MathStackManipulationFuncWrapper (smanipcb);
			IntPtr userdata;
			GLib.DestroyNotify destroy_notify;
			if (smanipcb == null) {
				userdata = IntPtr.Zero;
				destroy_notify = null;
			} else {
				userdata = (IntPtr) GCHandle.Alloc (smanipcb_wrapper);
				destroy_notify = GLib.DestroyHelper.NotifyHandler;
			}
			uint raw_ret = cdn_math_register_builtin_function(native_name, numargs, evaluate_wrapper.NativeDelegate, smanipcb_wrapper.NativeDelegate, userdata, destroy_notify);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_math_function_is_variable(int type);

		public static bool FunctionIsVariable(Cdn.MathFunctionType type) {
			bool raw_ret = cdn_math_function_is_variable((int) type);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
