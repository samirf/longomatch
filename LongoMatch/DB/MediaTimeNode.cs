// MediaTimeNode.cs
//
//  Copyright (C) 2007 Andoni Morales Alastruey
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
using Gdk;

	namespace LongoMatch
	{
		/* MediaTimeNode is the main object of the database for {@LongoMatch}. It' s used to
	       store the name of each reference point we want to remind with its start time
	       and its stop time, and the data type it belowns to. When we mark a moment in the
	       video, this object contains all the information we need to reproduce the
	       video sequence again.
		*/
		[Serializable]
		public class MediaTimeNode : TimeNode
		{
		
		//Stores the Data Section it belowns to, to allow its removal
		 private int dataSection;
		
		private string miniaturePath;
				
		
		public MediaTimeNode(String name, Time start, Time stop, int dataSection,string miniaturePath):base (name,start,stop) {
			this.dataSection = dataSection;		
			this.miniaturePath= miniaturePath;
		}
		
		public int DataSection{
			get{
			return dataSection;
			}
		}	
		
		public Pixbuf Miniature{
			get{ 
				if (System.IO.File.Exists(this.MiniaturePath)){					
					return new Pixbuf(this.MiniaturePath);
				}
				else return null;
			}
		}
		
		public String MiniaturePath{
	
			get{return this.miniaturePath;}
		}
		
	}
		
}