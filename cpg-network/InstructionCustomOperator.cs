namespace Cpg.Instructions
{
	using System;
	using System.Runtime.InteropServices;

	public class CustomOperator : Instruction
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_custom_operator_new(IntPtr op, IntPtr expressions);

		[StructLayout(LayoutKind.Sequential)]
		struct NativeStruct
		{
			public Cpg.Instructions.Type type;

			public IntPtr op;
			public IntPtr data;
		}

		protected CustomOperator()
		{
		}

		public CustomOperator(IntPtr raw) : base(raw)
		{
		}

		public CustomOperator(Cpg.Operator op, params Cpg.Expression[] expressions)
		{
			using (GLib.SList slist = new GLib.SList(expressions, typeof(Cpg.Expression), true, false))
			{
				Raw = cpg_instruction_custom_operator_new(op.Handle, slist.Handle);
			}
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

		public Cpg.Operator Operator
		{
			get
			{
				return GLib.Object.GetObject(Native.op, false) as Cpg.Operator;
			}
			set
			{
				NativeStruct native = Native;
				native.op = value == null ? IntPtr.Zero : value.Handle;
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public Cpg.OperatorData Data
		{
			get
			{
				return new Cpg.OperatorData(Native.data);
			}
			set
			{
				NativeStruct native = Native;

				Marshal.StructureToPtr(value, native.data, false);
				Marshal.StructureToPtr(native, Raw, false);
			}
		}

		public override string ToString()
		{
			return String.Format("OPC");
		}
	}
}
