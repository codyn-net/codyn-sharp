namespace Cpg.Instructions
{
	using System;
	using System.Runtime.InteropServices;

	public class Number : Instruction
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_number_new(double value);

		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public Cpg.Instructions.Type type;
			public double value;
		}

		public Number(IntPtr raw) : base(raw)
		{
		}

		public Number(double value)
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

		public Cpg.Instructions.Type Type
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

		public override string ToString()
		{
			return String.Format("NUM ({0})", Value);
		}
	}
}
