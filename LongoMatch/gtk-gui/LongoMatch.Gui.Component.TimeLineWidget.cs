// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Component {
    
    
    public partial class TimeLineWidget {
        
        private Gtk.HBox hbox3;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Button fitbutton;
        
        private Gtk.VScale vscale1;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.VBox vbox1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Component.TimeLineWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "LongoMatch.Gui.Component.TimeLineWidget";
            // Container child LongoMatch.Gui.Component.TimeLineWidget.Gtk.Container+ContainerChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.fitbutton = new Gtk.Button();
            this.fitbutton.CanFocus = true;
            this.fitbutton.Name = "fitbutton";
            this.fitbutton.UseUnderline = true;
            // Container child fitbutton.Gtk.Container+ContainerChild
            Gtk.Alignment w1 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w2 = new Gtk.HBox();
            w2.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w3 = new Gtk.Image();
            w3.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-zoom-fit", Gtk.IconSize.Button, 20);
            w2.Add(w3);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w5 = new Gtk.Label();
            w5.LabelProp = "";
            w2.Add(w5);
            w1.Add(w2);
            this.fitbutton.Add(w1);
            this.vbox3.Add(this.fitbutton);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox3[this.fitbutton]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.vscale1 = new Gtk.VScale(null);
            this.vscale1.CanFocus = true;
            this.vscale1.Name = "vscale1";
            this.vscale1.UpdatePolicy = ((Gtk.UpdateType)(1));
            this.vscale1.Inverted = true;
            this.vscale1.Adjustment.Lower = 1;
            this.vscale1.Adjustment.Upper = 100;
            this.vscale1.Adjustment.PageIncrement = 10;
            this.vscale1.Adjustment.StepIncrement = 1;
            this.vscale1.Adjustment.Value = 3;
            this.vscale1.DrawValue = true;
            this.vscale1.Digits = 0;
            this.vscale1.ValuePos = ((Gtk.PositionType)(3));
            this.vbox3.Add(this.vscale1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox3[this.vscale1]));
            w10.PackType = ((Gtk.PackType)(1));
            w10.Position = 1;
            this.hbox3.Add(this.vbox3);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox3[this.vbox3]));
            w11.Position = 0;
            w11.Expand = false;
            w11.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            Gtk.Viewport w12 = new Gtk.Viewport();
            w12.ShadowType = ((Gtk.ShadowType)(0));
            // Container child GtkViewport.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.BorderWidth = ((uint)(2));
            w12.Add(this.vbox1);
            this.GtkScrolledWindow.Add(w12);
            this.hbox3.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox3[this.GtkScrolledWindow]));
            w15.Position = 1;
            this.Add(this.hbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.fitbutton.Clicked += new System.EventHandler(this.OnFitbuttonClicked);
            this.vscale1.ValueChanged += new System.EventHandler(this.OnVscale1ValueChanged);
        }
    }
}
