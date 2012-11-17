// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class VariableInterface : GLib.Object {

		[Obsolete]
		protected VariableInterface(GLib.GType gtype) : base(gtype) {}
		public VariableInterface(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_variable_interface_new(IntPtr node);

		public VariableInterface (Cdn.Node node) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (VariableInterface)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				if (node != null) {
					names.Add ("node");
					vals.Add (new GLib.Value (node));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			Raw = cdn_variable_interface_new(node == null ? IntPtr.Zero : node.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_variable_interface_get_node(IntPtr raw);

		[GLib.Property ("node")]
		public Cdn.Node Node {
			get  {
				IntPtr raw_ret = cdn_variable_interface_get_node(Handle);
				Cdn.Node ret = GLib.Object.GetObject(raw_ret) as Cdn.Node;
				return ret;
			}
		}

		[GLib.CDeclCallback]
		delegate void RemovedVMDelegate (IntPtr iface, IntPtr name, IntPtr child_name, IntPtr property_name);

		static RemovedVMDelegate RemovedVMCallback;

		static void removed_cb (IntPtr iface, IntPtr name, IntPtr child_name, IntPtr property_name)
		{
			try {
				VariableInterface iface_managed = GLib.Object.GetObject (iface, false) as VariableInterface;
				iface_managed.OnRemoved (GLib.Marshaller.Utf8PtrToString (name), GLib.Marshaller.Utf8PtrToString (child_name), GLib.Marshaller.Utf8PtrToString (property_name));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideRemoved (GLib.GType gtype)
		{
			if (RemovedVMCallback == null)
				RemovedVMCallback = new RemovedVMDelegate (removed_cb);
			OverrideVirtualMethod (gtype, "removed", RemovedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.VariableInterface), ConnectionMethod="OverrideRemoved")]
		protected virtual void OnRemoved (string name, string child_name, string property_name)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (4);
			GLib.Value[] vals = new GLib.Value [4];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (name);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (child_name);
			inst_and_params.Append (vals [2]);
			vals [3] = new GLib.Value (property_name);
			inst_and_params.Append (vals [3]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("removed")]
		public event Cdn.RemovedHandler Removed {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "removed", typeof (Cdn.RemovedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "removed", typeof (Cdn.RemovedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void AddedVMDelegate (IntPtr iface, IntPtr name, IntPtr child_name, IntPtr property_name);

		static AddedVMDelegate AddedVMCallback;

		static void added_cb (IntPtr iface, IntPtr name, IntPtr child_name, IntPtr property_name)
		{
			try {
				VariableInterface iface_managed = GLib.Object.GetObject (iface, false) as VariableInterface;
				iface_managed.OnAdded (GLib.Marshaller.Utf8PtrToString (name), GLib.Marshaller.Utf8PtrToString (child_name), GLib.Marshaller.Utf8PtrToString (property_name));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideAdded (GLib.GType gtype)
		{
			if (AddedVMCallback == null)
				AddedVMCallback = new AddedVMDelegate (added_cb);
			OverrideVirtualMethod (gtype, "added", AddedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.VariableInterface), ConnectionMethod="OverrideAdded")]
		protected virtual void OnAdded (string name, string child_name, string property_name)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (4);
			GLib.Value[] vals = new GLib.Value [4];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (name);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (child_name);
			inst_and_params.Append (vals [2]);
			vals [3] = new GLib.Value (property_name);
			inst_and_params.Append (vals [3]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("added")]
		public event Cdn.AddedHandler Added {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "added", typeof (Cdn.AddedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "added", typeof (Cdn.AddedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe bool cdn_variable_interface_remove(IntPtr raw, IntPtr name, out IntPtr error);

		public unsafe bool Remove(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_variable_interface_remove(Handle, native_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_variable_interface_lookup_variable_name(IntPtr raw, IntPtr name);

		public string LookupVariableName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cdn_variable_interface_lookup_variable_name(Handle, native_name);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_variable_interface_lookup(IntPtr raw, IntPtr name);

		public Cdn.Variable Lookup(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cdn_variable_interface_lookup(Handle, native_name);
			Cdn.Variable ret = GLib.Object.GetObject(raw_ret) as Cdn.Variable;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_variable_interface_get_names(IntPtr raw);

		public string[] Names { 
			get {
				IntPtr raw_ret = cdn_variable_interface_get_names(Handle);
				string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_variable_interface_lookup_child_name(IntPtr raw, IntPtr name);

		public string LookupChildName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cdn_variable_interface_lookup_child_name(Handle, native_name);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_variable_interface_error_quark();

		public static int ErrorQuark() {
			int raw_ret = cdn_variable_interface_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern unsafe bool cdn_variable_interface_add(IntPtr raw, IntPtr name, IntPtr child_name, IntPtr variable_name, out IntPtr error);

		public unsafe bool Add(string name, string child_name, string variable_name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_child_name = GLib.Marshaller.StringToPtrGStrdup (child_name);
			IntPtr native_variable_name = GLib.Marshaller.StringToPtrGStrdup (variable_name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_variable_interface_add(Handle, native_name, native_child_name, native_variable_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_child_name);
			GLib.Marshaller.Free (native_variable_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_variable_interface_implements(IntPtr raw, IntPtr name);

		public bool Implements(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = cdn_variable_interface_implements(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_variable_interface_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_variable_interface_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
