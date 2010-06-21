namespace Cpg.Instructions
{
	using System;
	using System.Runtime.InteropServices;

	public class Operator : Function
	{
		[DllImport("cpg-network-2.0")]
		static extern IntPtr cpg_instruction_operator_new(uint id, IntPtr name, int arguments);

		public Operator(IntPtr raw) : base(raw)
		{
		}

		public Operator(uint id, string name, int arguments)
		{
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup(name);
			Raw = cpg_instruction_operator_new(id, native_name, arguments);
			GLib.Marshaller.Free(native_name);
		}

		public override string ToString()
		{
			return String.Format("OP  ({0})", Name);
		}
	}
}
