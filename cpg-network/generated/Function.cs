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

		[DllImport("cpg-network-2.0")]
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

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_function_get_expression(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_function_set_expression(IntPtr raw, IntPtr expression);

		[GLib.Property ("expression")]
		public Cpg.Expression Expression {
			get  {
				IntPtr raw_ret = cpg_function_get_expression(Handle);
				Cpg.Expression ret = GLib.Object.GetObject(raw_ret) as Cpg.Expression;
				return ret;
			}
			set  {
				cpg_function_set_expression(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.CDeclCallback]
		delegate void ArgumentRemovedVMDelegate (IntPtr function, IntPtr argument);

		static ArgumentRemovedVMDelegate ArgumentRemovedVMCallback;

		static void argumentremoved_cb (IntPtr function, IntPtr argument)
		{
			try {
				Function function_managed = GLib.Object.GetObject (function, false) as Function;
				function_managed.OnArgumentRemoved (GLib.Object.GetObject(argument) as Cpg.FunctionArgument);
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

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Function), ConnectionMethod="OverrideArgumentRemoved")]
		protected virtual void OnArgumentRemoved (Cpg.FunctionArgument argument)
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
		public event Cpg.ArgumentRemovedHandler ArgumentRemoved {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "argument-removed", typeof (Cpg.ArgumentRemovedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "argument-removed", typeof (Cpg.ArgumentRemovedArgs));
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

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Function), ConnectionMethod="OverrideArgumentsReordered")]
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
				function_managed.OnArgumentAdded (GLib.Object.GetObject(argument) as Cpg.FunctionArgument);
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

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Function), ConnectionMethod="OverrideArgumentAdded")]
		protected virtual void OnArgumentAdded (Cpg.FunctionArgument argument)
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
		public event Cpg.ArgumentAddedHandler ArgumentAdded {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "argument-added", typeof (Cpg.ArgumentAddedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "argument-added", typeof (Cpg.ArgumentAddedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_function_clear_arguments(IntPtr raw, out IntPtr error);

		public unsafe bool ClearArguments() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_function_clear_arguments(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_function_remove_argument(IntPtr raw, IntPtr argument, out IntPtr error);

		public unsafe bool RemoveArgument(Cpg.FunctionArgument argument) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_function_remove_argument(Handle, argument == null ? IntPtr.Zero : argument.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_function_add_argument(IntPtr raw, IntPtr argument);

		public void AddArgument(Cpg.FunctionArgument argument) {
			cpg_function_add_argument(Handle, argument == null ? IntPtr.Zero : argument.Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern uint cpg_function_get_n_optional(IntPtr raw);

		public uint NOptional { 
			get {
				uint raw_ret = cpg_function_get_n_optional(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern uint cpg_function_get_n_arguments(IntPtr raw);

		public uint NArguments { 
			get {
				uint raw_ret = cpg_function_get_n_arguments(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern int cpg_function_error_quark();

		public static new int ErrorQuark() {
			int raw_ret = cpg_function_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_function_get_arguments(IntPtr raw);

		public Cpg.FunctionArgument[] Arguments { 
			get {
				IntPtr raw_ret = cpg_function_get_arguments(Handle);
				Cpg.FunctionArgument[] ret = (Cpg.FunctionArgument[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), false, false, typeof(Cpg.FunctionArgument));
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_function_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_function_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
