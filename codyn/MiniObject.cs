namespace Cdn
{
	using System;
	using System.Collections;
	using System.Runtime.InteropServices;
	using System.Reflection;

	public class MiniObject : IDisposable
	{
		private IntPtr d_raw;

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_mini_object_ref(IntPtr raw);

		public MiniObject(IntPtr raw)
		{
			if (raw != IntPtr.Zero)
			{
				d_raw = cdn_mini_object_ref (raw);
			}
			else
			{
				d_raw = IntPtr.Zero;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_mini_object_new(IntPtr raw_gtype);

		protected MiniObject(GLib.GType gtype)
		{
			d_raw = cdn_mini_object_new (gtype.Val);
		}

		public IntPtr Handle
		{
			get { return d_raw; }
		}

		public IntPtr Raw
		{
			get { return d_raw; }
			set
			{
				if (d_raw != IntPtr.Zero)
				{
					cdn_mini_object_unref (d_raw);
				}

				d_raw = cdn_mini_object_ref (value);
			}
		}

		~MiniObject()
		{
			Dispose(false);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_mini_object_unref(IntPtr raw);

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				// Contains no other objects...
			}

			if (d_raw != IntPtr.Zero)
			{
				cdn_mini_object_unref(d_raw);
				d_raw = IntPtr.Zero;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_mini_object_copy(IntPtr raw);

		public Cdn.MiniObject Copy()
		{
			IntPtr cpraw = cdn_mini_object_copy(d_raw);

			return GetObject(GetType(), cpraw);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_mini_object_get_type();

		public static GLib.GType GType
		{
			get
			{
				IntPtr raw_ret = cdn_mini_object_get_type();

				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		private GLib.GType LookupGType()
		{
			Type t = GetType();

			PropertyInfo pi = t.GetProperty("GType", BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public);

			if (pi == null)
			{
				throw new Exception(String.Format("Could not determine GType of MiniObject type {0}", t));
			}

			return (GLib.GType) pi.GetValue (null, null);
		}

		public static Cdn.MiniObject GetObject(Type type, IntPtr raw)
		{
			if (type == null || raw == IntPtr.Zero)
			{
				return null;
			}

			ConstructorInfo info = type.GetConstructor(new Type[] {typeof(IntPtr)});
			return info.Invoke(new object[] {raw}) as Cdn.MiniObject;
		}

		[DllImport ("libgobject-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_type_parent (IntPtr type);

		static Type GetTypeOrParent(IntPtr obj)
		{
			// First field is GTypeClass
			IntPtr klass = Marshal.ReadIntPtr(obj);

			// First field is GType
			IntPtr typeid = Marshal.ReadIntPtr(klass);

			if (typeid == GLib.GType.Invalid.Val)
			{
				return null;
			}

			Type result = GLib.GType.LookupType(typeid);

			while (result == null)
			{
				typeid = g_type_parent(typeid);

				if (typeid == IntPtr.Zero)
				{
					return null;
				}

				result = GLib.GType.LookupType(typeid);
			}

			return result;
		}

		public static Cdn.MiniObject GetObject(IntPtr raw)
		{
			Type type = GetTypeOrParent(raw);
			return GetObject(type, raw);
		}

		protected virtual void CreateNativeObject(string[] names, GLib.Value[] vals)
		{
			d_raw = cdn_mini_object_new (LookupGType().Val);
		}
	}
}
