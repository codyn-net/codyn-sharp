// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class InstructionVariable : Cdn.Instruction {

		[Obsolete]
		protected InstructionVariable(GLib.GType gtype) : base(gtype) {}
		public InstructionVariable(IntPtr raw) : base(raw) {}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_instruction_variable_new(IntPtr property);

		public InstructionVariable (Cdn.Variable property) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InstructionVariable)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cdn_instruction_variable_new(property == null ? IntPtr.Zero : property.Handle);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_instruction_variable_new_with_binding(IntPtr property, int binding);

		public InstructionVariable (Cdn.Variable property, Cdn.InstructionVariableBinding binding) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (InstructionVariable)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = cdn_instruction_variable_new_with_binding(property == null ? IntPtr.Zero : property.Handle, (int) binding);
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_instruction_variable_get_binding(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_instruction_variable_set_binding(IntPtr raw, int binding);

		public Cdn.InstructionVariableBinding Binding { 
			get {
				int raw_ret = cdn_instruction_variable_get_binding(Handle);
				Cdn.InstructionVariableBinding ret = (Cdn.InstructionVariableBinding) raw_ret;
				return ret;
			}
			set {
				cdn_instruction_variable_set_binding(Handle, (int) value);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_instruction_variable_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = cdn_instruction_variable_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern uint cdn_instruction_variable_get_slice(IntPtr raw, out uint length, IntPtr dim);

		public uint GetSlice(out uint length, Cdn.Dimension dim) {
			IntPtr native_dim = GLib.Marshaller.StructureToPtrAlloc (dim);
			uint raw_ret = cdn_instruction_variable_get_slice(Handle, out length, native_dim);
			uint ret = raw_ret;
			dim = Cdn.Dimension.New (native_dim);
			Marshal.FreeHGlobal (native_dim);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_instruction_variable_apply_slice(IntPtr raw, out uint slice, uint length, IntPtr dim);

		public uint ApplySlice(uint length, Cdn.Dimension dim) {
			uint slice;
			IntPtr native_dim = GLib.Marshaller.StructureToPtrAlloc (dim);
			cdn_instruction_variable_apply_slice(Handle, out slice, length, native_dim);
			dim = Cdn.Dimension.New (native_dim);
			Marshal.FreeHGlobal (native_dim);
			return slice;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_instruction_variable_get_variable(IntPtr raw);

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_instruction_variable_set_variable(IntPtr raw, IntPtr property);

		public Cdn.Variable Variable { 
			get {
				IntPtr raw_ret = cdn_instruction_variable_get_variable(Handle);
				Cdn.Variable ret = GLib.Object.GetObject(raw_ret) as Cdn.Variable;
				return ret;
			}
			set {
				cdn_instruction_variable_set_variable(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern void cdn_instruction_variable_set_slice(IntPtr raw, out uint slice, uint length, IntPtr dim);

		public uint SetSlice(uint length, Cdn.Dimension dim) {
			uint slice;
			IntPtr native_dim = GLib.Marshaller.StructureToPtrAlloc (dim);
			cdn_instruction_variable_set_slice(Handle, out slice, length, native_dim);
			dim = Cdn.Dimension.New (native_dim);
			Marshal.FreeHGlobal (native_dim);
			return slice;
		}

#endregion
	}
}
