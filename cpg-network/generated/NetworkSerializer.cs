// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class NetworkSerializer : GLib.Object {

		[Obsolete]
		protected NetworkSerializer(GLib.GType gtype) : base(gtype) {}
		public NetworkSerializer(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_network_serializer_new(IntPtr network, IntPtr root);

		public NetworkSerializer (Cpg.Network network, Cpg.Group root) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (NetworkSerializer)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				if (network != null) {
					names.Add ("network");
					vals.Add (new GLib.Value (network));
				}
				if (root != null) {
					names.Add ("root");
					vals.Add (new GLib.Value (root));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = cpg_network_serializer_new(network == null ? IntPtr.Zero : network.Handle, root == null ? IntPtr.Zero : root.Handle);
		}

		[GLib.Property ("root")]
		public Cpg.Group Root {
			get {
				GLib.Value val = GetProperty ("root");
				Cpg.Group ret = (Cpg.Group) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("network")]
		public Cpg.Network Network {
			get {
				GLib.Value val = GetProperty ("network");
				Cpg.Network ret = (Cpg.Network) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe IntPtr cpg_network_serializer_serialize_memory(IntPtr raw, out IntPtr error);

		public unsafe string SerializeMemory() {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = cpg_network_serializer_serialize_memory(Handle, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_network_serializer_serialize_path(IntPtr raw, IntPtr path, out IntPtr error);

		public unsafe bool SerializePath(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_network_serializer_serialize_path(Handle, native_path, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_network_serializer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_network_serializer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
