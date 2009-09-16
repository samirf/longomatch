//
//  Copyright (C) 2009 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//

using System;
using Gtk;
using Gdk;
using LongoMatch.TimeNodes;

namespace LongoMatch.Gui.Dialog
{
	
	
	public partial class HotKeySelectorDialog : Gtk.Dialog
	{
		HotKey hotKey;
		
#region Constructors
		
		public HotKeySelectorDialog()
		{
			hotKey = new HotKey();
			this.Build();
		}
#endregion
		
#region Properties
		
		public HotKey HotKey{
			get{return this.hotKey;}
		}		
#endregion
		
#region Overrides
		
		protected override bool OnKeyPressEvent (Gdk.EventKey evnt)
		{
			Gdk.Key key = evnt.Key;
			ModifierType modifier = evnt.State;

			if ((modifier & (ModifierType.Mod1Mask | ModifierType.ShiftMask)) != 0
				&& key != Gdk.Key.Shift_L 
			    && key != Gdk.Key.Shift_R
			    && key != Gdk.Key.Alt_L  )
			{
				hotKey.Key = key;
				hotKey.Modifier = modifier & (ModifierType.Mod1Mask | ModifierType.ShiftMask);
				this.Respond (ResponseType.Ok);
			}
			
			return base.OnKeyPressEvent (evnt);
		}
#endregion

	}
}