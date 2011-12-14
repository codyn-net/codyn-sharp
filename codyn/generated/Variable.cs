// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Variable : GLib.Opaque {

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_set_values(IntPtr raw, out double values, int numr, int numc);

		public double SetValues(int numr, int numc) {
			double values;
			cdn_variable_set_values(Handle, out values, numr, numc);
			return values;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_variable_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_object(IntPtr raw);

		public Cdn.Object Object { 
			get {
				IntPtr raw_ret = cdn_variable_get_object(Handle);
				Cdn.Object ret = GLib.Object.GetObject(raw_ret) as Cdn.Object;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_apply_constraint(IntPtr raw);

		public void ApplyConstraint() {
			cdn_variable_apply_constraint(Handle);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_flags_from_string(IntPtr flags, out int add_flags, out int remove_flags);

		public static void FlagsFromString(string flags, out Cdn.VariableFlags add_flags, out Cdn.VariableFlags remove_flags) {
			IntPtr native_flags = GLib.Marshaller.StringToPtrGStrdup (flags);
			int native_add_flags;
			int native_remove_flags;
			cdn_variable_flags_from_string(native_flags, out native_add_flags, out native_remove_flags);
			GLib.Marshaller.Free (native_flags);
			add_flags = (Cdn.VariableFlags) native_add_flags;
			remove_flags = (Cdn.VariableFlags) native_remove_flags;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_remove_flags(IntPtr raw, int flags);

		public void RemoveFlags(Cdn.VariableFlags flags) {
			cdn_variable_remove_flags(Handle, (int) flags);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_add_flags(IntPtr raw, int flags);

		public void AddFlags(Cdn.VariableFlags flags) {
			cdn_variable_add_flags(Handle, (int) flags);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_expression(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_set_expression(IntPtr raw, IntPtr expression);

		public Cdn.Expression Expression { 
			get {
				IntPtr raw_ret = cdn_variable_get_expression(Handle);
				Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
				return ret;
			}
			set {
				cdn_variable_set_expression(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_derivative(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_set_derivative(IntPtr raw, IntPtr diffprop);

		public Cdn.Variable Derivative { 
			get {
				IntPtr raw_ret = cdn_variable_get_derivative(Handle);
				Cdn.Variable ret = raw_ret == IntPtr.Zero ? null : (Cdn.Variable) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.Variable), false);
				return ret;
			}
			set {
				cdn_variable_set_derivative(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_constraint(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_set_constraint(IntPtr raw, IntPtr expression);

		public Cdn.Expression Constraint { 
			get {
				IntPtr raw_ret = cdn_variable_get_constraint(Handle);
				Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
				return ret;
			}
			set {
				cdn_variable_set_constraint(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_flags_to_string(int add_flags, int remove_flags);

		public static string FlagsToString(Cdn.VariableFlags add_flags, Cdn.VariableFlags remove_flags) {
			IntPtr raw_ret = cdn_variable_flags_to_string((int) add_flags, (int) remove_flags);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_copy(IntPtr raw);

		public Cdn.Variable Copy() {
			IntPtr raw_ret = cdn_variable_copy(Handle);
			Cdn.Variable ret = raw_ret == IntPtr.Zero ? null : (Cdn.Variable) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.Variable), true);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_variable_get_integrated(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_set_integrated(IntPtr raw, bool integrated);

		public bool Integrated { 
			get {
				bool raw_ret = cdn_variable_get_integrated(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cdn_variable_set_integrated(Handle, value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_full_name(IntPtr raw);

		public string FullName { 
			get {
				IntPtr raw_ret = cdn_variable_get_full_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_variable_equal(IntPtr raw, IntPtr other);

		public bool Equal(Cdn.Variable other) {
			bool raw_ret = cdn_variable_equal(Handle, other == null ? IntPtr.Zero : other.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern double cdn_variable_get_update(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_set_update(IntPtr raw, double value);

		public double Update { 
			get {
				double raw_ret = cdn_variable_get_update(Handle);
				double ret = raw_ret;
				return ret;
			}
			set {
				cdn_variable_set_update(Handle, value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_full_name_for_display(IntPtr raw);

		public string FullNameForDisplay { 
			get {
				IntPtr raw_ret = cdn_variable_get_full_name_for_display(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = cdn_variable_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_variable_set_name(IntPtr raw, IntPtr name);

		public bool SetName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = cdn_variable_set_name(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_variable_get_flags(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_set_flags(IntPtr raw, int flags);

		public Cdn.VariableFlags Flags { 
			get {
				int raw_ret = cdn_variable_get_flags(Handle);
				Cdn.VariableFlags ret = (Cdn.VariableFlags) raw_ret;
				return ret;
			}
			set {
				cdn_variable_set_flags(Handle, (int) value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_reset(IntPtr raw);

		public void Reset() {
			cdn_variable_reset(Handle);
		}

		[DllImport("codyn-3.0")]
		static extern double cdn_variable_get_value(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_variable_set_value(IntPtr raw, double value);

		public double Value { 
			get {
				double raw_ret = cdn_variable_get_value(Handle);
				double ret = raw_ret;
				return ret;
			}
			set {
				cdn_variable_set_value(Handle, value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_variable_compile(IntPtr raw, IntPtr error);

		public bool Compile(Cdn.CompileError error) {
			bool raw_ret = cdn_variable_compile(Handle, error == null ? IntPtr.Zero : error.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_actions(IntPtr raw);

		public GLib.SList Actions { 
			get {
				IntPtr raw_ret = cdn_variable_get_actions(Handle);
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_integral(IntPtr raw);

		public Cdn.Variable Integral { 
			get {
				IntPtr raw_ret = cdn_variable_get_integral(Handle);
				Cdn.Variable ret = raw_ret == IntPtr.Zero ? null : (Cdn.Variable) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.Variable), false);
				return ret;
			}
		}

		public Variable(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_new(IntPtr name, IntPtr expression, int flags);

		public Variable (string name, Cdn.Expression expression, Cdn.VariableFlags flags) 
		{
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = cdn_variable_new(native_name, expression == null ? IntPtr.Zero : expression.Handle, (int) flags);
			GLib.Marshaller.Free (native_name);
		}

#endregion
#region Customized extensions
#line 1 "Variable.custom"
		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_variable_get_values(IntPtr raw, out int numr, out int numc);

		public double[,] Values
		{
			get
			{
				int numr;
				int numc;
				double[] data;

				IntPtr raw_ret = cdn_variable_get_values(Handle, out numr, out numc);

				data = new double[numr * numc];
				Marshal.Copy(raw_ret, data, 0, numr * numc);

				double[,] ret = new double[numr, numc];
				int idx = 0;

				for (int r = 0; r < numr; ++r)
				{
					for (int c = 0; c < numc; ++c)
					{
						ret[r, c] = data[idx++];
					}
				}

				return ret;
			}
		}


#endregion
	}
}
