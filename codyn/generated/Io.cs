// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

#region Autogenerated code
	public interface Io : GLib.IWrapper {

		Cdn.IoMode Mode { 
			get;
		}
		void Update(Cdn.Integrator integrator);
	}

	[GLib.GInterface (typeof (IoAdapter))]
	public interface IoImplementor : GLib.IWrapper {

		void Update (Cdn.Integrator integrator);
	}
#endregion
}
