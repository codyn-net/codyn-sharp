namespace Cpg.Instructions
{
	using System;
	using System.Runtime.InteropServices;

	public class VariadicFunction : Instruction
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_variadic_function_new(uint id, string name, int arguments, bool variable);

		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public Cpg.Instructions.Type type;
			public uint id;
			public string name;
			public int arguments;
			public bool variable;

			public bool cached;
			public double cached_result;
		}

		public VariadicFunction(IntPtr raw) : base(raw)
		{
		}

		public VariadicFunction(uint id, string name, int arguments, bool variable)
		{
			Raw = cpg_instruction_variadic_function_new(id, name, arguments, variable);
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

		public uint Id
		{
			get
			{
				return Native.id;
			}
			set
			{
				NativeStruct native = Native;
				native.id = value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public string Name
		{
			get
			{
				return Native.name;
			}
			set
			{
				NativeStruct native = Native;
				native.name = value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public int Arguments
		{
			get
			{
				return Native.arguments;
			}
			set
			{
				NativeStruct native = Native;
				native.arguments = value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public bool Variable
		{
			get
			{
				return Native.variable;
			}
			set
			{
				NativeStruct native = Native;
				native.variable = value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public bool Cached
		{
			get
			{
				return Native.cached;
			}
			set
			{
				NativeStruct native = Native;
				native.cached = value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public double CachedResult
		{
			get
			{
				return Native.cached_result;
			}
			set
			{
				NativeStruct native = Native;
				native.cached_result = value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public override string ToString()
		{
			return String.Format("VAR ({0})", Id);
		}
	}
}
