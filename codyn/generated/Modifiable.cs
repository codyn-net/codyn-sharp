// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

#region Autogenerated code
	public interface Modifiable : GLib.IWrapper {

		bool Modified { 
			get; set;
		}
	}

	[GLib.GInterface (typeof (ModifiableAdapter))]
	public interface ModifiableImplementor : GLib.IWrapper {

		bool Modified { get; set; }
	}
#endregion
}
