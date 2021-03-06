// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cdn {

	using System;

#region Autogenerated code
	public interface Phaseable : GLib.IWrapper {

		void RemovePhase(string phase);
		bool Equal(Cdn.Phaseable other);
		void CopyTo(Cdn.Phaseable dest);
		System.IntPtr PhaseTable { 
			get; set;
		}
		void AddPhase(string phase);
		void Foreach(Cdn.PhaseableForeachFunc func);
		bool IsActive(string phase);
#region Customized extensions
#line 1 "Phaseable.custom"
		string[] Phases { get; }

#endregion
	}

	[GLib.GInterface (typeof (PhaseableAdapter))]
	public interface PhaseableImplementor : GLib.IWrapper {

		System.IntPtr PhaseTable { get; set; }
	}
#endregion
}
