// 
//  Copyright (C) 2012 Andoni Morales Alastruey
// 
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//  
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
// 
using System;

namespace LongoMatch.Stats
{
	public class Stat
	{
		public Stat (string name, int totalCount, int localTeamCount, int visitorTeamCount)
		{
			Name = name;
			TotalCount = totalCount;
			LocalTeamCount = localTeamCount;
			VisitorTeamCount = visitorTeamCount;
		}
		
		public string Name {
			get;
			set;
		}
		
		public int TotalCount {
			get;
			set;
		}
		
		public int LocalTeamCount {
			get;
			set;
		}
		
		public int VisitorTeamCount {
			get;
			set;
		}
	}
}

