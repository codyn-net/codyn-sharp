// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void RemovedHandler(object o, RemovedArgs args);

	public class RemovedArgs : GLib.SignalArgs {
		public string Name{
			get {
				return (string) Args[0];
			}
		}

		public string ChildName{
			get {
				return (string) Args[1];
			}
		}

		public string PropertyName{
			get {
				return (string) Args[2];
			}
		}

	}
}
