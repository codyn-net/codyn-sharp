// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void BegunHandler(object o, BegunArgs args);

	public class BegunArgs : GLib.SignalArgs {
		public double From{
			get {
				return (double) Args [0];
			}
		}

	}
}
