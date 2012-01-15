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

using LongoMatch.Common;
using LongoMatch.Interfaces;
using LongoMatch.Interfaces.GUI;
using LongoMatch.Interfaces.Multimedia;
using LongoMatch.Store;

namespace LongoMatch.Services.Projects
{
	public class ProjectStepsBase
	{
		protected string description;
		protected ProjectType type;
		protected Project project;
		protected IGUIToolkit guiToolkit;
		protected IMultimediaToolkit multimediaToolkit;
		
		public ProjectStepsBase (IGUIToolkit guiToolkit, IMultimediaToolkit multimediaToolkit)
		{
			this.guiToolkit = guiToolkit;
			this.multimediaToolkit = multimediaToolkit;
		}
		
		public String Description {
			get {
				return description;
			}
		}
		
		public ProjectType ProjectType {
			get {
				return type;
			}
		} 
		
		public void Create () {
			
		}
		
		public void Save () {
			Log.Debug(String.Format("Saving project {0} type: {1}", project, type));
		}
		
		public void Close () {
			
		}
	}
}

