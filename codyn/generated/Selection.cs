// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Selection : GLib.Opaque {

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selection_copy(IntPtr raw);

		public Cdn.Selection Copy() {
			IntPtr raw_ret = cdn_selection_copy(Handle);
			Cdn.Selection ret = raw_ret == IntPtr.Zero ? null : (Cdn.Selection) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.Selection), true);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selection_get_object(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_selection_set_object(IntPtr raw, IntPtr objekt);

		public IntPtr Object { 
			get {
				IntPtr raw_ret = cdn_selection_get_object(Handle);
				IntPtr ret = raw_ret;
				return ret;
			}
			set {
				cdn_selection_set_object(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selection_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_selection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selection_get_context(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_selection_set_context(IntPtr raw, IntPtr context);

		public Cdn.ExpansionContext Context { 
			get {
				IntPtr raw_ret = cdn_selection_get_context(Handle);
				Cdn.ExpansionContext ret = raw_ret == IntPtr.Zero ? null : (Cdn.ExpansionContext) GLib.Opaque.GetOpaque (raw_ret, typeof (Cdn.ExpansionContext), false);
				return ret;
			}
			set {
				cdn_selection_set_context(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		public Selection(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selection_new(IntPtr objekt, IntPtr context);

		public Selection (IntPtr objekt, Cdn.ExpansionContext context) 
		{
			Raw = cdn_selection_new(objekt, context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selection_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				cdn_selection_ref (raw);
				Owned = true;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_selection_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				cdn_selection_unref (raw);
				Owned = false;
			}
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				cdn_selection_unref (handle);
				return false;
			}
		}

		~Selection ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
