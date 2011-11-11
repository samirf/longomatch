
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class GameUnitsEditor
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label1;
		private global::Gtk.ScrolledWindow scrolledwindow2;
		private global::Gtk.VBox outerbox;
		private global::Gtk.VBox phasesbox;
		private global::Gtk.VBox fillerbox;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Entry entry1;
		private global::Gtk.Button addbutton;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.GameUnitsEditor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.GameUnitsEditor";
			// Container child LongoMatch.Gui.Component.GameUnitsEditor.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Game Units</b>: Games are usually divided in time by units. In sports like field hockey the game is divided in 2 halves but other sports like tenis have several types of units that are anidated, e.g. Set->Game->Point.\n\nDefining <b> Game Units </b> will help you during the analysis to indentify the tagged plays in the the phases of the game.");
			this.label1.UseMarkup = true;
			this.label1.Wrap = true;
			this.label1.WidthChars = 70;
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w2 = new global::Gtk.Viewport ();
			w2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.outerbox = new global::Gtk.VBox ();
			this.outerbox.Name = "outerbox";
			this.outerbox.Spacing = 6;
			// Container child outerbox.Gtk.Box+BoxChild
			this.phasesbox = new global::Gtk.VBox ();
			this.phasesbox.Name = "phasesbox";
			this.phasesbox.Spacing = 6;
			this.outerbox.Add (this.phasesbox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.outerbox [this.phasesbox]));
			w3.Position = 0;
			w3.Expand = false;
			// Container child outerbox.Gtk.Box+BoxChild
			this.fillerbox = new global::Gtk.VBox ();
			this.fillerbox.Name = "fillerbox";
			this.fillerbox.Spacing = 6;
			this.outerbox.Add (this.fillerbox);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.outerbox [this.fillerbox]));
			w4.Position = 1;
			w2.Add (this.outerbox);
			this.scrolledwindow2.Add (w2);
			this.vbox2.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scrolledwindow2]));
			w7.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.hbox1.Add (this.entry1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entry1]));
			w8.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.addbutton = new global::Gtk.Button ();
			this.addbutton.Sensitive = false;
			this.addbutton.CanFocus = true;
			this.addbutton.Name = "addbutton";
			this.addbutton.UseUnderline = true;
			// Container child addbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w9 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w10 = new global::Gtk.HBox ();
			w10.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w11 = new global::Gtk.Image ();
			w11.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Dialog);
			w10.Add (w11);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w13 = new global::Gtk.Label ();
			w13.LabelProp = global::Mono.Unix.Catalog.GetString ("Add game unit");
			w13.UseUnderline = true;
			w10.Add (w13);
			w9.Add (w10);
			this.addbutton.Add (w9);
			this.hbox1.Add (this.addbutton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.addbutton]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w18.PackType = ((global::Gtk.PackType)(1));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.outerbox.Hide ();
			this.vbox2.Hide ();
			this.Hide ();
		}
	}
}
