// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class LayoutableAdapter : GLib.GInterfaceAdapter, Cpg.Layoutable {

		static LayoutableIface iface;

		struct LayoutableIface {
			public IntPtr gtype;
			public IntPtr itype;

			public GetLocationDelegate get_location;
			public SetLocationDelegate set_location;
			public SupportsLocationDelegate supports_location;
		}

		static LayoutableAdapter ()
		{
			GLib.GType.Register (_gtype, typeof(LayoutableAdapter));
			iface.get_location = new GetLocationDelegate (GetLocationCallback);
			iface.set_location = new SetLocationDelegate (SetLocationCallback);
			iface.supports_location = new SupportsLocationDelegate (SupportsLocationCallback);
		}


		[GLib.CDeclCallback]
		delegate void GetLocationDelegate (IntPtr layoutable, out int x, out int y);

		static void GetLocationCallback (IntPtr layoutable, out int x, out int y)
		{
			try {
				Cpg.LayoutableImplementor __obj = GLib.Object.GetObject (layoutable, false) as Cpg.LayoutableImplementor;
				__obj.GetLocation (out x, out y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.CDeclCallback]
		delegate void SetLocationDelegate (IntPtr layoutable, int x, int y);

		static void SetLocationCallback (IntPtr layoutable, int x, int y)
		{
			try {
				Cpg.LayoutableImplementor __obj = GLib.Object.GetObject (layoutable, false) as Cpg.LayoutableImplementor;
				__obj.SetLocation (x, y);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.CDeclCallback]
		delegate bool SupportsLocationDelegate (IntPtr layoutable);

		static bool SupportsLocationCallback (IntPtr layoutable)
		{
			try {
				Cpg.LayoutableImplementor __obj = GLib.Object.GetObject (layoutable, false) as Cpg.LayoutableImplementor;
				bool __result = __obj.SupportsLocation ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}
		static void Initialize (IntPtr ifaceptr, IntPtr data)
		{
			LayoutableIface native_iface = (LayoutableIface) Marshal.PtrToStructure (ifaceptr, typeof (LayoutableIface));
			native_iface.get_location = iface.get_location;
			native_iface.set_location = iface.set_location;
			native_iface.supports_location = iface.supports_location;
			Marshal.StructureToPtr (native_iface, ifaceptr, false);
			GCHandle gch = (GCHandle) data;
			gch.Free ();
		}

		public LayoutableAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		LayoutableImplementor implementor;

		public LayoutableAdapter (LayoutableImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			this.implementor = implementor;
		}

		public LayoutableAdapter (IntPtr handle)
		{
			this.handle = handle;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_layoutable_get_type();

		private static GLib.GType _gtype = new GLib.GType (cpg_layoutable_get_type ());

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

		public static Layoutable GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static Layoutable GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is LayoutableImplementor)
				return new LayoutableAdapter (obj as LayoutableImplementor);
			else if (obj as Layoutable == null)
				return new LayoutableAdapter (obj.Handle);
			else
				return obj as Layoutable;
		}

		public LayoutableImplementor Implementor {
			get {
				return implementor;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_layoutable_set_location(IntPtr raw, int x, int y);

		public void SetLocation(int x, int y) {
			cpg_layoutable_set_location(Handle, x, y);
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_layoutable_supports_location(IntPtr raw);

		public bool SupportsLocation() {
			bool raw_ret = cpg_layoutable_supports_location(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_layoutable_get_location(IntPtr raw, out int x, out int y);

		public void GetLocation(out int x, out int y) {
			cpg_layoutable_get_location(Handle, out x, out y);
		}

#endregion
	}
}