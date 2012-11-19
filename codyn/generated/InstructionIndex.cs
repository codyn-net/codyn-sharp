// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class InstructionIndex : Cdn.Instruction {

		[Obsolete]
		protected InstructionIndex(GLib.GType gtype) : base(gtype) {}
		public InstructionIndex(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_instruction_index_new(out int indices, IntPtr retdim, IntPtr arg);

		public InstructionIndex (out int indices, Cdn.Dimension retdim, Cdn.StackArg arg) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InstructionIndex)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr native_retdim = GLib.Marshaller.StructureToPtrAlloc (retdim);
			Raw = cdn_instruction_index_new(out indices, native_retdim, arg == null ? IntPtr.Zero : arg.Handle);
			retdim = Cdn.Dimension.New (native_retdim);
			Marshal.FreeHGlobal (native_retdim);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_instruction_index_new_offset(int start, IntPtr retdim, IntPtr arg);

		public static InstructionIndex NewOffset(int start, Cdn.Dimension retdim, Cdn.StackArg arg)
		{
			IntPtr native_retdim = GLib.Marshaller.StructureToPtrAlloc (retdim);
			InstructionIndex result = new InstructionIndex (cdn_instruction_index_new_offset(start, native_retdim, arg == null ? IntPtr.Zero : arg.Handle));
			retdim = Cdn.Dimension.New (native_retdim);
			Marshal.FreeHGlobal (native_retdim);
			return result;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_instruction_index_get_offset(IntPtr raw);

		public int Offset { 
			get {
				int raw_ret = cdn_instruction_index_get_offset(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_instruction_index_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_instruction_index_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern bool cdn_instruction_index_is_offset(IntPtr raw);

		public bool IsOffset { 
			get {
				bool raw_ret = cdn_instruction_index_is_offset(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

#endregion
#region Customized extensions
#line 1 "InstructionIndex.custom"
		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_instruction_index_get_indices(IntPtr raw, out int length);

		public int[] Indices
		{
			get
			{
				int length;

				IntPtr raw_ret = cdn_instruction_index_get_indices(Handle, out length);
				int[] ret = new int[length];

				Marshal.Copy(raw_ret, ret, 0, length);
				return ret;
			}
		}

#endregion
	}
}
