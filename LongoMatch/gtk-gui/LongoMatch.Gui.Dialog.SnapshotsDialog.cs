// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Dialog {
    
    
    public partial class SnapshotsDialog {
        
        private Gtk.Table table1;
        
        private Gtk.Entry entry1;
        
        private Gtk.Label label1;
        
        private Gtk.Label label3;
        
        private Gtk.Label label5;
        
        private Gtk.Label playLabel;
        
        private Gtk.SpinButton spinbutton1;
        
        private Gtk.Button button22;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.Dialog.SnapshotsDialog
            this.Name = "LongoMatch.Gui.Dialog.SnapshotsDialog";
            this.Icon = Stetic.IconLoader.LoadIcon(this, "longomatch", Gtk.IconSize.Dialog, 48);
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            this.HasSeparator = false;
            // Internal child LongoMatch.Gui.Dialog.SnapshotsDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.entry1 = new Gtk.Entry();
            this.entry1.CanFocus = true;
            this.entry1.Name = "entry1";
            this.entry1.IsEditable = true;
            this.entry1.InvisibleChar = '●';
            this.table1.Add(this.entry1);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.entry1]));
            w2.TopAttach = ((uint)(1));
            w2.BottomAttach = ((uint)(2));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Play:");
            this.table1.Add(this.label1);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.label1]));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Interval (frames/s):");
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w4.TopAttach = ((uint)(2));
            w4.BottomAttach = ((uint)(3));
            // Container child table1.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Series Name:");
            this.table1.Add(this.label5);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.label5]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            // Container child table1.Gtk.Table+TableChild
            this.playLabel = new Gtk.Label();
            this.playLabel.Name = "playLabel";
            this.playLabel.LabelProp = "";
            this.table1.Add(this.playLabel);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.playLabel]));
            w6.LeftAttach = ((uint)(1));
            w6.RightAttach = ((uint)(2));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.spinbutton1 = new Gtk.SpinButton(1, 25, 1);
            this.spinbutton1.CanFocus = true;
            this.spinbutton1.Name = "spinbutton1";
            this.spinbutton1.Adjustment.PageIncrement = 10;
            this.spinbutton1.ClimbRate = 1;
            this.spinbutton1.Numeric = true;
            this.spinbutton1.Value = 1;
            this.table1.Add(this.spinbutton1);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.spinbutton1]));
            w7.TopAttach = ((uint)(2));
            w7.BottomAttach = ((uint)(3));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.XOptions = ((Gtk.AttachOptions)(1));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            w1.Add(this.table1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w1[this.table1]));
            w8.Position = 0;
            // Internal child LongoMatch.Gui.Dialog.SnapshotsDialog.ActionArea
            Gtk.HButtonBox w9 = this.ActionArea;
            w9.Name = "dialog1_ActionArea";
            w9.Spacing = 6;
            w9.BorderWidth = ((uint)(5));
            w9.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button22 = new Gtk.Button();
            this.button22.CanFocus = true;
            this.button22.Name = "button22";
            this.button22.UseUnderline = true;
            // Container child button22.Gtk.Container+ContainerChild
            Gtk.Alignment w10 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w11 = new Gtk.HBox();
            w11.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w12 = new Gtk.Image();
            w12.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-record", Gtk.IconSize.Button, 20);
            w11.Add(w12);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w14 = new Gtk.Label();
            w14.LabelProp = Mono.Unix.Catalog.GetString("Export to PNG images");
            w14.UseUnderline = true;
            w11.Add(w14);
            w10.Add(w11);
            this.button22.Add(w10);
            this.AddActionWidget(this.button22, -5);
            Gtk.ButtonBox.ButtonBoxChild w18 = ((Gtk.ButtonBox.ButtonBoxChild)(w9[this.button22]));
            w18.Expand = false;
            w18.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 323;
            this.DefaultHeight = 160;
            this.Show();
        }
    }
}
