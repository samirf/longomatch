// fakeColorBin.cs
//
//  Copyright (C) 2008 Andoni Morales Alastruey
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

namespace LongoMatch.Widgets.Component
{
	
	// HACK This Class is a hack to prevent the colors selector's window appearing under
	// the main window on Windows
	
	public partial class fakeColorBin : Gtk.Bin
	{
		
		public fakeColorBin()
		{
			this.Build();
		}
		
		public Color Color{
			get{
				return this.colorbutton2.Color;
			}
			set {
				this.colorbutton2.Color = value;
			}
		}
	}
}