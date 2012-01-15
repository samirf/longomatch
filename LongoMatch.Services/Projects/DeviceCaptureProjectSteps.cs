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
	public class DeviceCaptureProjectSteps: ProjectStepsBase
	{
		ICapturer capturer;
		CaptureSettings captureSettings;
		
		public DeviceCaptureProjectSteps (IGUIToolkit guiToolkit, IMultimediaToolkit multimediaToolkit): base(guiToolkit, multimediaToolkit)
		{
			capturer = multimediaToolkit.GetDeviceCapturer();
		}
		
		public override void Create () {
			List<Device> devices = multimediaToolkit.VideoDevices;
			
			if(devices.Count == 0) {
				guiToolkit.ErrorMessage(Catalog.GetString("No capture devices were found."));
				return;
			}
			project = guiToolkit.NewCaptureProject(Core.DB, Core.TemplatesService, devices,
			                                       out captureSettings);
		}
		
		public override bool Load () {
			capturer.CaptureProperties = captureSettings;
			try {
				Capturer.Type = CapturerType.Live;
			} catch(Exception ex) {
				guiToolkit.ErrorMessage(ex.Message);
				return false;
			}
			return true;
		}
		
		public void Save () {
			base.Save();
		
			string filePath = project.Description.File.FilePath;

			Log.Debug ("Saving capture project: " + project);
			
			/* FIXME: Show message */
			//guiToolkit.InfoMessage(Catalog.GetString("Loading newly created project..."));

			/* scan the new file to build a new PreviewMediaFile with all the metadata */
			try {
				Log.Debug("Reloading saved file: " + filePath);
				project.Description.File = multimediaToolkit.DiscoverFile(filePath);
				Core.DB.AddProject(project);
			} catch(Exception ex) {
				Log.Exception(ex);
				Log.Debug ("Backing up project to file");
				string projectFile = filePath + "-" + DateTime.Now;
				projectFile = projectFile.Replace("-", "_").Replace(" ", "_").Replace(":", "_");
				Project.Export(OpenedProject, projectFile);
				guiToolkit.ErrorMessage(Catalog.GetString("An error occured saving the project:\n")+ex.Message+ "\n\n"+
				                        Catalog.GetString("The video file and a backup of the project has been "+
				                                          "saved. Try to import it later:\n")+
				                        filePath+"\n"+projectFile);
			}
		}
		
		public void Close (bool save) {
			Player.Close();
			if (save)
				Save();
		}
	}
}

