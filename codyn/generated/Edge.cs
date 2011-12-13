// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Edge : Cdn.Object, Cdn.Layoutable, Cdn.Phaseable {

		[Obsolete]
		protected Edge(GLib.GType gtype) : base(gtype) {}
		public Edge(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_new(IntPtr id, IntPtr from, IntPtr to);

		public Edge (string id, Cdn.Node from, Cdn.Node to) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Edge)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("id");
				vals.Add (new GLib.Value (id));
				if (from != null) {
					names.Add ("from");
					vals.Add (new GLib.Value (from));
				}
				if (to != null) {
					names.Add ("to");
					vals.Add (new GLib.Value (to));
				}
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			Raw = cdn_edge_new(native_id, from == null ? IntPtr.Zero : from.Handle, to == null ? IntPtr.Zero : to.Handle);
			GLib.Marshaller.Free (native_id);
		}

		[GLib.Property ("from")]
		public Cdn.Object From {
			get {
				GLib.Value val = GetProperty ("from");
				Cdn.Object ret = (Cdn.Object) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("from", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("to")]
		public Cdn.Object To {
			get {
				GLib.Value val = GetProperty ("to");
				Cdn.Object ret = (Cdn.Object) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("to", val);
				val.Dispose ();
			}
		}

		[GLib.CDeclCallback]
		delegate void ActionAddedVMDelegate (IntPtr link, IntPtr action);

		static ActionAddedVMDelegate ActionAddedVMCallback;

		static void actionadded_cb (IntPtr link, IntPtr action)
		{
			try {
				Edge link_managed = GLib.Object.GetObject (link, false) as Edge;
				link_managed.OnActionAdded (GLib.Object.GetObject(action) as Cdn.EdgeAction);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideActionAdded (GLib.GType gtype)
		{
			if (ActionAddedVMCallback == null)
				ActionAddedVMCallback = new ActionAddedVMDelegate (actionadded_cb);
			OverrideVirtualMethod (gtype, "action-added", ActionAddedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Edge), ConnectionMethod="OverrideActionAdded")]
		protected virtual void OnActionAdded (Cdn.EdgeAction action)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (action);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("action-added")]
		public event Cdn.ActionAddedHandler ActionAdded {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "action-added", typeof (Cdn.ActionAddedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "action-added", typeof (Cdn.ActionAddedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ActionRemovedVMDelegate (IntPtr link, IntPtr action);

		static ActionRemovedVMDelegate ActionRemovedVMCallback;

		static void actionremoved_cb (IntPtr link, IntPtr action)
		{
			try {
				Edge link_managed = GLib.Object.GetObject (link, false) as Edge;
				link_managed.OnActionRemoved (GLib.Object.GetObject(action) as Cdn.EdgeAction);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideActionRemoved (GLib.GType gtype)
		{
			if (ActionRemovedVMCallback == null)
				ActionRemovedVMCallback = new ActionRemovedVMDelegate (actionremoved_cb);
			OverrideVirtualMethod (gtype, "action-removed", ActionRemovedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.Edge), ConnectionMethod="OverrideActionRemoved")]
		protected virtual void OnActionRemoved (Cdn.EdgeAction action)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (action);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("action-removed")]
		public event Cdn.ActionRemovedHandler ActionRemoved {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "action-removed", typeof (Cdn.ActionRemovedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "action-removed", typeof (Cdn.ActionRemovedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_edge_attach(IntPtr raw, IntPtr from, IntPtr to);

		public void Attach(Cdn.Node from, Cdn.Node to) {
			cdn_edge_attach(Handle, from == null ? IntPtr.Zero : from.Handle, to == null ? IntPtr.Zero : to.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_edge_remove_action(IntPtr raw, IntPtr action);

		public bool RemoveAction(Cdn.EdgeAction action) {
			bool raw_ret = cdn_edge_remove_action(Handle, action == null ? IntPtr.Zero : action.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_edge_add_action(IntPtr raw, IntPtr action);

		public bool AddAction(Cdn.EdgeAction action) {
			bool raw_ret = cdn_edge_add_action(Handle, action == null ? IntPtr.Zero : action.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_get_actions(IntPtr raw);

		public Cdn.EdgeAction[] Actions { 
			get {
				IntPtr raw_ret = cdn_edge_get_actions(Handle);
				Cdn.EdgeAction[] ret = (Cdn.EdgeAction[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.EdgeAction));
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_get_action(IntPtr raw, IntPtr target);

		public Cdn.EdgeAction GetAction(string target) {
			IntPtr native_target = GLib.Marshaller.StringToPtrGStrdup (target);
			IntPtr raw_ret = cdn_edge_get_action(Handle, native_target);
			Cdn.EdgeAction ret = GLib.Object.GetObject(raw_ret) as Cdn.EdgeAction;
			GLib.Marshaller.Free (native_target);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_get_action_template(IntPtr raw, IntPtr action, bool match_full);

		public Cdn.Edge GetActionTemplate(Cdn.EdgeAction action, bool match_full) {
			IntPtr raw_ret = cdn_edge_get_action_template(Handle, action == null ? IntPtr.Zero : action.Handle, match_full);
			Cdn.Edge ret = GLib.Object.GetObject(raw_ret) as Cdn.Edge;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_edge_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_edge_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_layoutable_set_location(IntPtr raw, int x, int y);

		public void SetLocation(int x, int y) {
			cdn_layoutable_set_location(Handle, x, y);
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_layoutable_get_has_location(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_layoutable_set_has_location(IntPtr raw, bool has_location);

		public bool HasLocation { 
			get {
				bool raw_ret = cdn_layoutable_get_has_location(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cdn_layoutable_set_has_location(Handle, value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_layoutable_supports_location(IntPtr raw);

		public bool SupportsLocation() {
			bool raw_ret = cdn_layoutable_supports_location(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_layoutable_get_location(IntPtr raw, out int x, out int y);

		public void GetLocation(out int x, out int y) {
			cdn_layoutable_get_location(Handle, out x, out y);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_foreach(IntPtr raw, CdnSharp.PhaseableForeachFuncNative func, IntPtr userdata);

		public void Foreach(Cdn.PhaseableForeachFunc func) {
			CdnSharp.PhaseableForeachFuncWrapper func_wrapper = new CdnSharp.PhaseableForeachFuncWrapper (func);
			cdn_phaseable_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("codyn-3.0")]
		static extern System.IntPtr cdn_phaseable_get_phase_table(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_set_phase_table(IntPtr raw, System.IntPtr table);

		public System.IntPtr PhaseTable { 
			get {
				System.IntPtr raw_ret = cdn_phaseable_get_phase_table(Handle);
				System.IntPtr ret = raw_ret;
				return ret;
			}
			set {
				cdn_phaseable_set_phase_table(Handle, value);
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_remove_phase(IntPtr raw, IntPtr tag);

		public void RemovePhase(string tag) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			cdn_phaseable_remove_phase(Handle, native_tag);
			GLib.Marshaller.Free (native_tag);
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_phaseable_is_active(IntPtr raw, IntPtr phase);

		public bool IsActive(string phase) {
			IntPtr native_phase = GLib.Marshaller.StringToPtrGStrdup (phase);
			bool raw_ret = cdn_phaseable_is_active(Handle, native_phase);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_phase);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_add_phase(IntPtr raw, IntPtr phase);

		public void AddPhase(string phase) {
			IntPtr native_phase = GLib.Marshaller.StringToPtrGStrdup (phase);
			cdn_phaseable_add_phase(Handle, native_phase);
			GLib.Marshaller.Free (native_phase);
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_phaseable_copy_to(IntPtr raw, IntPtr dest);

		public void CopyTo(Cdn.Phaseable dest) {
			cdn_phaseable_copy_to(Handle, dest == null ? IntPtr.Zero : dest.Handle);
		}

#endregion
	}
}
