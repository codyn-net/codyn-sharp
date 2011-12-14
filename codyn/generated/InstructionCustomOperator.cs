// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class InstructionCustomOperator : Cdn.Instruction {

		[Obsolete]
		protected InstructionCustomOperator(GLib.GType gtype) : base(gtype) {}
		public InstructionCustomOperator(IntPtr raw) : base(raw) {}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_custom_operator_new(IntPtr op);

		public InstructionCustomOperator (Cdn.Operator op) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InstructionCustomOperator)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cdn_instruction_custom_operator_new(op == null ? IntPtr.Zero : op.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_custom_operator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_instruction_custom_operator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_custom_operator_get_operator(IntPtr raw);

		public Cdn.Operator Operator { 
			get {
				IntPtr raw_ret = cdn_instruction_custom_operator_get_operator(Handle);
				Cdn.Operator ret = GLib.Object.GetObject(raw_ret) as Cdn.Operator;
				return ret;
			}
		}

#endregion
	}
}