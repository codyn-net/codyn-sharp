// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void ActionAddedHandler(object o, ActionAddedArgs args);

	public class ActionAddedArgs : GLib.SignalArgs {
		public Cdn.EdgeAction Action{
			get {
				return (Cdn.EdgeAction) Args[0];
			}
		}

	}
}
