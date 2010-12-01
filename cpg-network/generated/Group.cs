// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Group : Cpg.Object {

		[Obsolete]
		protected Group(GLib.GType gtype) : base(gtype) {}
		public Group(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_new(IntPtr id, IntPtr proxy);

		public Group (string id, Cpg.Object proxy) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Group)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("id");
				vals.Add (new GLib.Value (id));
				if (proxy != null) {
					names.Add ("proxy");
					vals.Add (new GLib.Value (proxy));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			Raw = cpg_group_new(native_id, proxy == null ? IntPtr.Zero : proxy.Handle);
			GLib.Marshaller.Free (native_id);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_get_proxy(IntPtr raw);

		[GLib.Property ("proxy")]
		public Cpg.Object Proxy {
			get  {
				IntPtr raw_ret = cpg_group_get_proxy(Handle);
				Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
				return ret;
			}
		}

		[GLib.CDeclCallback]
		delegate void ChildAddedVMDelegate (IntPtr group, IntPtr objekt);

		static ChildAddedVMDelegate ChildAddedVMCallback;

		static void childadded_cb (IntPtr group, IntPtr objekt)
		{
			try {
				Group group_managed = GLib.Object.GetObject (group, false) as Group;
				group_managed.OnChildAdded (GLib.Object.GetObject(objekt) as Cpg.Object);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideChildAdded (GLib.GType gtype)
		{
			if (ChildAddedVMCallback == null)
				ChildAddedVMCallback = new ChildAddedVMDelegate (childadded_cb);
			OverrideVirtualMethod (gtype, "child-added", ChildAddedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Group), ConnectionMethod="OverrideChildAdded")]
		protected virtual void OnChildAdded (Cpg.Object objekt)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (objekt);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("child-added")]
		public event Cpg.ChildAddedHandler ChildAdded {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child-added", typeof (Cpg.ChildAddedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child-added", typeof (Cpg.ChildAddedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ChildRemovedVMDelegate (IntPtr group, IntPtr objekt);

		static ChildRemovedVMDelegate ChildRemovedVMCallback;

		static void childremoved_cb (IntPtr group, IntPtr objekt)
		{
			try {
				Group group_managed = GLib.Object.GetObject (group, false) as Group;
				group_managed.OnChildRemoved (GLib.Object.GetObject(objekt) as Cpg.Object);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideChildRemoved (GLib.GType gtype)
		{
			if (ChildRemovedVMCallback == null)
				ChildRemovedVMCallback = new ChildRemovedVMDelegate (childremoved_cb);
			OverrideVirtualMethod (gtype, "child-removed", ChildRemovedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Group), ConnectionMethod="OverrideChildRemoved")]
		protected virtual void OnChildRemoved (Cpg.Object objekt)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (objekt);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("child-removed")]
		public event Cpg.ChildRemovedHandler ChildRemoved {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child-removed", typeof (Cpg.ChildRemovedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child-removed", typeof (Cpg.ChildRemovedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate bool VerifyAddChildVMDelegate (IntPtr inst, IntPtr p0, IntPtr p1);

		static VerifyAddChildVMDelegate VerifyAddChildVMCallback;

		static bool verifyaddchild_cb (IntPtr inst, IntPtr p0, IntPtr p1)
		{
			try {
				Group inst_managed = GLib.Object.GetObject (inst, false) as Group;
				return inst_managed.OnVerifyAddChild (GLib.Object.GetObject (p0), p1);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call doesn't return
				throw e;
			}
		}

		private static void OverrideVerifyAddChild (GLib.GType gtype)
		{
			if (VerifyAddChildVMCallback == null)
				VerifyAddChildVMCallback = new VerifyAddChildVMDelegate (verifyaddchild_cb);
			OverrideVirtualMethod (gtype, "verify-add-child", VerifyAddChildVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Group), ConnectionMethod="OverrideVerifyAddChild")]
		protected virtual bool OnVerifyAddChild (GLib.Object p0, IntPtr p1)
		{
			GLib.Value ret = new GLib.Value (GLib.GType.Boolean);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (p1);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			bool result = (bool) ret;
			ret.Dispose ();
			return result;
		}

		[GLib.CDeclCallback]
		delegate bool VerifyAddChildSignalDelegate (IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr gch);

		static bool VerifyAddChildSignalCallback (IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr gch)
		{
			Cpg.VerifyAddChildArgs args = new Cpg.VerifyAddChildArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[2];
				if (arg1 == IntPtr.Zero)
					args.Args[0] = null;
				else {
					args.Args[0] = GLib.Object.GetObject (arg1);
				}
				args.Args[1] = arg2;
				Cpg.VerifyAddChildHandler handler = (Cpg.VerifyAddChildHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				if (args.RetVal == null)
					return false;
				return ((bool)args.RetVal);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in Cpg.VerifyAddChildHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("verify-add-child")]
		public event Cpg.VerifyAddChildHandler VerifyAddChild {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "verify-add-child", new VerifyAddChildSignalDelegate(VerifyAddChildSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "verify-add-child", new VerifyAddChildSignalDelegate(VerifyAddChildSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_group_verify_remove_child(IntPtr raw, IntPtr child, out IntPtr error);

		public unsafe bool VerifyRemoveChild(Cpg.Object child) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_group_verify_remove_child(Handle, child == null ? IntPtr.Zero : child.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_group_remove(IntPtr raw, IntPtr objekt, out IntPtr error);

		public unsafe bool Remove(Cpg.Object objekt) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_group_remove(Handle, objekt == null ? IntPtr.Zero : objekt.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_group_property_is_proxy(IntPtr raw, IntPtr name);

		public bool PropertyIsProxy(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = cpg_group_property_is_proxy(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_find_object(IntPtr raw, IntPtr path);

		public Cpg.Object FindObject(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = cpg_group_find_object(Handle, native_path);
			Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_find_property(IntPtr raw, IntPtr path);

		public Cpg.Property FindProperty(string path) {
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = cpg_group_find_property(Handle, native_path);
			Cpg.Property ret = GLib.Object.GetObject(raw_ret) as Cpg.Property;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern int cpg_group_error_quark();

		public static new int ErrorQuark() {
			int raw_ret = cpg_group_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_group_set_proxy(IntPtr raw, IntPtr proxy);

		public bool SetProxy(Cpg.Object proxy) {
			bool raw_ret = cpg_group_set_proxy(Handle, proxy == null ? IntPtr.Zero : proxy.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_group_add(IntPtr raw, IntPtr objekt, out IntPtr error);

		public unsafe bool Add(Cpg.Object objekt) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_group_add(Handle, objekt == null ? IntPtr.Zero : objekt.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_get_children(IntPtr raw);

		public Cpg.Object[] Children { 
			get {
				IntPtr raw_ret = cpg_group_get_children(Handle);
				Cpg.Object[] ret = (Cpg.Object[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Object));
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_group_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_group_get_child(IntPtr raw, IntPtr name);

		public Cpg.Object GetChild(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_group_get_child(Handle, native_name);
			Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "Group.custom"
		Group(string id) : this(id, null)
		{
		}

#endregion
	}
}
