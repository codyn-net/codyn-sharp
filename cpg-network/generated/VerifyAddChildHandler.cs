// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;

	public delegate void VerifyAddChildHandler(object o, VerifyAddChildArgs args);

	public class VerifyAddChildArgs : GLib.SignalArgs {
		public GLib.Object P0{
			get {
				return (GLib.Object) Args[0];
			}
		}

		public IntPtr P1{
			get {
				return (IntPtr) Args[1];
			}
		}

	}
}