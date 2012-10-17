// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class AnnotatableAdapter : GLib.GInterfaceAdapter, Cdn.Annotatable {

		static AnnotatableIface iface;

		struct AnnotatableIface {
			public IntPtr gtype;
			public IntPtr itype;

			public GetTitleDelegate get_title;
			public SetAnnotationDelegate set_annotation;
			public GetAnnotationDelegate get_annotation;
		}

		static AnnotatableAdapter ()
		{
			GLib.GType.Register (_gtype, typeof(AnnotatableAdapter));
			iface.get_title = new GetTitleDelegate (GetTitleCallback);
			iface.set_annotation = new SetAnnotationDelegate (SetAnnotationCallback);
			iface.get_annotation = new GetAnnotationDelegate (GetAnnotationCallback);
		}


		[GLib.CDeclCallback]
		delegate IntPtr GetTitleDelegate (IntPtr annotatable);

		static IntPtr GetTitleCallback (IntPtr annotatable)
		{
			try {
				Cdn.AnnotatableImplementor __obj = GLib.Object.GetObject (annotatable, false) as Cdn.AnnotatableImplementor;
				string __result = __obj.Title;
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.CDeclCallback]
		delegate void SetAnnotationDelegate (IntPtr annotatable, IntPtr annotation);

		static void SetAnnotationCallback (IntPtr annotatable, IntPtr annotation)
		{
			try {
				Cdn.AnnotatableImplementor __obj = GLib.Object.GetObject (annotatable, false) as Cdn.AnnotatableImplementor;
				__obj.Annotation = GLib.Marshaller.Utf8PtrToString (annotation);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.CDeclCallback]
		delegate IntPtr GetAnnotationDelegate (IntPtr annotatable);

		static IntPtr GetAnnotationCallback (IntPtr annotatable)
		{
			try {
				Cdn.AnnotatableImplementor __obj = GLib.Object.GetObject (annotatable, false) as Cdn.AnnotatableImplementor;
				string __result = __obj.Annotation;
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}
		static void Initialize (IntPtr ifaceptr, IntPtr data)
		{
			AnnotatableIface native_iface = (AnnotatableIface) Marshal.PtrToStructure (ifaceptr, typeof (AnnotatableIface));
			native_iface.get_title = iface.get_title;
			native_iface.set_annotation = iface.set_annotation;
			native_iface.get_annotation = iface.get_annotation;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
			GCHandle gch = (GCHandle) data;
			gch.Free ();
		}

		public AnnotatableAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		AnnotatableImplementor implementor;

		public AnnotatableAdapter (AnnotatableImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			this.implementor = implementor;
		}

		public AnnotatableAdapter (IntPtr handle)
		{
			this.handle = handle;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_annotatable_get_type();

		private static GLib.GType _gtype = new GLib.GType (cdn_annotatable_get_type ());

		public override GLib.GType GType {
			get {
				return _gtype;
			}
		}

		IntPtr handle;
		public override IntPtr Handle {
			get {
				if (handle != IntPtr.Zero)
					return handle;
				return implementor == null ? IntPtr.Zero : implementor.Handle;
			}
		}

		public static Annotatable GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static Annotatable GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is AnnotatableImplementor)
				return new AnnotatableAdapter (obj as AnnotatableImplementor);
			else if (obj as Annotatable == null)
				return new AnnotatableAdapter (obj.Handle);
			else
				return obj as Annotatable;
		}

		public AnnotatableImplementor Implementor {
			get {
				return implementor;
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

#endregion
	}
}
