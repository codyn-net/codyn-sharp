// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;

#region Autogenerated code
	public interface Usable : GLib.IWrapper {

		void Use();
		uint UseCount();
		bool Unuse();
	}

	[GLib.GInterface (typeof (UsableAdapter))]
	public interface UsableImplementor : GLib.IWrapper {

		uint UseCount ();
		void Use ();
		bool Unuse ();
	}
#endregion
}
