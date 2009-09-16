﻿// TreeWidget.cs
//
//  Copyright(C) 20072009 Andoni Morales Alastruey
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
using Mono.Unix;
using LongoMatch.DB;
using LongoMatch.Handlers;
using LongoMatch.TimeNodes;

namespace LongoMatch.Gui.Component
{
	
	
	[System.ComponentModel.Category("LongoMatch")]
	[System.ComponentModel.ToolboxItem(true)]
	public partial class PlaysListTreeWidget : Gtk.Bin
	{

		public event TimeNodeSelectedHandler TimeNodeSelected;
		public event TimeNodeChangedHandler TimeNodeChanged;
		public event TimeNodeDeletedHandler TimeNodeDeleted;
		public event PlayListNodeAddedHandler PlayListNodeAdded;
		public event SnapshotSeriesHandler SnapshotSeriesEvent;
		public event PlayersTaggedHandler PlayersTagged;

		private Project project;

		
		public PlaysListTreeWidget()
		{		
			this.Build();		    
			
		}
		
		public void DeletePlay (MediaTimeNode play, int section){
			if (project != null){
				TreeIter iter;
				TreeStore model = (TreeStore)treeview.Model;
				model.GetIterFromString (out iter, section.ToString());
				TreeIter child;						
				model.IterChildren(out child, iter);
				// Searching the TimeNode to remove it
				while (model.IterIsValid(child)){
				    MediaTimeNode mtn = (MediaTimeNode) model.GetValue( child,0);
					if(mtn == play){
						model.Remove (ref child);
						break;
					}
					TreeIter prev = child;
					model.IterNext(ref child);
					if (prev.Equals(child))
						break;
				}				
			}			
		}		
		
		public void AddPlay(MediaTimeNode play,int  section){
			if (project != null){
				TreeIter iter;
				TreeStore model = (TreeStore)treeview.Model;
				model.GetIterFromString (out iter, section.ToString());
				TimeNode stNode = (TimeNode)model.GetValue (iter,0);
				if (project.Sections.GetTimeNode(section) == stNode)
					model.AppendValues (iter,play);
			}		
		}
		
			
		public Project Project{
			set{ 
				project = value;
				treeview.Model = project.GetModel();
				treeview.Colors = project.Sections.GetColors();
			}			
		}	
		
		public bool PlayListLoaded{
			set{treeview.PlayListLoaded=value;}
		}

		protected virtual void OnTimeNodeChanged(TimeNode tNode,object val){
			if (TimeNodeChanged != null)
				TimeNodeChanged(tNode,val);
		}
		
		protected virtual void OnTimeNodeSelected(MediaTimeNode tNode){
			if (TimeNodeSelected != null)
				TimeNodeSelected(tNode);
		}
		
		protected virtual void OnTimeNodeDeleted(MediaTimeNode tNode, int section){
			if (TimeNodeDeleted != null)
				TimeNodeDeleted(tNode,section);
		}

		protected virtual void OnPlayListNodeAdded (MediaTimeNode tNode)
		{
			if (PlayListNodeAdded != null)
				PlayListNodeAdded(tNode);
		}

		protected virtual void OnTreeviewSnapshotSeriesEvent (LongoMatch.TimeNodes.MediaTimeNode tNode)
		{
			if (SnapshotSeriesEvent != null)
				SnapshotSeriesEvent(tNode);
		}
		
		protected virtual void OnTreeviewPlayersTagged (LongoMatch.TimeNodes.MediaTimeNode tNode, LongoMatch.TimeNodes.Team team)
		{
			if (PlayersTagged != null)
				PlayersTagged(tNode,team);
		}		
	}
}