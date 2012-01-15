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
	public class FileProjectSteps: ProjectStepsBase
	{
		IPlayer player;
		
		public FileProjectSteps (IGUIToolkit guiToolkit, IMultimediaToolkit multimediaToolkit): base(guiToolkit, multimediaToolkit)
		{
			player = multimediaToolkit.GetPlayer();
		}
		
		public IVideoWidget VideoWidget {
			get {
				return player;
			}
		}
		
		public override void Create () {
			base.Close();
			
			project = guiToolkit.NewFileProject(Core.DB, Core.TemplatesService);
			if (project != null)
				Core.DB.AddProject(project);
		}
		
		public override bool Load () {
			// Check if the file associated to the project exists
			if(!File.Exists(project.Description.File.FilePath)) {
				guiToolkit.WarningMessage(Catalog.GetString("The file associated to this project doesn't exist.") + "\n"
				                          + Catalog.GetString("If the location of the file has changed try to edit it with the database manager."));
				return false;
			}
			try {
				Player.Open(project.Description.File.FilePath);
			}
			catch(Exception ex) {
				guiToolkit.ErrorMessage(Catalog.GetString("An error occurred opening this project:") + "\n" + ex.Message);
				return false;
			}
			return false;
		}
		
		public override void Save () {
			base.Save();
			
			try {
				Core.DB.UpdateProject(project);
			} catch(Exception e) {
				Log.Exception(e);
			}
		}
		
		public override void Close (bool save) {
			base.Close();
			
			player.Close();
			if (save)
				Save();
		}
	}
}

