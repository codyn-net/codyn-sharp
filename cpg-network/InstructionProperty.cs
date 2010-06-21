namespace Cpg.Instructions
{
	using System;
	using System.Runtime.InteropServices;

	public class Property : Instruction
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_property_new(IntPtr property, int binding);

		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public Cpg.Instructions.Type type;
			public IntPtr property;
			public int binding;
		}

		public Property(IntPtr raw) : base(raw)
		{
		}

		public Property(Cpg.Property property, Cpg.Instructions.Binding binding)
		{
			Raw = cpg_instruction_property_new(property == null ? IntPtr.Zero : property.Handle, (int)binding);
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

		public Cpg.Property CpgProperty
		{
			get
			{
				return GLib.Object.GetObject(Native.property, false) as Cpg.Property;
			}
			set
			{
				NativeStruct native = Native;
				native.property = value == null ? IntPtr.Zero : value.Handle;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public Cpg.Instructions.Binding Binding
		{
			get
			{
				return (Cpg.Instructions.Binding)Native.binding;
			}
			set
			{
				NativeStruct native = Native;
				native.binding = (int)value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public override string ToString()
		{
			Cpg.Property prop = CpgProperty;

			return String.Format("PRP ({0}.{1})", prop.Object.Id, prop.Name);
		}
	}
}
