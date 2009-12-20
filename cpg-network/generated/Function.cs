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

		protected Function() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
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
		static extern void cpg_function_remove_argument(IntPtr raw, IntPtr name);

		public void RemoveArgument(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			cpg_function_remove_argument(Handle, native_name);
			GLib.Marshaller.Free (native_name);
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
		static extern void cpg_function_add_argument(IntPtr raw, IntPtr name);

		public void AddArgument(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			cpg_function_add_argument(Handle, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_function_get_arguments(IntPtr raw);

		public Cpg.Property[] Arguments { 
			get {
				IntPtr raw_ret = cpg_function_get_arguments(Handle);
				Cpg.Property[] ret = (Cpg.Property[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Property));
				return ret;
			}
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_function_clear_arguments(IntPtr raw);

		public void ClearArguments() {
			cpg_function_clear_arguments(Handle);
		}

#endregion
#region Customized extensions
#line 1 "Function.custom"
		public Function(string name, string expression, params string[] arguments) : base (IntPtr.Zero)
		{
			ArrayList vals = new ArrayList();
			ArrayList names = new ArrayList();

			names.Add ("id");
			vals.Add (new GLib.Value (name));

			if (expression != null)
			{
				names.Add ("expression");
				vals.Add (new GLib.Value (new Cpg.Expression(expression)));
			}

			CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));

			SetArguments(arguments);
		}

		public Function(string name) : this(name, null)
		{
		}

		public void SetArguments(params string[] arguments) {
			ClearArguments();

			foreach (string arg in arguments)
			{
				AddArgument(arg);
			}
		}

#endregion
	}
}
