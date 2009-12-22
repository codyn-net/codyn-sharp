// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public struct Instruction {

		public Cpg.InstructionCode Type;

		public static Cpg.Instruction Zero = new Cpg.Instruction ();

		public static Cpg.Instruction New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Cpg.Instruction.Zero;
			return (Cpg.Instruction) Marshal.PtrToStructure (raw, typeof (Cpg.Instruction));
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_instruction_copy(IntPtr raw);

		public Cpg.Instruction Copy() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = cpg_instruction_copy(this_as_native);
			Cpg.Instruction ret = Cpg.Instruction.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("cpg-network-1.0")]
		static extern void cpg_instruction_free(IntPtr raw);

		public void Free() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			cpg_instruction_free(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("cpg-network-1.0")]
		static extern IntPtr cpg_instruction_operator_new(uint id, IntPtr name, int arguments);

		public static Cpg.Instruction OperatorNew(uint id, string name, int arguments) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = cpg_instruction_operator_new(id, native_name, arguments);
			Cpg.Instruction ret = Cpg.Instruction.New (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Cpg.Instruction target)
		{
			target = New (native);
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}