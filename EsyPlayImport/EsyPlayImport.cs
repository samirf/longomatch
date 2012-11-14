// 
//  Copyright (C) 2011 Andoni Morales Alastruey
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
using System.IO;
using System.Xml;
using Mono.Addins;
using Mono.Unix;

using LongoMatch;
using LongoMatch.Addins.ExtensionPoints;
using LongoMatch.Interfaces;
using LongoMatch.Interfaces.GUI;
using LongoMatch.Store;
using LongoMatch.Store.Templates;
using LongoMatch.Common;

[Extension]
public class EasyPlayImporter:IImportProject
{
	public string GetMenuEntryName () {
		Log.Information("Registering new import entry");
		return Catalog.GetString("Import ESYPLAY project");
	}
	
	public string GetMenuEntryShortName () {
		return "ESYPLAYImport";
	}
	
	public string GetFilterName () {
		return "ESYPLAY (.esp)";
	}
	
	public string GetFilter () {
		return "*.esp";
	}

	public Project ImportProject(string filename) {
		return ParseFile (filename);
	}
	
	public Project ParseFile (string filepath) {
		Project project = new Project();
		
		// Create an XmlReader
		using (XmlReader reader = XmlReader.Create(filepath))
		{
			reader.ReadToFollowing("project");
			reader.MoveToAttribute("author");
			if (reader.Value != "ESYTAG") {
				ImportError ("Incorrect author: " + reader.Value);
			}
			ParseProjectDescription (reader, project);
			reader.ReadToFollowing ("templates");
			ParseTeamTemplate (reader, project, false);
			ParseTeamTemplate (reader, project, true);
			ParseCategoriesTemplate (reader, project);
			ParsePlays (reader, project);
		}
		return project;
	}
	
	void ParseProjectDescription (XmlReader reader, Project project) {
		ProjectDescription projectDesc = new ProjectDescription();
		
		Log.Debug ("Parsing project description");
		project.Description = projectDesc;
		projectDesc.File = new MediaFile();
		reader.ReadToFollowing ("settings");
		reader.ReadToDescendant ("setting");
		do {
			string attr;
			reader.MoveToAttribute("name");
			attr = reader.Value;
			if (attr == "project") {
				reader.MoveToAttribute("value");
			} else if (attr == "home") {
				reader.MoveToAttribute("value");
				projectDesc.LocalName = reader.Value;
				Log.Debug ("Local team: " + projectDesc.LocalName);
				project.LocalTeamTemplate = new TeamTemplate();
				project.LocalTeamTemplate.Name = reader.Value;
				project.LocalTeamTemplate.TeamName = reader.Value;
			} else if (attr == "away") {
				reader.MoveToAttribute("value");
				projectDesc.VisitorName = reader.Value;
				Log.Debug ("Visitor team: " + projectDesc.VisitorName);
				project.VisitorTeamTemplate = new TeamTemplate();
				project.VisitorTeamTemplate.Name = reader.Value;
				project.VisitorTeamTemplate.TeamName = reader.Value;
			} else if (attr == "date") {
				reader.MoveToAttribute("value");
				try {
					projectDesc.MatchDate = DateTime.ParseExact("yyyy-MM-dd", reader.Value, null);
				} catch {
					try {
						projectDesc.MatchDate = DateTime.ParseExact("yyyy-dd-MM", reader.Value, null);
					} catch {
						Log.Warning("Could not parse date: " + reader.Value);
						projectDesc.MatchDate = DateTime.Now;
					}
				}
				Log.Debug ("Date team: " + projectDesc.MatchDate.ToShortDateString());
			}
		} while (reader.ReadToNextSibling ("setting"));
		
	}
	
	void ParseTeamTemplate (XmlReader reader, Project project, bool visitor) {
		TeamTemplate template;
		
		if (visitor)
			reader.ReadToFollowing ("away");	
		else
			reader.ReadToFollowing ("home");	
		reader.MoveToAttribute("name");
		
		template = new TeamTemplate();
		template.Name = reader.Value;
		template.TeamName = reader.Value;
		Log.Debug ("Parsing team teamplate " + template.TeamName);
		if (visitor)
			project.VisitorTeamTemplate = template;	
		else
			project.LocalTeamTemplate = template;	
		
		
		reader.ReadToFollowing ("player");
		do {
			Player player = new Player();
			reader.MoveToAttribute("name");
			player.Number = int.Parse(reader.Value);
			reader.MoveToAttribute("value");
			player.Name = reader.Value;
			template.Add(player);
			player.Playing = true;
			Log.Debug ("Added new player " + player);
		} while (reader.ReadToNextSibling ("player"));
	}
	
