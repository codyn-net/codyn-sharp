// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Node : Cdn.Object {

		[Obsolete]
		protected Node(GLib.GType gtype) : base(gtype) {}
		public Node(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_new(IntPtr id, IntPtr proxy);

		public Node (string id, Cdn.Object proxy) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Node)) {
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
			Raw = cdn_node_new(native_id, proxy == null ? IntPtr.Zero : proxy.Handle);
			GLib.Marshaller.Free (native_id);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_proxy(IntPtr raw);

		[GLib.Property ("proxy")]
		public Cdn.Object Proxy {
			get  {
				IntPtr raw_ret = cdn_node_get_proxy(Handle);
				Cdn.Object ret = GLib.Object.GetObject(raw_ret) as Cdn.Object;
				return ret;
			}
		}

		[GLib.CDeclCallback]
		delegate void ChildAddedVMDelegate (IntPtr node, IntPtr objekt);

		static ChildAddedVMDelegate ChildAddedVMCallback;

		static void childadded_cb (IntPtr node, IntPtr objekt)
		{
			try {
				Node node_managed = GLib.Object.GetObject (node, false) as Node;
				node_managed.OnChildAdded (GLib.Object.GetObject(objekt) as Cdn.Object);
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

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Node), ConnectionMethod="OverrideChildAdded")]
		protected virtual void OnChildAdded (Cdn.Object objekt)
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
		public event Cdn.ChildAddedHandler ChildAdded {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child-added", typeof (Cdn.ChildAddedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child-added", typeof (Cdn.ChildAddedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ChildRemovedVMDelegate (IntPtr node, IntPtr objekt);

		static ChildRemovedVMDelegate ChildRemovedVMCallback;

		static void childremoved_cb (IntPtr node, IntPtr objekt)
		{
			try {
				Node node_managed = GLib.Object.GetObject (node, false) as Node;
				node_managed.OnChildRemoved (GLib.Object.GetObject(objekt) as Cdn.Object);
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

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Node), ConnectionMethod="OverrideChildRemoved")]
		protected virtual void OnChildRemoved (Cdn.Object objekt)
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
		public event Cdn.ChildRemovedHandler ChildRemoved {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child-removed", typeof (Cdn.ChildRemovedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child-removed", typeof (Cdn.ChildRemovedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate bool VerifyAddChildVMDelegate (IntPtr inst, IntPtr p0, IntPtr p1);

		static VerifyAddChildVMDelegate VerifyAddChildVMCallback;

		static bool verifyaddchild_cb (IntPtr inst, IntPtr p0, IntPtr p1)
		{
			try {
				Node inst_managed = GLib.Object.GetObject (inst, false) as Node;
				return inst_managed.OnVerifyAddChild (GLib.Object.GetObject(p0) as Cdn.Object, p1);
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

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Node), ConnectionMethod="OverrideVerifyAddChild")]
		protected virtual bool OnVerifyAddChild (Cdn.Object p0, IntPtr p1)
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
			Cdn.VerifyAddChildArgs args = new Cdn.VerifyAddChildArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[2];
				args.Args[0] = GLib.Object.GetObject(arg1) as Cdn.Object;
				args.Args[1] = arg2;
				Cdn.VerifyAddChildHandler handler = (Cdn.VerifyAddChildHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				if (args.RetVal == null)
					return false;
				return ((bool)args.RetVal);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in Cdn.VerifyAddChildHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("verify-add-child")]
		public event Cdn.VerifyAddChildHandler VerifyAddChild {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "verify-add-child", new VerifyAddChildSignalDelegate(VerifyAddChildSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "verify-add-child", new VerifyAddChildSignalDelegate(VerifyAddChildSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_node_verify_remove_child(IntPtr raw, IntPtr child, out IntPtr error);

		public unsafe bool VerifyRemoveChild(Cdn.Object child) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_node_verify_remove_child(Handle, child == null ? IntPtr.Zero : child.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_find_objects(IntPtr raw, IntPtr selector);

		public Cdn.Object[] FindObjects(string selector) {
			IntPtr native_selector = GLib.Marshaller.StringToPtrGStrdup (selector);
			IntPtr raw_ret = cdn_node_find_objects(Handle, native_selector);
			Cdn.Object[] ret = (Cdn.Object[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Object));
			GLib.Marshaller.Free (native_selector);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_node_set_proxy(IntPtr raw, IntPtr proxy);

		public bool SetProxy(Cdn.Object proxy) {
			bool raw_ret = cdn_node_set_proxy(Handle, proxy == null ? IntPtr.Zero : proxy.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_node_remove(IntPtr raw, IntPtr objekt, out IntPtr error);

		public unsafe bool Remove(Cdn.Object objekt) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_node_remove(Handle, objekt == null ? IntPtr.Zero : objekt.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_find_variables(IntPtr raw, IntPtr selector);

		public Cdn.Variable[] FindVariables(string selector) {
			IntPtr native_selector = GLib.Marshaller.StringToPtrGStrdup (selector);
			IntPtr raw_ret = cdn_node_find_variables(Handle, native_selector);
			Cdn.Variable[] ret = (Cdn.Variable[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Variable));
			GLib.Marshaller.Free (native_selector);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_find_object(IntPtr raw, IntPtr selector);

		public Cdn.Object FindObject(string selector) {
			IntPtr native_selector = GLib.Marshaller.StringToPtrGStrdup (selector);
			IntPtr raw_ret = cdn_node_find_object(Handle, native_selector);
			Cdn.Object ret = GLib.Object.GetObject(raw_ret) as Cdn.Object;
			GLib.Marshaller.Free (native_selector);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_node_variable_is_proxy(IntPtr raw, IntPtr name);

		public bool VariableIsProxy(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = cdn_node_variable_is_proxy(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_variable_interface(IntPtr raw);

		public Cdn.VariableInterface VariableInterface { 
			get {
				IntPtr raw_ret = cdn_node_get_variable_interface(Handle);
				Cdn.VariableInterface ret = GLib.Object.GetObject(raw_ret) as Cdn.VariableInterface;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_auto_templates_for_child(IntPtr raw, IntPtr child);

		public GLib.SList GetAutoTemplatesForChild(Cdn.Object child) {
			IntPtr raw_ret = cdn_node_get_auto_templates_for_child(Handle, child == null ? IntPtr.Zero : child.Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_self_edge(IntPtr raw);

		public Cdn.Edge SelfEdge { 
			get {
				IntPtr raw_ret = cdn_node_get_self_edge(Handle);
				Cdn.Edge ret = GLib.Object.GetObject(raw_ret) as Cdn.Edge;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_edges(IntPtr raw);

		public Cdn.Edge[] Edges { 
			get {
				IntPtr raw_ret = cdn_node_get_edges(Handle);
				Cdn.Edge[] ret = (Cdn.Edge[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Edge));
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern int cdn_node_error_quark();

		public static new int ErrorQuark() {
			int raw_ret = cdn_node_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_node_has_self_edge(IntPtr raw);

		public bool HasSelfEdge { 
			get {
				bool raw_ret = cdn_node_has_self_edge(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern unsafe bool cdn_node_add(IntPtr raw, IntPtr objekt, out IntPtr error);

		public unsafe bool Add(Cdn.Object objekt) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cdn_node_add(Handle, objekt == null ? IntPtr.Zero : objekt.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_actors(IntPtr raw);

		public Cdn.Variable[] Actors { 
			get {
				IntPtr raw_ret = cdn_node_get_actors(Handle);
				Cdn.Variable[] ret = (Cdn.Variable[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Variable));
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_children(IntPtr raw);

		public Cdn.Object[] Children { 
			get {
				IntPtr raw_ret = cdn_node_get_children(Handle);
				Cdn.Object[] ret = (Cdn.Object[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Object));
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_node_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_get_child(IntPtr raw, IntPtr name);

		public Cdn.Object GetChild(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cdn_node_get_child(Handle, native_name);
			Cdn.Object ret = GLib.Object.GetObject(raw_ret) as Cdn.Object;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_node_find_variable(IntPtr raw, IntPtr selector);

		public Cdn.Variable FindVariable(string selector) {
			IntPtr native_selector = GLib.Marshaller.StringToPtrGStrdup (selector);
			IntPtr raw_ret = cdn_node_find_variable(Handle, native_selector);
			Cdn.Variable ret = GLib.Object.GetObject(raw_ret) as Cdn.Variable;
			GLib.Marshaller.Free (native_selector);
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "Node.custom"
		Node(string id) : this(id, null)
		{
		}

#endregion
	}
}
