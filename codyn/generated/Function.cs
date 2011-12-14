// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Function : Cdn.Object {

		[Obsolete]
		protected Function(GLib.GType gtype) : base(gtype) {}
		public Function(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_function_new(IntPtr name, IntPtr expression);

		public Function (string name, Cdn.Expression expression) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Function)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = cdn_function_new(native_name, expression == null ? IntPtr.Zero : expression.Handle);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_function_get_expression(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_function_set_expression(IntPtr raw, IntPtr expression);

		[GLib.Property ("expression")]
		public Cdn.Expression Expression {
			get  {
				IntPtr raw_ret = cdn_function_get_expression(Handle);
				Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
				return ret;
			}
			set  {
				cdn_function_set_expression(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.CDeclCallback]
		delegate void ArgumentRemovedVMDelegate (IntPtr function, IntPtr argument);

		static ArgumentRemovedVMDelegate ArgumentRemovedVMCallback;

		static void argumentremoved_cb (IntPtr function, IntPtr argument)
		{
			try {
				Function function_managed = GLib.Object.GetObject (function, false) as Function;
				function_managed.OnArgumentRemoved (GLib.Object.GetObject(argument) as Cdn.FunctionArgument);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideArgumentRemoved (GLib.GType gtype)
		{
			if (ArgumentRemovedVMCallback == null)
				ArgumentRemovedVMCallback = new ArgumentRemovedVMDelegate (argumentremoved_cb);
			OverrideVirtualMethod (gtype, "argument-removed", ArgumentRemovedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Function), ConnectionMethod="OverrideArgumentRemoved")]
		protected virtual void OnArgumentRemoved (Cdn.FunctionArgument argument)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (argument);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("argument-removed")]
		public event Cdn.ArgumentRemovedHandler ArgumentRemoved {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "argument-removed", typeof (Cdn.ArgumentRemovedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "argument-removed", typeof (Cdn.ArgumentRemovedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ArgumentsReorderedVMDelegate (IntPtr function);

		static ArgumentsReorderedVMDelegate ArgumentsReorderedVMCallback;

		static void argumentsreordered_cb (IntPtr function)
		{
			try {
				Function function_managed = GLib.Object.GetObject (function, false) as Function;
				function_managed.OnArgumentsReordered ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideArgumentsReordered (GLib.GType gtype)
		{
			if (ArgumentsReorderedVMCallback == null)
				ArgumentsReorderedVMCallback = new ArgumentsReorderedVMDelegate (argumentsreordered_cb);
			OverrideVirtualMethod (gtype, "arguments-reordered", ArgumentsReorderedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Function), ConnectionMethod="OverrideArgumentsReordered")]
		protected virtual void OnArgumentsReordered ()
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

		[GLib.Signal("arguments-reordered")]
		public event System.EventHandler ArgumentsReordered {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "arguments-reordered");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "arguments-reordered");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ArgumentAddedVMDelegate (IntPtr function, IntPtr argument);

		static ArgumentAddedVMDelegate ArgumentAddedVMCallback;

		static void argumentadded_cb (IntPtr function, IntPtr argument)
		{
			try {
				Function function_managed = GLib.Object.GetObject (function, false) as Function;
				function_managed.OnArgumentAdded (GLib.Object.GetObject(argument) as Cdn.FunctionArgument);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideArgumentAdded (GLib.GType gtype)
		{
			if (ArgumentAddedVMCallback == null)
				ArgumentAddedVMCallback = new ArgumentAddedVMDelegate (argumentadded_cb);
			OverrideVirtualMethod (gtype, "argument-added", ArgumentAddedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Function), ConnectionMethod="OverrideArgumentAdded")]
		protected virtual void OnArgumentAdded (Cdn.FunctionArgument argument)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (argument);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("argument-added")]
		public event Cdn.ArgumentAddedHandler ArgumentAdded {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "argument-added", typeof (Cdn.ArgumentAddedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "argument-added", typeof (Cdn.ArgumentAddedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern uint cdn_function_get_n_implicit(IntPtr raw);

		public uint NImplicit { 
			get {
				uint raw_ret = cdn_function_get_n_implicit(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_function_get_dimension(IntPtr raw, int arguments, out int argdim, out int numr, out int numc);

		public void GetDimension(int arguments, out int argdim, out int numr, out int numc) {
			cdn_function_get_dimension(Handle, arguments, out argdim, out numr, out numc);
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_function_clear_arguments(IntPtr raw, out IntPtr error);

		public unsafe bool ClearArguments() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_function_clear_arguments(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_function_get_argument(IntPtr raw, IntPtr name);

		public Cdn.FunctionArgument GetArgument(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cdn_function_get_argument(Handle, native_name);
			Cdn.FunctionArgument ret = GLib.Object.GetObject(raw_ret) as Cdn.FunctionArgument;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_function_remove_argument(IntPtr raw, IntPtr argument, out IntPtr error);

		public unsafe bool RemoveArgument(Cdn.FunctionArgument argument) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_function_remove_argument(Handle, argument == null ? IntPtr.Zero : argument.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_function_add_argument(IntPtr raw, IntPtr argument);

		public void AddArgument(Cdn.FunctionArgument argument) {
			cdn_function_add_argument(Handle, argument == null ? IntPtr.Zero : argument.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern uint cdn_function_get_n_optional(IntPtr raw);

		public uint NOptional { 
			get {
				uint raw_ret = cdn_function_get_n_optional(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern uint cdn_function_get_n_arguments(IntPtr raw);

		public uint NArguments { 
			get {
				uint raw_ret = cdn_function_get_n_arguments(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_function_error_quark();

		public static new int ErrorQuark() {
			int raw_ret = cdn_function_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_function_get_arguments(IntPtr raw);

		public Cdn.FunctionArgument[] Arguments { 
			get {
				IntPtr raw_ret = cdn_function_get_arguments(Handle);
				Cdn.FunctionArgument[] ret = (Cdn.FunctionArgument[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, false, typeof(Cdn.FunctionArgument));
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_function_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_function_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}