// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;

#region Autogenerated code
	public interface Statement : GLib.IWrapper {

		void SetColumn(int start, int end);
		void GetColumn(out int start, out int end);
		void SetLine(int start, int end);
		void GetLine(out int start, out int end);
	}

	[GLib.GInterface (typeof (StatementAdapter))]
	public interface StatementImplementor : GLib.IWrapper {

	}
#endregion
}
