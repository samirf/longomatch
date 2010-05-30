// SectionsTimeNode.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
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
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//

using System;
using System.Runtime.Serialization;
using Gdk;
using Mono.Unix;
using LongoMatch.Common;

namespace LongoMatch.TimeNodes
{

	/// <summary>
	/// I am a tagging category for the analysis. I contain the default values to creates plays
	/// tagged in my category
	/// </summary>
	[Serializable]
	public class SectionsTimeNode:TimeNode, ISerializable
	{
		
		private HotKey hotkey;
		private Gdk.Color color;
		private SortMethodType sortMethod;
		
		
		#region Constructors
		/// <summary>
		/// Creates a new category
		/// </summary>
		/// <param name="name">
		/// A <see cref="System.String"/> with the category's name
		/// </param>
		/// <param name="start">
		/// A <see cref="Time"/> with the default lead time
		/// </param>
		/// <param name="stop">
		/// A <see cref="Time"/> with the default lag time
		/// </param>
		/// <param name="hotkey">
		/// A <see cref="HotKey"/> with the hotkey to create new plays in my category
		/// </param>
		/// <param name="color">
		/// A <see cref="Color"/> that will be shared among plays tagged in my category
		/// </param>
		public SectionsTimeNode(String name,Time start, Time stop, HotKey hotkey, Color color):base(name,start,stop)
		{
			this.hotkey = hotkey;
			this.color = color;
			this.sortMethod = SortMethodType.SortByName;
		}
		
		// this constructor is automatically called during deserialization
		public SectionsTimeNode(SerializationInfo info, StreamingContext context) {
			Name = info.GetString("name");
			Start = (Time)info.GetValue("start", typeof(Time));
			Stop = (Time)info.GetValue("stop", typeof(Time));
			HotKey = (HotKey)info.GetValue("hotkey", typeof(HotKey));
			// read 'red', 'blue' and 'green' values and convert it to Gdk.Color
			Color c = new Color();
			c.Red = (ushort)info.GetValue("red", typeof(ushort));
			c.Green = (ushort)info.GetValue("green", typeof(ushort));
			c.Blue = (ushort)info.GetValue("blue", typeof(ushort));
			Color = c;
		}
		#endregion
		#region  Properties

		/// <value>
		/// A key combination to create plays in my category
		/// </value>
		public HotKey HotKey {
			get {
				return hotkey;
			}
			set {
				hotkey = value;
			}
		}

		/// <value>
		/// A color to draw plays from my category
		/// </value>
		public Color Color {
			get {
				return color;
			}
			set {
				color=value;
			}
		}
		
		//// <value>
		/// Sort method used to sort plays for this category 
		/// </value>
		public SortMethodType SortMethod{
			get{
				// New in 0.15.5
				try{
					return sortMethod;
				}
				catch{
					return SortMethodType.SortByName;
				}
			}
			set{
				this.sortMethod = value;
			}			
		}
			
		public string SortMethodString{
			get{
				switch (sortMethod){
					case SortMethodType.SortByName:
						return Catalog.GetString("Sort by name");
					case SortMethodType.SortByStartTime:
						return Catalog.GetString("Sort by start time");
					case SortMethodType.SortByStopTime:
						return Catalog.GetString("Sort by stop time");
					case SortMethodType.SortByDuration:
						return Catalog.GetString("Sort by duration");
					default:
						return Catalog.GetString("Sort by name");
				}						
			}
			set{			
				if (value == Catalog.GetString("Sort by start time"))
					sortMethod = SortMethodType.SortByStartTime;
				else if (value == Catalog.GetString("Sort by stop time"))
					sortMethod = SortMethodType.SortByStopTime;
				else if (value == Catalog.GetString("Sort by duration"))
					sortMethod = SortMethodType.SortByDuration;
				else
					sortMethod = SortMethodType.SortByName;
			}
		}
		// this method is automatically called during serialization
		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			info.AddValue("name", Name);
			info.AddValue("start", Start);
			info.AddValue("stop", Stop);
			info.AddValue("hotkey", hotkey);
			info.AddValue("red", color.Red);
			info.AddValue("green", color.Green);
			info.AddValue("blue", color.Blue);
		}
		#endregion		
	}
}
