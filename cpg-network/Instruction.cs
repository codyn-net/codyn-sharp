namespace Cpg.Instructions
{
	using System;
	using System.Runtime.InteropServices;

	public class Instruction : GLib.Opaque
	{
		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public Cpg.Instructions.Type type;
		}

		public Instruction()
		{
		}

		public Instruction(IntPtr raw)
		{
			Raw = raw;
		}

		public static Instruction FromIntPtr(IntPtr raw)
		{
			NativeStruct native;

			native = (NativeStruct)Marshal.PtrToStructure(raw, typeof(NativeStruct));

			switch (native.type)
			{
				case Cpg.Instructions.Type.Function:
					return new Function(raw);
				case Cpg.Instructions.Type.Number:
					return new Number(raw);
				case Cpg.Instructions.Type.Operator:
					return new Operator(raw);
				case Cpg.Instructions.Type.Property:
					return new Property(raw);
				case Cpg.Instructions.Type.CustomFunction:
					return new CustomFunction(raw);
			}

			return null;
		}
	}
}
