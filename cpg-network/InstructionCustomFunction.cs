namespace Cpg.Instructions
{
	using System;
	using System.Runtime.InteropServices;

	public class CustomFunction : Instruction
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_custom_function_new(IntPtr function, int arguments);

		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public Cpg.Instructions.Type type;
			public IntPtr function;
			public int arguments;
		}

		public CustomFunction(IntPtr raw) : base(raw)
		{
		}

		public CustomFunction(Function function, int arguments)
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

		public Cpg.Function Function
		{
			get
			{
				return GLib.Object.GetObject(Native.function, false) as Cpg.Function;
			}
			set
			{
				NativeStruct native = Native;
				native.function = value == null ? IntPtr.Zero : value.Handle;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public override string ToString()
		{
			return String.Format("FNC ({0})", Function.Id);
		}
	}
}
