
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class PlayersListTreeWidget
	{
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::LongoMatch.Gui.Component.PlayersTreeView playerstreeview;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.PlayersListTreeWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.PlayersListTreeWidget";
			// Container child LongoMatch.Gui.Component.PlayersListTreeWidget.Gtk.Container+ContainerChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.playerstreeview = new global::LongoMatch.Gui.Component.PlayersTreeView ();
			this.playerstreeview.CanFocus = true;
			this.playerstreeview.Name = "playerstreeview";
			this.playerstreeview.Colors = false;
			this.scrolledwindow1.Add (this.playerstreeview);
			this.Add (this.scrolledwindow1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}