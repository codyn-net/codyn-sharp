// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void CompileErrorHandler(object o, CompileErrorArgs args);

	public class CompileErrorArgs : GLib.SignalArgs {
		public Cdn.CompileError Error{
			get {
				return (Cdn.CompileError) Args [0];
			}
		}

	}
}
