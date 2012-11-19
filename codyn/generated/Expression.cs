// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Expression : GLib.InitiallyUnowned, Cdn.Modifiable {

		[Obsolete]
		protected Expression(GLib.GType gtype) : base(gtype) {}
		public Expression(IntPtr raw) : base(raw) {}

		protected Expression() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("expression")]
		public string ExpressionProp {
			get {
				GLib.Value val = GetProperty ("expression");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("expression", val);
				val.Dispose ();
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_value(IntPtr raw, double value);

		[GLib.Property ("value")]
		public double Value {
			get {
				GLib.Value val = GetProperty ("value");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set  {
				cdn_expression_set_value(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_expression_get_has_cache(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_has_cache(IntPtr raw, bool cache);

		[GLib.Property ("has-cache")]
		public bool HasCache {
			get  {
				bool raw_ret = cdn_expression_get_has_cache(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				cdn_expression_set_has_cache(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_cache_notify(IntPtr raw, CdnSharp.ExpressionCacheNotifyNative notify, IntPtr userdata, GLib.DestroyNotify destroy_notify);

		public Cdn.ExpressionCacheNotify CacheNotify { 
			set {
				CdnSharp.ExpressionCacheNotifyWrapper value_wrapper = new CdnSharp.ExpressionCacheNotifyWrapper (value);
				IntPtr userdata;
				GLib.DestroyNotify destroy_notify;
				if (value == null) {
					userdata = IntPtr.Zero;
					destroy_notify = null;
				} else {
					userdata = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy_notify = GLib.DestroyHelper.NotifyHandler;
				}
				cdn_expression_set_cache_notify(Handle, value_wrapper.NativeDelegate, userdata, destroy_notify);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_values(IntPtr raw, IntPtr values);

		public Cdn.Matrix Values { 
			set {
				cdn_expression_set_values(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_expression_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_expression_get_error_start(IntPtr raw);

		public int ErrorStart { 
			get {
				int raw_ret = cdn_expression_get_error_start(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_expression_get_stack_size(IntPtr raw);

		public uint StackSize { 
			get {
				uint raw_ret = cdn_expression_get_stack_size(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_expression_get_dimension(IntPtr raw, IntPtr dimension);

		public bool GetDimension(Cdn.Dimension dimension) {
			IntPtr native_dimension = GLib.Marshaller.StructureToPtrAlloc (dimension);
			bool raw_ret = cdn_expression_get_dimension(Handle, native_dimension);
			bool ret = raw_ret;
			dimension = Cdn.Dimension.New (native_dimension);
			Marshal.FreeHGlobal (native_dimension);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern double cdn_expression_evaluate(IntPtr raw);

		public double Evaluate() {
			double raw_ret = cdn_expression_evaluate(Handle);
			double ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_reset(IntPtr raw);

		public void Reset() {
			cdn_expression_reset(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_reset_cache(IntPtr raw);

		public void ResetCache() {
			cdn_expression_reset_cache(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_get_dependencies(IntPtr raw);

		public Cdn.Expression[] Dependencies { 
			get {
				IntPtr raw_ret = cdn_expression_get_dependencies(Handle);
				Cdn.Expression[] ret = (Cdn.Expression[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Expression));
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_expression_get_error_at(IntPtr raw);

		public int ErrorAt { 
			get {
				int raw_ret = cdn_expression_get_error_at(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_force_reset_cache(IntPtr raw);

		public void ForceResetCache() {
			cdn_expression_force_reset_cache(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_expression_get_pinned_sparsity(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_pinned_sparsity(IntPtr raw, bool pinned);

		public bool PinnedSparsity { 
			get {
				bool raw_ret = cdn_expression_get_pinned_sparsity(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cdn_expression_set_pinned_sparsity(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_recalculate_sparsity(IntPtr raw);

		public void RecalculateSparsity() {
			cdn_expression_recalculate_sparsity(Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_expression_depends_on(IntPtr raw, IntPtr depends_on);

		public bool DependsOn(Cdn.Expression depends_on) {
			bool raw_ret = cdn_expression_depends_on(Handle, depends_on == null ? IntPtr.Zero : depends_on.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_expression_equal(IntPtr raw, IntPtr other, bool asstring);

		public bool Equal(Cdn.Expression other, bool asstring) {
			bool raw_ret = cdn_expression_equal(Handle, other == null ? IntPtr.Zero : other.Handle, asstring);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_get_variable_dependencies(IntPtr raw);

		public Cdn.Variable[] VariableDependencies { 
			get {
				IntPtr raw_ret = cdn_expression_get_variable_dependencies(Handle);
				Cdn.Variable[] ret = (Cdn.Variable[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Variable));
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_from_string(IntPtr raw, IntPtr value);

		public string FromString { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cdn_expression_set_from_string(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_expression_is_cached(IntPtr raw);

		public bool IsCached { 
			get {
				bool raw_ret = cdn_expression_is_cached(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_get_depends_on_me(IntPtr raw);

		public GLib.SList DependsOnMe { 
			get {
				IntPtr raw_ret = cdn_expression_get_depends_on_me(Handle);
				GLib.SList ret = new GLib.SList(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_get_rand_instructions(IntPtr raw);

		public Cdn.InstructionRand[] RandInstructions { 
			get {
				IntPtr raw_ret = cdn_expression_get_rand_instructions(Handle);
				Cdn.InstructionRand[] ret = (Cdn.InstructionRand[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.InstructionRand));
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_get_as_string(IntPtr raw);

		public string AsString { 
			get {
				IntPtr raw_ret = cdn_expression_get_as_string(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_expression_get_once(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_once(IntPtr raw, bool instant);

		public bool Once { 
			get {
				bool raw_ret = cdn_expression_get_once(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cdn_expression_set_once(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_get_stack_arg(IntPtr raw);

		public Cdn.StackArg StackArg { 
			get {
				IntPtr raw_ret = cdn_expression_get_stack_arg(Handle);
				Cdn.StackArg ret = raw_ret == IntPtr.Zero ? null : (Cdn.StackArg) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.StackArg), false);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_evaluate_notify(IntPtr raw, CdnSharp.ExpressionEvaluateNotifyNative notify, IntPtr userdata, GLib.DestroyNotify destroy_notify);

		public Cdn.ExpressionEvaluateNotify EvaluateNotify { 
			set {
				CdnSharp.ExpressionEvaluateNotifyWrapper value_wrapper = new CdnSharp.ExpressionEvaluateNotifyWrapper (value);
				IntPtr userdata;
				GLib.DestroyNotify destroy_notify;
				if (value == null) {
					userdata = IntPtr.Zero;
					destroy_notify = null;
				} else {
					userdata = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy_notify = GLib.DestroyHelper.NotifyHandler;
				}
				cdn_expression_set_evaluate_notify(Handle, value_wrapper.NativeDelegate, userdata, destroy_notify);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_evaluate_values(IntPtr raw);

		public Cdn.Matrix EvaluateValues() {
			IntPtr raw_ret = cdn_expression_evaluate_values(Handle);
			Cdn.Matrix ret = raw_ret == IntPtr.Zero ? null : (Cdn.Matrix) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.Matrix), false);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_expression_compile(IntPtr raw, IntPtr context, IntPtr error);

		public bool Compile(Cdn.CompileContext context, Cdn.CompileError error) {
			bool raw_ret = cdn_expression_compile(Handle, context == null ? IntPtr.Zero : context.Handle, error == null ? IntPtr.Zero : error.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_modifiable_get_modified(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_modifiable_set_modified(IntPtr raw, bool modified);

		public bool Modified { 
			get {
				bool raw_ret = cdn_modifiable_get_modified(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cdn_modifiable_set_modified(Handle, value);
			}
		}

#endregion
#region Customized extensions
#line 1 "Expression.custom"
		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_new(IntPtr expression);

		[DllImport ("libgobject-2.0-0.dll")]
		private static extern void g_object_ref_sink (IntPtr raw);

		public Expression (string expression) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Expression))
			{
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();

				names.Add ("expression");
				vals.Add (new GLib.Value (expression));

				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
			}
			else
			{
				IntPtr native_expression = GLib.Marshaller.StringToPtrGStrdup (expression);
				Raw = cdn_expression_new(native_expression);
				GLib.Marshaller.Free (native_expression);
			}

			if (Raw != IntPtr.Zero)
			{
				g_object_ref_sink (Raw);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_copy(IntPtr raw);

		public Cdn.Expression Copy() {
			IntPtr raw_ret = cdn_expression_copy(Handle);

			if (raw_ret != IntPtr.Zero)
			{
				g_object_ref_sink (Raw);
			}

			Cdn.Expression ret = GLib.Object.GetObject(raw_ret, true) as Cdn.Expression;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_get_instructions(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_instructions(IntPtr raw, IntPtr instructions);

		public Cdn.Instruction[] Instructions
		{
			get
			{
				IntPtr raw_ret = cdn_expression_get_instructions(Handle);
				IntPtr[] ptrs = (IntPtr[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(IntPtr));

				Cdn.Instruction[] ret = new Cdn.Instruction[ptrs.Length];

				for (int i = 0; i < ret.Length; ++i)
				{
					ret[i] = (Cdn.Instruction)MiniObject.GetObject(ptrs[i]);
				}

				return ret;
			}
			set
			{
				GLib.SList ptr = new GLib.SList(typeof(IntPtr));

				for (int i = 0; i < value.Length; ++i)
				{
					ptr.Append(value[i].Handle);
				}

				cdn_expression_set_instructions(Handle, ptr.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_expression_set_instructions_take(IntPtr raw, IntPtr instructions);

		public void SetInstructionsTake(Cdn.Instruction[] instructions)
		{
			GLib.SList ptr = new GLib.SList(typeof(IntPtr));

			for (int i = 0; i < instructions.Length; ++i)
			{
				ptr.Append(instructions[i].Handle);
			}

			cdn_expression_set_instructions_take(Handle, ptr.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_expression_sum(IntPtr expressions);

		public static Cdn.Expression Sum(Cdn.Expression[] expressions) {
			GLib.SList list = new GLib.SList(expressions, typeof(Cdn.Expression), true, false);

			IntPtr raw_ret = cdn_expression_sum(list == null ? IntPtr.Zero : list.Handle);
			Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
			return ret;
		}

#endregion
	}
}
