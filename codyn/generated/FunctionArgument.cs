// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class FunctionArgument : GLib.InitiallyUnowned {

		[Obsolete]
		protected FunctionArgument(GLib.GType gtype) : base(gtype) {}
		public FunctionArgument(IntPtr raw) : base(raw) {}

		protected FunctionArgument() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_function_argument_get_optional(IntPtr raw);

		[GLib.Property ("optional")]
		public bool Optional {
			get  {
				bool raw_ret = cdn_function_argument_get_optional(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_function_argument_get_explicit(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_function_argument_set_explicit(IntPtr raw, bool isexplicit);

		[GLib.Property ("explicit")]
		public bool Explicit {
			get  {
				bool raw_ret = cdn_function_argument_get_explicit(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				cdn_function_argument_set_explicit(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_function_argument_get_default_value(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_function_argument_set_default_value(IntPtr raw, IntPtr value);

		[GLib.Property ("default-value")]
		public Cdn.Expression DefaultValue {
			get  {
				IntPtr raw_ret = cdn_function_argument_get_default_value(Handle);
				Cdn.Expression ret = GLib.Object.GetObject(raw_ret) as Cdn.Expression;
				return ret;
			}
			set  {
				cdn_function_argument_set_default_value(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_function_argument_get_name(IntPtr raw);

		[GLib.Property ("name")]
		public string Name {
			get  {
				IntPtr raw_ret = cdn_function_argument_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("name", val);
				val.Dispose ();
			}
		}

		[GLib.CDeclCallback]
		delegate bool InvalidateNameVMDelegate (IntPtr argument, IntPtr name);

		static InvalidateNameVMDelegate InvalidateNameVMCallback;

		static bool invalidatename_cb (IntPtr argument, IntPtr name)
		{
			try {
				FunctionArgument argument_managed = GLib.Object.GetObject (argument, false) as FunctionArgument;
				return argument_managed.OnInvalidateName (GLib.Marshaller.Utf8PtrToString (name));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call doesn't return
				throw e;
			}
		}

		private static void OverrideInvalidateName (GLib.GType gtype)
		{
			if (InvalidateNameVMCallback == null)
				InvalidateNameVMCallback = new InvalidateNameVMDelegate (invalidatename_cb);
			OverrideVirtualMethod (gtype, "invalidate-name", InvalidateNameVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Cdn.FunctionArgument), ConnectionMethod="OverrideInvalidateName")]
		protected virtual bool OnInvalidateName (string name)
		{
			GLib.Value ret = new GLib.Value (GLib.GType.Boolean);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (name);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			bool result = (bool) ret;
			ret.Dispose ();
			return result;
		}

		[GLib.Signal("invalidate-name")]
		public event Cdn.InvalidateNameHandler InvalidateName {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "invalidate-name", typeof (Cdn.InvalidateNameArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "invalidate-name", typeof (Cdn.InvalidateNameArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_function_argument_get_dimension(IntPtr raw, IntPtr dimension);

		public void GetDimension(Cdn.Dimension dimension) {
			IntPtr native_dimension = GLib.Marshaller.StructureToPtrAlloc (dimension);
			cdn_function_argument_get_dimension(Handle, native_dimension);
			dimension = Cdn.Dimension.New (native_dimension);
			Marshal.FreeHGlobal (native_dimension);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_function_argument_set_dimension(IntPtr raw, IntPtr dimension);

		public void SetDimension(Cdn.Dimension dimension) {
			IntPtr native_dimension = GLib.Marshaller.StructureToPtrAlloc (dimension);
			cdn_function_argument_set_dimension(Handle, native_dimension);
			dimension = Cdn.Dimension.New (native_dimension);
			Marshal.FreeHGlobal (native_dimension);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_function_argument_get_unused(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_function_argument_set_unused(IntPtr raw, bool unused);

		public bool Unused { 
			get {
				bool raw_ret = cdn_function_argument_get_unused(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				cdn_function_argument_set_unused(Handle, value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_function_argument_set_name(IntPtr raw, IntPtr name);

		public bool SetName(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = cdn_function_argument_set_name(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_function_argument_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_function_argument_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_function_argument_copy(IntPtr raw);

		public Cdn.FunctionArgument Copy() {
			IntPtr raw_ret = cdn_function_argument_copy(Handle);
			Cdn.FunctionArgument ret = GLib.Object.GetObject(raw_ret, true) as Cdn.FunctionArgument;
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "FunctionArgument.custom"
		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_function_argument_new(IntPtr name, IntPtr expression, bool isexplicit);

		[DllImport ("libgobject-2.0-0.dll")]
		private static extern void g_object_ref_sink (IntPtr raw);

		public FunctionArgument (string name, Cdn.Expression defaultValue, bool isexplicit) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FunctionArgument)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}

			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Raw = cdn_function_argument_new(native_name, defaultValue != null ? defaultValue.Handle : IntPtr.Zero, isexplicit);
			GLib.Marshaller.Free (native_name);

			if (Raw != IntPtr.Zero)
			{
				g_object_ref_sink (Raw);
			}
		}

#endregion
	}
}