	void ParseCategoriesTemplate (XmlReader reader, Project project) {
		Categories categories = new Categories();
		project.Categories = categories;
		
		reader.ReadToFollowing ("categories");	
		reader.MoveToAttribute("name");
		categories.Name = reader.Value;
		Log.Debug ("Parsing caregories teamplate " + categories.Name);
		
		reader.ReadToFollowing ("category");
		do {
			Category cat = new Category();
			reader.MoveToAttribute("name");
			cat.Position = int.Parse(reader.Value);
			categories.Add (cat);
			reader.MoveToAttribute("value");
			cat.Name = reader.Value;
			reader.MoveToAttribute("lead");
			cat.Start = new Time(int.Parse(reader.Value) * 1000);
			reader.MoveToAttribute("lag");
			cat.Stop = new Time(int.Parse(reader.Value) * 1000);
			reader.MoveToAttribute("color");
			cat.Color = System.Drawing.Color.FromArgb(Convert.ToInt32(reader.Value, 16));
			cat.HotKey = new HotKey();
			categories.AddDefaultSubcategories(cat);
			Log.Debug ("Added new category " + cat);
		} while (reader.ReadToNextSibling ("category"));
	}
	
	void ParsePlays (XmlReader reader, Project project) {
		int count = 0;
		
		Log.Debug ("Parsing bookmarks ");
		reader.ReadToFollowing ("bookmarks");	
		reader.ReadToFollowing ("action");	
		do {
			reader.MoveToAttribute("time");
			Time time;
			Category cat;
			Play play = new Play();
			
			count ++;
			reader.MoveToAttribute("time");
			time = new Time((int)TimeSpan.Parse(reader.Value).TotalMilliseconds);
			reader.ReadToFollowing ("category");	
			reader.MoveToAttribute("value");
			cat = project.Categories.Find(c => c.Position == int.Parse(reader.Value));
			play.Name = cat.Name + "-" + count;
			play.Start = time - cat.Start;
			play.Stop = time + cat.Stop;
			play.Category = cat;
			Log.Debug (String.Format("Adding new bookmark to category {0} start: {1} stop: {2}",
			                         cat.Name, play.Start.ToSecondsString(),
			                         play.Stop.ToSecondsString()));
			                         
			reader.ReadToFollowing ("player");
			do {
				TeamTemplate template;
				Player player;
				PlayerSubCategory subcat;
				
				reader.MoveToAttribute ("name");
				if (reader.Value == "away") {
					template = project.VisitorTeamTemplate;
					subcat = cat.SubCategories.Find(s => s.Name == Catalog.GetString("Visitor Team Players")) as PlayerSubCategory;
				} else if (reader.Value == "home") {
					template = project.LocalTeamTemplate;
					subcat = cat.SubCategories.Find(s => s.Name == Catalog.GetString("Local Team Players")) as PlayerSubCategory;
				} else {
					continue;
				}
				
				reader.MoveToAttribute ("value");
				player = template.Find(p => p.Number == int.Parse(reader.Value));
				Log.Debug (String.Format ("Adding player {0} to subcategory {1}", player.Name, subcat.Name));
				play.Players.Add (new PlayerTag {Value=player, SubCategory=subcat});
			} while (reader.ReadToNextSibling ("player"));
			project.AddPlay (play);
		} while (reader.ReadToNextSibling("action"));
	}
	
	void ImportError (string error) {
		Log.Error (error);
		throw new Exception("Error importing project");
	}
	
}

public class TestClass
{
	public static void Main(string[] args)
	{
		Log.Debugging = true;
		EasyPlayImporter importer = new EasyPlayImporter ();
		importer.ParseFile (args[0]);
	}
}