// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Instruction : Cdn.MiniObject {

		[Obsolete]
		protected Instruction(GLib.GType gtype) : base(gtype) {}
		public Instruction(IntPtr raw) : base(raw) {}

		protected Instruction() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = cdn_instruction_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_instruction_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern void cdn_instruction_execute(IntPtr raw, IntPtr stack);

		public void Execute(Cdn.Stack stack) {
			cdn_instruction_execute(Handle, stack == null ? IntPtr.Zero : stack.Handle);
		}

		[DllImport("codyn-3.0")]
		static extern unsafe IntPtr cdn_instruction_get_stack_manipulation(IntPtr raw, out IntPtr error);

		public unsafe Cdn.StackManipulation GetStackManipulation() {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = cdn_instruction_get_stack_manipulation(Handle, out error);
			Cdn.StackManipulation ret = Cdn.StackManipulation.New (raw_ret);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_instruction_get_is_commutative(IntPtr raw);

		public bool IsCommutative { 
			get {
				bool raw_ret = cdn_instruction_get_is_commutative(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern IntPtr cdn_instruction_get_dependencies(IntPtr raw);

		public Cdn.Variable[] Dependencies { 
			get {
				IntPtr raw_ret = cdn_instruction_get_dependencies(Handle);
				Cdn.Variable[] ret = (Cdn.Variable[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, false, typeof(Cdn.Variable));
				return ret;
			}
		}

		[DllImport("codyn-3.0")]
		static extern bool cdn_instruction_equal(IntPtr raw, IntPtr i2);

		public bool Equal(Cdn.Instruction i2) {
			bool raw_ret = cdn_instruction_equal(Handle, i2 == null ? IntPtr.Zero : i2.Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}