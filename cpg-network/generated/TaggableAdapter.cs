// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class TaggableAdapter : GLib.GInterfaceAdapter, Cpg.Taggable {

		static TaggableIface iface;

		struct TaggableIface {
			public IntPtr gtype;
			public IntPtr itype;

			public GetTagTableDelegate get_tag_table;
		}

		static TaggableAdapter ()
		{
			GLib.GType.Register (_gtype, typeof(TaggableAdapter));
			iface.get_tag_table = new GetTagTableDelegate (GetTagTableCallback);
		}


		[GLib.CDeclCallback]
		delegate System.IntPtr GetTagTableDelegate (IntPtr taggable);

		static System.IntPtr GetTagTableCallback (IntPtr taggable)
		{
			try {
				Cpg.TaggableImplementor __obj = GLib.Object.GetObject (taggable, false) as Cpg.TaggableImplementor;
				System.IntPtr __result = __obj.TagTable;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}
		static void Initialize (IntPtr ifaceptr, IntPtr data)
		{
			TaggableIface native_iface = (TaggableIface) Marshal.PtrToStructure (ifaceptr, typeof (TaggableIface));
			native_iface.get_tag_table = iface.get_tag_table;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
			GCHandle gch = (GCHandle) data;
			gch.Free ();
		}

		public TaggableAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		TaggableImplementor implementor;

		public TaggableAdapter (TaggableImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			this.implementor = implementor;
		}

		public TaggableAdapter (IntPtr handle)
		{
			this.handle = handle;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_taggable_get_type();

		private static GLib.GType _gtype = new GLib.GType (cpg_taggable_get_type ());

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

		public static Taggable GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static Taggable GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is TaggableImplementor)
				return new TaggableAdapter (obj as TaggableImplementor);
			else if (obj as Taggable == null)
				return new TaggableAdapter (obj.Handle);
			else
				return obj as Taggable;
		}

		public TaggableImplementor Implementor {
			get {
				return implementor;
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
		static extern bool cpg_taggable_has_tag(IntPtr raw, IntPtr tag);

		public bool HasTag(string tag) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			bool raw_ret = cpg_taggable_has_tag(Handle, native_tag);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_tag);
			return ret;
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
		static extern IntPtr cpg_taggable_get_tag(IntPtr raw, IntPtr tag);

		public string GetTag(string tag) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			IntPtr raw_ret = cpg_taggable_get_tag(Handle, native_tag);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_tag);
			return ret;
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
		static extern System.IntPtr cpg_taggable_create_table();

		public static System.IntPtr CreateTable() {
			System.IntPtr raw_ret = cpg_taggable_create_table();
			System.IntPtr ret = raw_ret;
			return ret;
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

#endregion
	}
}