// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class EdgeAction : GLib.InitiallyUnowned, Cdn.Modifiable, Cdn.Annotatable, Cdn.Phaseable {

		[Obsolete]
		protected EdgeAction(GLib.GType gtype) : base(gtype) {}
		public EdgeAction(IntPtr raw) : base(raw) {}

		protected EdgeAction() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_action_get_index(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_edge_action_set_index(IntPtr raw, IntPtr expression);

		[GLib.Property ("index")]
		public Cdn.Expression Index {
			get  {
				IntPtr raw_ret = cdn_edge_action_get_index(Handle);
				Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
				return ret;
			}
			set  {
				cdn_edge_action_set_index(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_action_get_target(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_edge_action_set_target(IntPtr raw, IntPtr target);

		[GLib.Property ("target")]
		public string Target {
			get  {
				IntPtr raw_ret = cdn_edge_action_get_target(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cdn_edge_action_set_target(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Property ("target-property")]
		public Cdn.Variable TargetProperty {
			get {
				GLib.Value val = GetProperty ("target-property");
				Cdn.Variable ret = (Cdn.Variable) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_action_get_equation(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_edge_action_set_equation(IntPtr raw, IntPtr equation);

		[GLib.Property ("equation")]
		public Cdn.Expression Equation {
			get  {
				IntPtr raw_ret = cdn_edge_action_get_equation(Handle);
				Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
				return ret;
			}
			set  {
				cdn_edge_action_set_equation(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("link")]
		public Cdn.Edge Link {
			get {
				GLib.Value val = GetProperty ("link");
				Cdn.Edge ret = (Cdn.Edge) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_edge_action_equal(IntPtr raw, IntPtr other);

		public bool Equal(Cdn.EdgeAction other) {
			bool raw_ret = cdn_edge_action_equal(Handle, other == null ? IntPtr.Zero : other.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_edge_action_compile(IntPtr raw, IntPtr context, IntPtr error);

		public bool Compile(Cdn.CompileContext context, Cdn.CompileError error) {
			bool raw_ret = cdn_edge_action_compile(Handle, context == null ? IntPtr.Zero : context.Handle, error == null ? IntPtr.Zero : error.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_action_get_edge(IntPtr raw);

		public Cdn.Edge Edge { 
			get {
				IntPtr raw_ret = cdn_edge_action_get_edge(Handle);
				Cdn.Edge ret = GLib.Object.GetObject(raw_ret) as Cdn.Edge;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_edge_action_get_indices(IntPtr raw, out int num_indices);

		public int GetIndices(out int num_indices) {
			int raw_ret = cdn_edge_action_get_indices(Handle, out num_indices);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_action_get_target_variable(IntPtr raw);

		public Cdn.Variable TargetVariable { 
			get {
				IntPtr raw_ret = cdn_edge_action_get_target_variable(Handle);
				Cdn.Variable ret = GLib.Object.GetObject(raw_ret) as Cdn.Variable;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_action_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_edge_action_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_action_copy(IntPtr raw);

		public Cdn.EdgeAction Copy() {
			IntPtr raw_ret = cdn_edge_action_copy(Handle);
			Cdn.EdgeAction ret = GLib.Object.GetObject(raw_ret, true) as Cdn.EdgeAction;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_modifiable_get_modified(IntPtr raw);

		[DllImport("codyn-3.0")]
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

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_annotatable_get_annotation(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_annotatable_set_annotation(IntPtr raw, IntPtr annotation);

		public string Annotation { 
			get {
				IntPtr raw_ret = cdn_annotatable_get_annotation(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cdn_annotatable_set_annotation(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_annotatable_parse_annotation(IntPtr raw);

		public Cdn.AnnotationInfo ParseAnnotation() {
			IntPtr raw_ret = cdn_annotatable_parse_annotation(Handle);
			Cdn.AnnotationInfo ret = raw_ret == IntPtr.Zero ? null : (Cdn.AnnotationInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.AnnotationInfo), false);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_annotatable_get_title(IntPtr raw);

		public string Title { 
			get {
				IntPtr raw_ret = cdn_annotatable_get_title(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_remove_phase(IntPtr raw, IntPtr tag);

		public void RemovePhase(string tag) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			cdn_phaseable_remove_phase(Handle, native_tag);
			GLib.Marshaller.Free (native_tag);
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_phaseable_equal(IntPtr raw, IntPtr other);

		public bool Equal(Cdn.Phaseable other) {
			bool raw_ret = cdn_phaseable_equal(Handle, other == null ? IntPtr.Zero : other.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_copy_to(IntPtr raw, IntPtr dest);

		public void CopyTo(Cdn.Phaseable dest) {
			cdn_phaseable_copy_to(Handle, dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern System.IntPtr cdn_phaseable_get_phase_table(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_set_phase_table(IntPtr raw, System.IntPtr table);

		public System.IntPtr PhaseTable { 
			get {
				System.IntPtr raw_ret = cdn_phaseable_get_phase_table(Handle);
				System.IntPtr ret = raw_ret;
				return ret;
			}
			set {
				cdn_phaseable_set_phase_table(Handle, value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_add_phase(IntPtr raw, IntPtr phase);

		public void AddPhase(string phase) {
			IntPtr native_phase = GLib.Marshaller.StringToPtrGStrdup (phase);
			cdn_phaseable_add_phase(Handle, native_phase);
			GLib.Marshaller.Free (native_phase);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_foreach(IntPtr raw, CdnSharp.PhaseableForeachFuncNative func, IntPtr userdata);

		public void Foreach(Cdn.PhaseableForeachFunc func) {
			CdnSharp.PhaseableForeachFuncWrapper func_wrapper = new CdnSharp.PhaseableForeachFuncWrapper (func);
			cdn_phaseable_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_phaseable_is_active(IntPtr raw, IntPtr phase);

		public bool IsActive(string phase) {
			IntPtr native_phase = GLib.Marshaller.StringToPtrGStrdup (phase);
			bool raw_ret = cdn_phaseable_is_active(Handle, native_phase);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_phase);
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "EdgeAction.custom"
		[DllImport ("libgobject-2.0")]
		private static extern void g_object_ref_sink (IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_action_new(IntPtr target, IntPtr equation);

		public EdgeAction (string target, Cdn.Expression equation) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (EdgeAction))
			{
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("target");
				vals.Add (new GLib.Value (target));

				if (equation != null)
				{
					names.Add ("equation");
					vals.Add (new GLib.Value (equation));
				}

				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
			}
			else
			{
				IntPtr native_target = GLib.Marshaller.StringToPtrGStrdup (target);
				Raw = cdn_edge_action_new(native_target, equation == null ? IntPtr.Zero : equation.Handle);
				GLib.Marshaller.Free (native_target);
			}

			if (Raw != IntPtr.Zero)
			{
				g_object_ref_sink (Raw);
			}
		}

#endregion
	}
}
