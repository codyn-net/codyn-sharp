// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;

	public delegate void BeginHandler(object o, BeginArgs args);

	public class BeginArgs : GLib.SignalArgs {
		public double From{
			get {
				return (double) Args [0];
			}
		}

		public double Step{
			get {
				return (double) Args [1];
			}
		}

		public double To{
			get {
				return (double) Args [2];
			}
		}

	}
}
