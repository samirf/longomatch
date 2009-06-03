// GstVideoSplitter.cs
//
//  Copyright (C) 2009 Andoni Morales Alastruey
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

namespace LongoMatch.Video.Editor {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;


	public class GstVideoSplitter : GLib.Object {

		[DllImport("libcesarplayer.dll")]
		static extern unsafe IntPtr gst_video_splitter_new(out IntPtr err);

		public event LongoMatch.Video.Handlers.ProgressHandler Progress;
		
		public unsafe GstVideoSplitter () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GstVideoSplitter)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr error = IntPtr.Zero;
			Raw = gst_video_splitter_new(out error);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			PercentCompleted += delegate(object o, PercentCompletedArgs args) {
				if (Progress!= null)
					Progress (args.Percent);
			};
		}

		#region Properties
		
		[GLib.Property ("video_bitrate")]
		public int VideoBitrate {
			get {
				GLib.Value val = GetProperty ("video_bitrate");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("video_bitrate", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("audio_bitrate")]
		public int AudioBitrate {
			get {
				GLib.Value val = GetProperty ("audio_bitrate");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("audio_bitrate", val);
				val.Dispose ();
			}
		}
		
		[GLib.Property ("width")]
		public int Width {
			get {
				GLib.Value val = GetProperty ("width");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("width", val);
				val.Dispose ();
			}
		}
		
		[GLib.Property ("height")]
		public int Height {
			get {
				GLib.Value val = GetProperty ("height");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("height", val);
				val.Dispose ();
			}
		}
		
		[GLib.Property ("output_file")]
		public string OutputFile {
			get {
				GLib.Value val = GetProperty ("output_file");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);				
				SetProperty("output_file", val);
				val.Dispose ();
			}
		}
		
		#endregion

		
		
		#region GSignals

		[GLib.CDeclCallback]
		delegate void ErrorVMDelegate (IntPtr gvc, IntPtr message);

		static ErrorVMDelegate ErrorVMCallback;

		static void error_cb (IntPtr gvc, IntPtr message)
		{
			try {
				GstVideoSplitter gvc_managed = GLib.Object.GetObject (gvc, false) as GstVideoSplitter;
				gvc_managed.OnError (GLib.Marshaller.Utf8PtrToString (message));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideError (GLib.GType gtype)
		{
			if (ErrorVMCallback == null)
				ErrorVMCallback = new ErrorVMDelegate (error_cb);
			OverrideVirtualMethod (gtype, "error", ErrorVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Editor.GstVideoSplitter), ConnectionMethod="OverrideError")]
		protected virtual void OnError (string message)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (message);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("error")]
		public event LongoMatch.Video.Editor.ErrorHandler Error {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "error", typeof (LongoMatch.Video.Editor.ErrorArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "error", typeof (LongoMatch.Video.Editor.ErrorArgs));
				sig.RemoveDelegate (value);
			}
		}
		

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void PercentCompletedVMDelegate (IntPtr gvc, float percent);

		static PercentCompletedVMDelegate PercentCompletedVMCallback;

		static void percentcompleted_cb (IntPtr gvc, float percent)
		{
			try {
				GstVideoSplitter gvc_managed = GLib.Object.GetObject (gvc, false) as GstVideoSplitter;
				gvc_managed.OnPercentCompleted (percent);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePercentCompleted (GLib.GType gtype)
		{
			if (PercentCompletedVMCallback == null)
				PercentCompletedVMCallback = new PercentCompletedVMDelegate (percentcompleted_cb);
			OverrideVirtualMethod (gtype, "percent_completed", PercentCompletedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Editor.GstVideoSplitter), ConnectionMethod="OverridePercentCompleted")]
		protected virtual void OnPercentCompleted (float percent)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (percent);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("percent_completed")]
		public event LongoMatch.Video.Editor.PercentCompletedHandler PercentCompleted {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "percent_completed", typeof (LongoMatch.Video.Editor.PercentCompletedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "percent_completed", typeof (LongoMatch.Video.Editor.PercentCompletedArgs));
				sig.RemoveDelegate (value);
			}
		}
		
		#endregion
		
		#region Public Methods

		[DllImport("libcesarplayer.dll")]
		static extern IntPtr gst_video_splitter_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_splitter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}
		
		

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_splitter_set_segment(IntPtr raw, string file_path, long start, long duration, double rate, IntPtr title);

		public void SetSegment(string filePath, long start, long duration, double rate, string title) {
			gst_video_splitter_set_segment(Handle, filePath, start, duration, rate, GLib.Marshaller.StringToPtrGStrdup(title));
		}
		
		
		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_splitter_start(IntPtr raw);

		public void Start() {
			gst_video_splitter_start(Handle);
		}
		
		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_splitter_cancel(IntPtr raw);

		public void Cancel() {
			gst_video_splitter_cancel(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_splitter_init_backend(out int argc, IntPtr argv);

		public static int InitBackend(string argv) {
			int argc;
			gst_video_splitter_init_backend(out argc, GLib.Marshaller.StringToPtrGStrdup(argv));
			return argc;
		}
		
		#endregion

		
	}
}