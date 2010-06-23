// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Object : GLib.Object {

		[Obsolete]
		protected Object(GLib.GType gtype) : base(gtype) {}
		public Object(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_new(IntPtr id);

		public Object (string id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Object)) {
				ArrayList vals = new ArrayList();
				ArrayList names = new ArrayList();
				names.Add ("id");
				vals.Add (new GLib.Value (id));
				CreateNativeObject ((string[])names.ToArray (typeof (string)), (GLib.Value[])vals.ToArray (typeof (GLib.Value)));
				return;
			}
			IntPtr native_id = GLib.Marshaller.StringToPtrGStrdup (id);
			Raw = cpg_object_new(native_id);
			GLib.Marshaller.Free (native_id);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_get_parent(IntPtr raw);

		[GLib.Property ("parent")]
		public Cpg.Object Parent {
			get  {
				IntPtr raw_ret = cpg_object_get_parent(Handle);
				Cpg.Object ret = GLib.Object.GetObject(raw_ret) as Cpg.Object;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_get_id(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_object_set_id(IntPtr raw, IntPtr id);

		[GLib.Property ("id")]
		public string Id {
			get  {
				IntPtr raw_ret = cpg_object_get_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				cpg_object_set_id(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.CDeclCallback]
		delegate void ResettedVMDelegate (IntPtr objekt);

		static ResettedVMDelegate ResettedVMCallback;

		static void resetted_cb (IntPtr objekt)
		{
			try {
				Object objekt_managed = GLib.Object.GetObject (objekt, false) as Object;
				objekt_managed.OnResetted ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideResetted (GLib.GType gtype)
		{
			if (ResettedVMCallback == null)
				ResettedVMCallback = new ResettedVMDelegate (resetted_cb);
			OverrideVirtualMethod (gtype, "resetted", ResettedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Object), ConnectionMethod="OverrideResetted")]
		protected virtual void OnResetted ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("resetted")]
		public event System.EventHandler Resetted {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "resetted");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "resetted");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void CompiledVMDelegate (IntPtr objekt);

		static CompiledVMDelegate CompiledVMCallback;

		static void compiled_cb (IntPtr objekt)
		{
			try {
				Object objekt_managed = GLib.Object.GetObject (objekt, false) as Object;
				objekt_managed.OnCompiled ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideCompiled (GLib.GType gtype)
		{
			if (CompiledVMCallback == null)
				CompiledVMCallback = new CompiledVMDelegate (compiled_cb);
			OverrideVirtualMethod (gtype, "compiled", CompiledVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Object), ConnectionMethod="OverrideCompiled")]
		protected virtual void OnCompiled ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("compiled")]
		public event System.EventHandler Compiled {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "compiled");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "compiled");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void PropertyRemovedVMDelegate (IntPtr objekt, IntPtr property);

		static PropertyRemovedVMDelegate PropertyRemovedVMCallback;

		static void propertyremoved_cb (IntPtr objekt, IntPtr property)
		{
			try {
				Object objekt_managed = GLib.Object.GetObject (objekt, false) as Object;
				objekt_managed.OnPropertyRemoved (GLib.Object.GetObject(property) as Cpg.Property);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePropertyRemoved (GLib.GType gtype)
		{
			if (PropertyRemovedVMCallback == null)
				PropertyRemovedVMCallback = new PropertyRemovedVMDelegate (propertyremoved_cb);
			OverrideVirtualMethod (gtype, "property-removed", PropertyRemovedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Object), ConnectionMethod="OverridePropertyRemoved")]
		protected virtual void OnPropertyRemoved (Cpg.Property property)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (property);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("property-removed")]
		public event Cpg.PropertyRemovedHandler PropertyRemoved {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "property-removed", typeof (Cpg.PropertyRemovedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "property-removed", typeof (Cpg.PropertyRemovedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void PropertyAddedVMDelegate (IntPtr objekt, IntPtr property);

		static PropertyAddedVMDelegate PropertyAddedVMCallback;

		static void propertyadded_cb (IntPtr objekt, IntPtr property)
		{
			try {
				Object objekt_managed = GLib.Object.GetObject (objekt, false) as Object;
				objekt_managed.OnPropertyAdded (GLib.Object.GetObject(property) as Cpg.Property);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePropertyAdded (GLib.GType gtype)
		{
			if (PropertyAddedVMCallback == null)
				PropertyAddedVMCallback = new PropertyAddedVMDelegate (propertyadded_cb);
			OverrideVirtualMethod (gtype, "property-added", PropertyAddedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Object), ConnectionMethod="OverridePropertyAdded")]
		protected virtual void OnPropertyAdded (Cpg.Property property)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (property);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("property-added")]
		public event Cpg.PropertyAddedHandler PropertyAdded {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "property-added", typeof (Cpg.PropertyAddedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "property-added", typeof (Cpg.PropertyAddedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void TaintedVMDelegate (IntPtr objekt);

		static TaintedVMDelegate TaintedVMCallback;

		static void tainted_cb (IntPtr objekt)
		{
			try {
				Object objekt_managed = GLib.Object.GetObject (objekt, false) as Object;
				objekt_managed.OnTainted ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideTainted (GLib.GType gtype)
		{
			if (TaintedVMCallback == null)
				TaintedVMCallback = new TaintedVMDelegate (tainted_cb);
			OverrideVirtualMethod (gtype, "tainted", TaintedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Object), ConnectionMethod="OverrideTainted")]
		protected virtual void OnTainted ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("tainted")]
		public event System.EventHandler Tainted {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "tainted");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "tainted");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void PropertyChangedVMDelegate (IntPtr objekt, IntPtr property);

		static PropertyChangedVMDelegate PropertyChangedVMCallback;

		static void propertychanged_cb (IntPtr objekt, IntPtr property)
		{
			try {
				Object objekt_managed = GLib.Object.GetObject (objekt, false) as Object;
				objekt_managed.OnPropertyChanged (GLib.Object.GetObject(property) as Cpg.Property);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePropertyChanged (GLib.GType gtype)
		{
			if (PropertyChangedVMCallback == null)
				PropertyChangedVMCallback = new PropertyChangedVMDelegate (propertychanged_cb);
			OverrideVirtualMethod (gtype, "property-changed", PropertyChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cpg.Object), ConnectionMethod="OverridePropertyChanged")]
		protected virtual void OnPropertyChanged (Cpg.Property property)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (property);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("property-changed")]
		public event Cpg.PropertyChangedHandler PropertyChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "property-changed", typeof (Cpg.PropertyChangedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "property-changed", typeof (Cpg.PropertyChangedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_object_is_compiled(IntPtr raw);

		public bool IsCompiled { 
			get {
				bool raw_ret = cpg_object_is_compiled(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_object_has_property(IntPtr raw, IntPtr name);

		public bool HasProperty(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = cpg_object_has_property(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_object_equal(IntPtr raw, IntPtr second);

		public bool Equal(Cpg.Object second) {
			bool raw_ret = cpg_object_equal(Handle, second == null ? IntPtr.Zero : second.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_object_reset(IntPtr raw);

		public void Reset() {
			cpg_object_reset(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_get_applied_templates(IntPtr raw);

		public Cpg.Object[] AppliedTemplates { 
			get {
				IntPtr raw_ret = cpg_object_get_applied_templates(Handle);
				Cpg.Object[] ret = (Cpg.Object[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Object));
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_get_properties(IntPtr raw);

		public Cpg.Property[] Properties { 
			get {
				IntPtr raw_ret = cpg_object_get_properties(Handle);
				Cpg.Property[] ret = (Cpg.Property[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Property));
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern bool cpg_object_compile(IntPtr raw, IntPtr context, IntPtr error);

		public bool Compile(Cpg.CompileContext context, Cpg.CompileError error) {
			bool raw_ret = cpg_object_compile(Handle, context == null ? IntPtr.Zero : context.Handle, error == null ? IntPtr.Zero : error.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_object_taint(IntPtr raw);

		public void Taint() {
			cpg_object_taint(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern unsafe bool cpg_object_remove_property(IntPtr raw, IntPtr name, out IntPtr error);

		public unsafe bool RemoveProperty(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = cpg_object_remove_property(Handle, native_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_get_property(IntPtr raw, IntPtr name);

		public Cpg.Property Property(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_object_get_property(Handle, native_name);
			Cpg.Property ret = GLib.Object.GetObject(raw_ret) as Cpg.Property;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern int cpg_object_error_quark();

		public static int ErrorQuark() {
			int raw_ret = cpg_object_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_get_actors(IntPtr raw);

		public Cpg.Property[] Actors { 
			get {
				IntPtr raw_ret = cpg_object_get_actors(Handle);
				Cpg.Property[] ret = (Cpg.Property[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cpg.Property));
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_object_reset_cache(IntPtr raw);

		public void ResetCache() {
			cpg_object_reset_cache(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_object_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern void cpg_object_clear(IntPtr raw);

		public void Clear() {
			cpg_object_clear(Handle);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_object_add_property(IntPtr raw, IntPtr name, IntPtr expression, int flags);

		public Cpg.Property AddProperty(string name, string expression, Cpg.PropertyFlags flags) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_expression = GLib.Marshaller.StringToPtrGStrdup (expression);
			IntPtr raw_ret = cpg_object_add_property(Handle, native_name, native_expression, (int) flags);
			Cpg.Property ret = GLib.Object.GetObject(raw_ret) as Cpg.Property;
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_expression);
			return ret;
		}

#endregion
	}
}
