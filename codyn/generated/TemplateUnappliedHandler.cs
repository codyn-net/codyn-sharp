// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

	public delegate void TemplateUnappliedHandler(object o, TemplateUnappliedArgs args);

	public class TemplateUnappliedArgs : GLib.SignalArgs {
		public Cdn.Object Templ{
			get {
				return (Cdn.Object) Args[0];
			}
		}

	}
}