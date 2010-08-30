// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class InstructionNumber : Cpg.Instruction {

		[Obsolete]
		protected InstructionNumber(GLib.GType gtype) : base(gtype) {}
		public InstructionNumber(IntPtr raw) : base(raw) {}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_number_new(double value);

		public InstructionNumber (double value) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InstructionNumber)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cpg_instruction_number_new(value);
		}

		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_number_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cpg_instruction_number_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("cpg-network-2.0")]
		static extern double cpg_instruction_number_get_value(IntPtr raw);

		[DllImport("cpg-network-2.0")]
		static extern void cpg_instruction_number_set_value(IntPtr raw, double value);

		public double Value { 
			get {
				double raw_ret = cpg_instruction_number_get_value(Handle);
				double ret = raw_ret;
				return ret;
			}
			set {
				cpg_instruction_number_set_value(Handle, value);
			}
		}

#endregion
	}
}
