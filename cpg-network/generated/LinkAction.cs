// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class LinkAction : GLib.InitiallyUnowned, Cpg.Modifiable, Cpg.Annotatable, Cpg.Taggable {

		[Obsolete]
		protected LinkAction(GLib.GType gtype) : base(gtype) {}
		public LinkAction(IntPtr raw) : base(raw) {}

		protected LinkAction() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_get_target(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_link_action_set_target(IntPtr raw, IntPtr target);

		[GLib.Property ("target")]
		public string Target {
			get  {
				IntPtr raw_ret = cpg_link_action_get_target(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cpg_link_action_set_target(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_get_target_property(IntPtr raw);

		[GLib.Property ("target-property")]
		public Cpg.Property TargetProperty {
			get  {
				IntPtr raw_ret = cpg_link_action_get_target_property(Handle);
				Cpg.Property ret = GLib.Object.GetObject(raw_ret) as Cpg.Property;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_get_equation(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_link_action_set_equation(IntPtr raw, IntPtr equation);

		[GLib.Property ("equation")]
		public Cpg.Expression Equation {
			get  {
				IntPtr raw_ret = cpg_link_action_get_equation(Handle);
				Cpg.Expression ret = GLib.Object.GetObject(raw_ret) as Cpg.Expression;
				return ret;
			}
			set  {
				cpg_link_action_set_equation(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("link")]
		public Cpg.Link Link {
			get {
				GLib.Value val = GetProperty ("link");
				Cpg.Link ret = (Cpg.Link) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_link_action_get_enabled(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_link_action_set_enabled(IntPtr raw, bool enabled);

		[GLib.Property ("enabled")]
		public bool Enabled {
			get  {
				bool raw_ret = cpg_link_action_get_enabled(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				cpg_link_action_set_enabled(Handle, value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_link_action_equal(IntPtr raw, IntPtr other);

		public bool Equal(Cpg.LinkAction other) {
			bool raw_ret = cpg_link_action_equal(Handle, other == null ? IntPtr.Zero : other.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_copy(IntPtr raw);

		public Cpg.LinkAction Copy() {
			IntPtr raw_ret = cpg_link_action_copy(Handle);
			Cpg.LinkAction ret = GLib.Object.GetObject(raw_ret, true) as Cpg.LinkAction;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_link_action_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_modifiable_get_modified(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_modifiable_set_modified(IntPtr raw, bool modified);

		public bool Modified { 
			get {
				bool raw_ret = cpg_modifiable_get_modified(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cpg_modifiable_set_modified(Handle, value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_annotatable_get_annotation(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_annotatable_set_annotation(IntPtr raw, IntPtr annotation);

		public string Annotation { 
			get {
				IntPtr raw_ret = cpg_annotatable_get_annotation(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cpg_annotatable_set_annotation(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_annotatable_get_title(IntPtr raw);

		public string Title { 
			get {
				IntPtr raw_ret = cpg_annotatable_get_title(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_taggable_remove_tag(IntPtr raw, IntPtr tag);

		public void RemoveTag(string tag) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			cpg_taggable_remove_tag(Handle, native_tag);
			GLib.Marshaller.Free (native_tag);
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_taggable_add_tag(IntPtr raw, IntPtr tag, IntPtr value);

		public void AddTag(string tag, string value) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			cpg_taggable_add_tag(Handle, native_tag, native_value);
			GLib.Marshaller.Free (native_tag);
			GLib.Marshaller.Free (native_value);
		}

		[DllImport("cpg-network-2.0")]
		static extern System.IntPtr cpg_taggable_get_tag_table(IntPtr raw);

		public System.IntPtr TagTable { 
			get {
				System.IntPtr raw_ret = cpg_taggable_get_tag_table(Handle);
				System.IntPtr ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_taggable_copy_to(IntPtr raw, System.IntPtr tags);

		public void CopyTo(System.IntPtr tags) {
			cpg_taggable_copy_to(Handle, tags);
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_taggable_try_get_tag(IntPtr raw, IntPtr tag, IntPtr value);

		public bool TryGetTag(string tag, string value) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			bool raw_ret = cpg_taggable_try_get_tag(Handle, native_tag, native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_tag);
			GLib.Marshaller.Free (native_value);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_taggable_has_tag(IntPtr raw, IntPtr tag);

		public bool HasTag(string tag) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			bool raw_ret = cpg_taggable_has_tag(Handle, native_tag);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_tag);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_taggable_get_tag(IntPtr raw, IntPtr tag);

		public string GetTag(string tag) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			IntPtr raw_ret = cpg_taggable_get_tag(Handle, native_tag);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_tag);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_taggable_foreach(IntPtr raw, CpgSharp.TaggableForeachFuncNative func, IntPtr userdata);

		public void Foreach(Cpg.TaggableForeachFunc func) {
			CpgSharp.TaggableForeachFuncWrapper func_wrapper = new CpgSharp.TaggableForeachFuncWrapper (func);
			cpg_taggable_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

#endregion
#region Customized extensions
#line 1 "LinkAction.custom"
		[DllImport ("libgobject-2.0")]
		private static extern void g_object_ref_sink (IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_link_action_new(IntPtr target, IntPtr equation);

		public LinkAction (string target, Cpg.Expression equation) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (LinkAction))
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
				Raw = cpg_link_action_new(native_target, equation == null ? IntPtr.Zero : equation.Handle);
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
