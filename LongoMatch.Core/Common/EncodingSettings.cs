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
namespace LongoMatch.Common
{
	[Serializable]
	public struct EncodingSettings
	{
		public EncodingSettings(VideoStandard videoStandard, EncodingProfile encodingProfile,
		                        uint fr_n, uint fr_d, uint videoBitrate, uint audioBitrate, 
		                        string outputFile, uint titleSize) {
			VideoStandard = videoStandard;
			EncodingProfile = encodingProfile;
			Framerate_n = fr_n;
			Framerate_d = fr_d;
			AudioBitrate = audioBitrate;
			VideoBitrate = videoBitrate;
			OutputFile = outputFile;
			TitleSize = titleSize;
		}
		
		public VideoStandard VideoStandard;
		public EncodingProfile EncodingProfile;
		public uint Framerate_n;
		public uint Framerate_d;
		public uint VideoBitrate;
		public uint AudioBitrate;
		public string OutputFile;
		public uint TitleSize;
	}
}

