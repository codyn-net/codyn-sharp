namespace Cpg
{
	using System;
	using System.Runtime.InteropServices;

	public class InstructionCustomFunction : GLib.Opaque
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_custom_function_new(IntPtr function, int arguments);

		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public InstructionCode type;
			public IntPtr function;
			public int arguments;
		}

		public InstructionCustomFunction(Function function, int arguments)
		{
			Raw = cpg_instruction_custom_function_new(function.Handle, arguments);
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

		public Function Function
		{
			get
			{
				return GLib.Object.GetObject(Native.function, false) as Function;
			}
			set
			{
				NativeStruct native = Native;
				native.function = value == null ? IntPtr.Zero : value.Handle;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}
	}
}
