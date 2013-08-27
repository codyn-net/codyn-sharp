// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class AnnotationInfo : GLib.Opaque {

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_annotation_info_get_annotation(IntPtr raw);

		public string Annotation { 
			get {
				IntPtr raw_ret = cdn_annotation_info_get_annotation(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_annotation_info_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_annotation_info_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_annotation_info_get_relative_to(IntPtr raw);

		public string RelativeTo { 
			get {
				IntPtr raw_ret = cdn_annotation_info_get_relative_to(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_annotation_info_get_text(IntPtr raw);

		public string Text { 
			get {
				IntPtr raw_ret = cdn_annotation_info_get_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_annotation_info_get_anchor(IntPtr raw);

		public Cdn.AnnotationAnchor Anchor { 
			get {
				int raw_ret = cdn_annotation_info_get_anchor(Handle);
				Cdn.AnnotationAnchor ret = (Cdn.AnnotationAnchor) raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_annotation_info_get_location(IntPtr raw, out double x, out double y);

		public bool GetLocation(out double x, out double y) {
			bool raw_ret = cdn_annotation_info_get_location(Handle, out x, out y);
			bool ret = raw_ret;
			return ret;
		}

		public AnnotationInfo(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_annotation_info_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			cdn_annotation_info_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				cdn_annotation_info_free (handle);
				return false;
			}
		}

		~AnnotationInfo ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}

#endregion
	}
}
