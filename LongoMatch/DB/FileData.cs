// FileData.cs
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
using System.Collections;
using Gtk;
using Gdk;

namespace LongoMatch
{
	
	[Serializable]
	public class FileData : IComparable
	{
		
		private string filename;
		
		private string title;
				
		private string localName;

		private string visitorName;

		private int localGoals;

		private int visitorGoals;
		
		private DateTime matchDate;


		private ArrayList 	dataSection1, dataSection2, dataSection3, dataSection4, dataSection5, dataSection6, dataSection7, dataSection8,
					dataSection9, dataSection10, dataSection11, dataSection12, dataSection13, dataSection14, dataSection15, dataSection16,
					dataSection17, dataSection18, dataSection19, dataSection20;

		private Sections sections;

		private ArrayList[] dataSectionArray;
		
	
		
		public FileData(String filename, String localName, String visitorName, int localGoals,
		                int visitorGoals, DateTime matchDate, Sections sections) {
			
			this.filename = filename;
			this.localName = localName;
			this.visitorName = visitorName;
			this.localGoals = localGoals;
			this.visitorGoals = visitorGoals;
			this.matchDate = matchDate;		
			this.sections = sections;
			dataSectionArray = new ArrayList[20];

		
			dataSection1 = new ArrayList();
			dataSectionArray[0] = dataSection1;
			dataSection2 = new ArrayList();
			dataSectionArray[1] = dataSection2;
			dataSection3 = new ArrayList();
			dataSectionArray[2] = dataSection3;
			dataSection4 = new ArrayList();
			dataSectionArray[3] = dataSection4;
			dataSection5 = new ArrayList();
			dataSectionArray[4] = dataSection5;
			dataSection6 = new ArrayList();
			dataSectionArray[5] = dataSection6;
			dataSection7 = new ArrayList();
			dataSectionArray[6] = dataSection7;
			dataSection8 = new ArrayList();
			dataSectionArray[7] = dataSection8;
			dataSection9 = new ArrayList();
			dataSectionArray[8] = dataSection9;
			dataSection10 = new ArrayList();
			dataSectionArray[9] = dataSection10;
			dataSection11 = new ArrayList();
			dataSectionArray[10] = dataSection11;
			dataSection12 = new ArrayList();
			dataSectionArray[11] = dataSection12;
			dataSection13 = new ArrayList();
			dataSectionArray[12] = dataSection13;
			dataSection14 = new ArrayList();
			dataSectionArray[13] = dataSection14;
			dataSection15 = new ArrayList();
			dataSectionArray[14] = dataSection15;
			dataSection16 = new ArrayList();
			dataSectionArray[15] = dataSection16;
			dataSection17 = new ArrayList();
			dataSectionArray[16] = dataSection17;
			dataSection18 = new ArrayList();
			dataSectionArray[17] = dataSection18;
			dataSection19 = new ArrayList();
			dataSectionArray[18] = dataSection19;
			dataSection20 = new ArrayList();
			dataSectionArray[19] = dataSection20;
			
			
			this.Title = System.IO.Path.GetFileNameWithoutExtension(this.filename);
			
			System.IO.Directory.CreateDirectory(MainClass.ThumbnailsDir()+"/"+title);
			
			
			
	
		}
	
		public Sections Sections{
			get{ return this.sections;}
			set {this.sections = value;}
			
		}
		
		public string[] GetSectionsNames(){
			return sections.GetSectionsNames();
				
		}
		
		public Time[] GetSectionsStartTimes(){
			return sections.GetSectionsStartTimes();
		}
		
		public Time[] GetSectionsStopTimes(){
			return sections.GetSectionsStopTimes();
		}

		public MediaTimeNode AddTimeNode(int dataSection, Time start, Time stop,Pixbuf miniature) {
			MediaTimeNode tn ;
			string miniaturePath = null;
			ArrayList al= dataSectionArray[dataSection];
			int count= al.Count+1;
			string name = sections.GetName(dataSection) + " " +count;
			if (miniature != null){
				miniaturePath = MainClass.ThumbnailsDir() + "/"+this.Title+"/"+"Section"+dataSection+"-"+name+
					"-"+start.ToMSecondsString()+"-"+stop.ToMSecondsString()+".jpg";				
				miniature.Save(miniaturePath,"jpeg");
			}
			tn = new MediaTimeNode(name, start, stop,dataSection,miniaturePath);
			dataSectionArray[dataSection].Add(tn);			
			return tn;

		}

		public void DelTimeNode(MediaTimeNode tNode) {
			dataSectionArray[tNode.DataSection].Remove(tNode);
			if (System.IO.File.Exists(tNode.MiniaturePath))
			    System.IO.File.Delete(tNode.MiniaturePath);
		}
		
		public TreeStore GetModel (){
			Gtk.TreeStore dataFileListStore = new Gtk.TreeStore (typeof (MediaTimeNode));
			for (int i=0;i<this.Sections.VisibleSections;i++){
				Gtk.TreeIter iter = dataFileListStore.AppendValues (sections.GetTimeNode(i));
				foreach(MediaTimeNode tNode in dataSectionArray[i]){
					dataFileListStore.AppendValues (iter,tNode);
				}					
			}
			return dataFileListStore;
		}

		public ArrayList[] GetDataArray() {
			return dataSectionArray;
		}

		/*public String[] GetRoots() {
			return roots;
		}*/

		public String Filename {
			get{return filename;}
			set{filename=value;}
		}
		
		public String Title {
			get{return title;}
			set{title=value;}
		}
		
		public String LocalName {
			get{ return localName;}
			set{localName=value;}
		}
		
		public String VisitorName {
			get{ return visitorName;}
			set{visitorName=value;}
		}
		
		public int LocalGoals {
			get{ return localGoals;}
			set{localGoals=value;}
		}
		
		public int VisitorGoals {
			get{ return visitorGoals;}
			set{visitorGoals=value;}
		}
		
		
		public int VisibleSections {
			get{ return this.Sections.VisibleSections;}
			set{ this.Sections.VisibleSections=value;}
		}
		
		public DateTime MatchDate {
			get{ return matchDate;}
			set{ matchDate=value;}
		}

		public bool Equals(FileData fileData){
			return this.Filename.Equals(fileData.Filename);
		}
		
		public int CompareTo(object obj) {
			if(obj is FileData) {
				FileData fData = (FileData) obj;

				return this.Filename.CompareTo(fData.Filename);
			}
			else
				throw new ArgumentException("object is not a FileData and cannot be compared");    
		}
	}
}