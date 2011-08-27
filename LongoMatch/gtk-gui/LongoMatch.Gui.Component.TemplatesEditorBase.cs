
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class TemplatesEditorBase
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox mainbox;

		private global::Gtk.VBox upbox;

		private global::Gtk.ScrolledWindow scrolledwindow2;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Button newprevbutton;

		private global::Gtk.Button newafterbutton;

		private global::Gtk.Button removebutton;

		private global::Gtk.Button editbutton;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Button exportbutton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.TemplatesEditorBase
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.TemplatesEditorBase";
			// Container child LongoMatch.Gui.Component.TemplatesEditorBase.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.mainbox = new global::Gtk.VBox ();
			this.mainbox.Name = "mainbox";
			this.mainbox.Spacing = 6;
			// Container child mainbox.Gtk.Box+BoxChild
			this.upbox = new global::Gtk.VBox ();
			this.upbox.Name = "upbox";
			this.upbox.Spacing = 6;
			this.mainbox.Add (this.upbox);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.mainbox[this.upbox]));
			w1.Position = 0;
			w1.Expand = false;
			// Container child mainbox.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			this.mainbox.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.mainbox[this.scrolledwindow2]));
			w2.Position = 1;
			this.hbox1.Add (this.mainbox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.mainbox]));
			w3.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.newprevbutton = new global::Gtk.Button ();
			this.newprevbutton.TooltipMarkup = "Insert a new category before the selected one";
			this.newprevbutton.Sensitive = false;
			this.newprevbutton.CanFocus = true;
			this.newprevbutton.Name = "newprevbutton";
			this.newprevbutton.UseUnderline = true;
			// Container child newprevbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w4 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w5 = new global::Gtk.HBox ();
			w5.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w6 = new global::Gtk.Image ();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-goto-top", global::Gtk.IconSize.Menu);
			w5.Add (w6);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w8 = new global::Gtk.Label ();
			w8.LabelProp = global::Mono.Unix.Catalog.GetString ("New Before");
			w8.UseUnderline = true;
			w5.Add (w8);
			w4.Add (w5);
			this.newprevbutton.Add (w4);
			this.vbox2.Add (this.newprevbutton);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.newprevbutton]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.newafterbutton = new global::Gtk.Button ();
			this.newafterbutton.TooltipMarkup = "Insert a new category after the selected one";
			this.newafterbutton.Sensitive = false;
			this.newafterbutton.CanFocus = true;
			this.newafterbutton.Name = "newafterbutton";
			this.newafterbutton.UseUnderline = true;
			// Container child newafterbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w13 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w14 = new global::Gtk.HBox ();
			w14.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w15 = new global::Gtk.Image ();
			w15.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-goto-bottom", global::Gtk.IconSize.Menu);
			w14.Add (w15);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w17 = new global::Gtk.Label ();
			w17.LabelProp = global::Mono.Unix.Catalog.GetString ("New After");
			w17.UseUnderline = true;
			w14.Add (w17);
			w13.Add (w14);
			this.newafterbutton.Add (w13);
			this.vbox2.Add (this.newafterbutton);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.newafterbutton]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.removebutton = new global::Gtk.Button ();
			this.removebutton.TooltipMarkup = "Remove the selected category";
			this.removebutton.Sensitive = false;
			this.removebutton.CanFocus = true;
			this.removebutton.Name = "removebutton";
			this.removebutton.UseUnderline = true;
			// Container child removebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w22 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w23 = new global::Gtk.HBox ();
			w23.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w24 = new global::Gtk.Image ();
			w24.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-remove", global::Gtk.IconSize.Menu);
			w23.Add (w24);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w26 = new global::Gtk.Label ();
			w26.LabelProp = global::Mono.Unix.Catalog.GetString ("Remove");
			w26.UseUnderline = true;
			w23.Add (w26);
			w22.Add (w23);
			this.removebutton.Add (w22);
			this.vbox2.Add (this.removebutton);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.removebutton]));
			w30.Position = 2;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.editbutton = new global::Gtk.Button ();
			this.editbutton.TooltipMarkup = "Edit the selected category";
			this.editbutton.Sensitive = false;
			this.editbutton.CanFocus = true;
			this.editbutton.Name = "editbutton";
			this.editbutton.UseUnderline = true;
			// Container child editbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w31 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w32 = new global::Gtk.HBox ();
			w32.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w33 = new global::Gtk.Image ();
			w33.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			w32.Add (w33);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w35 = new global::Gtk.Label ();
			w35.LabelProp = global::Mono.Unix.Catalog.GetString ("Edit");
			w35.UseUnderline = true;
			w32.Add (w35);
			w31.Add (w32);
			this.editbutton.Add (w31);
			this.vbox2.Add (this.editbutton);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.editbutton]));
			w39.Position = 3;
			w39.Expand = false;
			w39.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hseparator1]));
			w40.Position = 4;
			w40.Expand = false;
			w40.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.exportbutton = new global::Gtk.Button ();
			this.exportbutton.TooltipMarkup = "Export the template to a file";
			this.exportbutton.CanFocus = true;
			this.exportbutton.Name = "exportbutton";
			this.exportbutton.UseUnderline = true;
			// Container child exportbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w41 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w42 = new global::Gtk.HBox ();
			w42.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w43 = new global::Gtk.Image ();
			w43.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save-as", global::Gtk.IconSize.Menu);
			w42.Add (w43);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w45 = new global::Gtk.Label ();
			w45.LabelProp = global::Mono.Unix.Catalog.GetString ("Export");
			w45.UseUnderline = true;
			w42.Add (w45);
			w41.Add (w42);
			this.exportbutton.Add (w41);
			this.vbox2.Add (this.exportbutton);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.exportbutton]));
			w49.PackType = ((global::Gtk.PackType)(1));
			w49.Position = 5;
			w49.Expand = false;
			w49.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.hseparator1.Hide ();
			this.exportbutton.Hide ();
			this.Show ();
			this.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnKeyPressEvent);
			this.newprevbutton.Clicked += new global::System.EventHandler (this.OnNewBefore);
			this.newafterbutton.Clicked += new global::System.EventHandler (this.OnNewAfter);
			this.newafterbutton.Activated += new global::System.EventHandler (this.OnNewBefore);
			this.removebutton.Clicked += new global::System.EventHandler (this.OnRemove);
			this.editbutton.Clicked += new global::System.EventHandler (this.OnEdit);
			this.exportbutton.Clicked += new global::System.EventHandler (this.OnExportbuttonClicked);
		}
	}
}