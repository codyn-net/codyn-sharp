// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Function : Cpg.Object {

		[Obsolete]
		protected Function(GLib.GType gtype) : base(gtype) {}
		public Function(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_function_new(IntPtr name, IntPtr expression);

		public Function (string name, string expression) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Function)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_expression = GLib.Marshaller.StringToPtrGStrdup (expression);
			Raw = cpg_function_new(native_name, native_expression);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_expression);
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_function_set_expression(IntPtr raw, IntPtr expression);

		[GLib.Property ("expression")]
		public Cpg.Expression Expression {
			get {
				GLib.Value val = GetProperty ("expression");
				Cpg.Expression ret = (Cpg.Expression) val;
				val.Dispose ();
				return ret;
			}
			set  {
				cpg_function_set_expression(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_function_remove_argument(IntPtr raw, IntPtr argument);

		public void RemoveArgument(Cpg.FunctionArgument argument) {
			cpg_function_remove_argument(Handle, argument == null ? IntPtr.Zero : argument.Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern uint cpg_function_get_n_arguments(IntPtr raw);

		public uint NArguments { 
			get {
				uint raw_ret = cpg_function_get_n_arguments(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_function_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_function_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern uint cpg_function_get_n_optional(IntPtr raw);

		public uint NOptional { 
			get {
				uint raw_ret = cpg_function_get_n_optional(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_function_add_argument(IntPtr raw, IntPtr argument);

		public void AddArgument(Cpg.FunctionArgument argument) {
			cpg_function_add_argument(Handle, argument == null ? IntPtr.Zero : argument.Handle);
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_function_get_arguments(IntPtr raw);

		public Cpg.FunctionArgument[] Arguments { 
			get {
				IntPtr raw_ret = cpg_function_get_arguments(Handle);
				Cpg.FunctionArgument[] ret = (Cpg.FunctionArgument[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, false, typeof(Cpg.FunctionArgument));
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_function_clear_arguments(IntPtr raw);

		public void ClearArguments() {
			cpg_function_clear_arguments(Handle);
		}

#endregion
	}
}