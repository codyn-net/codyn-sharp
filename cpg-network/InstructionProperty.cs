namespace Cpg
{
	using System;
	using System.Runtime.InteropServices;

	public class InstructionProperty : GLib.Opaque
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_property_new(IntPtr property, int binding);

		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public InstructionCode type;
			public IntPtr property;
			public int binding;
		}

		public InstructionProperty (Property property, InstructionBinding binding)
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

		public Property Property
		{
			get
			{
				return GLib.Object.GetObject(Native.property, false) as Property;
			}
			set
			{
				NativeStruct native = Native;
				native.property = value == null ? IntPtr.Zero : value.Handle;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public InstructionBinding Binding
		{
			get
			{
				return (InstructionBinding)Native.binding;
			}
			set
			{
				NativeStruct native = Native;
				native.binding = (int)value;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}
	}
}
