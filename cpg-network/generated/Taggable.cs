// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Cpg {

	using System;

#region Autogenerated code
	public interface Taggable : GLib.IWrapper {

		void RemoveTag(string tag);
		bool HasTag(string tag);
		System.IntPtr TagTable { 
			get;
		}
		string GetTag(string tag);
		bool TryGetTag(string tag, string value);
		void AddTag(string tag, string value);
	}

	[GLib.GInterface (typeof (TaggableAdapter))]
	public interface TaggableImplementor : GLib.IWrapper {

		System.IntPtr TagTable { get; }
	}
#endregion
}
