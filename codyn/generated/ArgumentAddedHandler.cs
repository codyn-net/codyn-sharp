// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void ArgumentAddedHandler(object o, ArgumentAddedArgs args);

	public class ArgumentAddedArgs : GLib.SignalArgs {
		public Cdn.FunctionArgument Argument{
			get {
				return (Cdn.FunctionArgument) Args [0];
			}
		}

	}
}
