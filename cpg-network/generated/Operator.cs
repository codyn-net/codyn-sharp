// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;

#region Autogenerated code
	public interface Operator : GLib.IWrapper {

		string Name { 
			get;
		}
		void ResetVariadic(Cpg.OperatorData data);
		int NumArguments { 
			get;
		}
		void Execute(Cpg.OperatorData data, Cpg.Stack stack);
		Cpg.OperatorData CreateData(GLib.SList expressions);
		GLib.SList GetExpressions(Cpg.OperatorData data);
		void ResetCache(Cpg.OperatorData data);
		void FreeData(Cpg.OperatorData data);
	}

	[GLib.GInterface (typeof (OperatorAdapter))]
	public interface OperatorImplementor : GLib.IWrapper {

		void Execute (Cpg.OperatorData data, Cpg.Stack stack);
		string Name { get; }
		Cpg.OperatorData CreateData (GLib.SList expressions);
		void FreeData (Cpg.OperatorData data);
		int NumArguments { get; }
		void ResetCache (Cpg.OperatorData data);
		void ResetVariadic (Cpg.OperatorData data);
	}
#endregion
}
