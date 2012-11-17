// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class SelectorPart : GLib.Opaque {

		[DllImport("libcodyn-3.0.dll")]
		static extern IntPtr cdn_selector_part_identifier(IntPtr raw);

		public GLib.SList Identifier() {
			IntPtr raw_ret = cdn_selector_part_identifier(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_selector_part_type(IntPtr raw);

		public Cdn.SelectorPartType Type() {
			int raw_ret = cdn_selector_part_type(Handle);
			Cdn.SelectorPartType ret = (Cdn.SelectorPartType) raw_ret;
			return ret;
		}

		[DllImport("libcodyn-3.0.dll")]
		static extern int cdn_selector_part_pseudo_type(IntPtr raw);

		public Cdn.SelectorPseudoType PseudoType() {
			int raw_ret = cdn_selector_part_pseudo_type(Handle);
			Cdn.SelectorPseudoType ret = (Cdn.SelectorPseudoType) raw_ret;
			return ret;
		}

		public SelectorPart(IntPtr raw) : base(raw) {}

#endregion
	}
}
