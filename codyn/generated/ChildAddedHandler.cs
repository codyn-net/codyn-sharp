// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void ChildAddedHandler(object o, ChildAddedArgs args);

	public class ChildAddedArgs : GLib.SignalArgs {
		public Cdn.Object Object{
			get {
				return (Cdn.Object) Args[0];
			}
		}

	}
}
