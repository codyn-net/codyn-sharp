// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class InstructionCustomFunction : Cdn.Instruction {

		[Obsolete]
		protected InstructionCustomFunction(GLib.GType gtype) : base(gtype) {}
		public InstructionCustomFunction(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_custom_function_new(IntPtr function, int arguments, out int argdim);

		public InstructionCustomFunction (Cdn.Function function, int arguments, out int argdim) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InstructionCustomFunction)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cdn_instruction_custom_function_new(function == null ? IntPtr.Zero : function.Handle, arguments, out argdim);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_custom_function_get_function(IntPtr raw);

		[DllImport("codyn-3.0")]
		static extern void cdn_instruction_custom_function_set_function(IntPtr raw, IntPtr f);

		public Cdn.Function Function { 
			get {
				IntPtr raw_ret = cdn_instruction_custom_function_get_function(Handle);
				Cdn.Function ret = GLib.Object.GetObject(raw_ret) as Cdn.Function;
				return ret;
			}
			set {
				cdn_instruction_custom_function_set_function(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_custom_function_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_instruction_custom_function_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

#endregion
	}
}
