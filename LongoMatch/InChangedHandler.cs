// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace LongoMatch {

	using System;

	public delegate void InChangedHandler(object o, InChangedArgs args);

	public class InChangedArgs : GLib.SignalArgs {
		public double Val{
			get {
				return (double) Args[0];
			}
		}

	}
}