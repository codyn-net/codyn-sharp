// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;

	public delegate void PieceAddedHandler(object o, PieceAddedArgs args);

	public class PieceAddedArgs : GLib.SignalArgs {
		public Cpg.FunctionPolynomialPiece Piece{
			get {
				return (Cpg.FunctionPolynomialPiece) Args[0];
			}
		}

	}
}
