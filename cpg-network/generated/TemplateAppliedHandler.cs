// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;

	public delegate void TemplateAppliedHandler(object o, TemplateAppliedArgs args);

	public class TemplateAppliedArgs : GLib.SignalArgs {
		public Cpg.Object Templ{
			get {
				return (Cpg.Object) Args[0];
			}
		}

	}
}
