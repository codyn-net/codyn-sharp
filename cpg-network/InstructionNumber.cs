namespace Cpg
{
	using System;
	using System.Runtime.InteropServices;

	public class InstructionNumber : GLib.Opaque
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_number_new(double value);

		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public InstructionCode type;
			public double value;
		}

		public InstructionNumber (double value) 
		{
			Raw = cpg_instruction_number_new(value);
		}

		NativeStruct Native
		{
			get
			{
				return (NativeStruct)Marshal.PtrToStructure (Raw, typeof(NativeStruct));
			}
		}

		public InstructionCode Type
		{
			get
			{
				return Native.type;
			}
			set
			{
				NativeStruct native = Native;
				native.type = value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public double Value
		{
			get
			{
				return Native.value;
			}
			set
			{
				NativeStruct native = Native;
				native.value = value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}
	}
}
