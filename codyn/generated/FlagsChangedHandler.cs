// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void FlagsChangedHandler(object o, FlagsChangedArgs args);

	public class FlagsChangedArgs : GLib.SignalArgs {
		public Cdn.VariableFlags Flags{
			get {
				return (Cdn.VariableFlags) Args [0];
			}
		}

	}
}
