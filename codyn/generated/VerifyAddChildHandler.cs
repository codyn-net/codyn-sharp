// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void VerifyAddChildHandler(object o, VerifyAddChildArgs args);

	public class VerifyAddChildArgs : GLib.SignalArgs {
		public Cdn.Object P0{
			get {
				return (Cdn.Object) Args[0];
			}
		}

		public IntPtr P1{
			get {
				return (IntPtr) Args[1];
			}
		}

	}
}