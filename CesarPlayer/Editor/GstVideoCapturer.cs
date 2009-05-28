// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace LongoMatch.Video.Editor {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;


	public class GstVideoCapturer : GLib.Object, IVideoEditor {

		[DllImport("libcesarplayer.dll")]
		static extern unsafe IntPtr gst_video_capturer_new(out IntPtr err);

		public event LongoMatch.Video.Handlers.ProgressHandler Progress;
		
		public unsafe GstVideoCapturer () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GstVideoCapturer)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			IntPtr error = IntPtr.Zero;
			Raw = gst_video_capturer_new(out error);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			PercentCompleted += delegate(object o, PercentCompletedArgs args) {
				if (Progress!= null)
					Progress (args.Percent);
			};
		}

		#region Properties
		
		[GLib.Property ("video_bitrate")]
		public uint VideoBitrate {
			get {
				GLib.Value val = GetProperty ("video_bitrate");
				uint ret = (uint) val;
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
		public uint AudioBitrate {
			get {
				GLib.Value val = GetProperty ("audio_bitrate");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("audio_bitrate", val);
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
				SetProperty("audio_bitrate", val);
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
				GstVideoCapturer gvc_managed = GLib.Object.GetObject (gvc, false) as GstVideoCapturer;
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

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Editor.GstVideoCapturer), ConnectionMethod="OverrideError")]
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
		delegate void EosVMDelegate (IntPtr gvc);

		static EosVMDelegate EosVMCallback;

		static void eos_cb (IntPtr gvc)
		{
			try {
				GstVideoCapturer gvc_managed = GLib.Object.GetObject (gvc, false) as GstVideoCapturer;
				gvc_managed.OnEos ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideEos (GLib.GType gtype)
		{
			if (EosVMCallback == null)
				EosVMCallback = new EosVMDelegate (eos_cb);
			OverrideVirtualMethod (gtype, "eos", EosVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Editor.GstVideoCapturer), ConnectionMethod="OverrideEos")]
		protected virtual void OnEos ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("eos")]
		public event System.EventHandler Eos {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "eos");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "eos");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		delegate void PercentCompletedVMDelegate (IntPtr gvc, float percent);

		static PercentCompletedVMDelegate PercentCompletedVMCallback;

		static void percentcompleted_cb (IntPtr gvc, float percent)
		{
			try {
				GstVideoCapturer gvc_managed = GLib.Object.GetObject (gvc, false) as GstVideoCapturer;
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

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.Video.Editor.GstVideoCapturer), ConnectionMethod="OverridePercentCompleted")]
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
		static extern IntPtr gst_video_capturer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_capturer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}
		
		

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_capturer_add_segment(IntPtr raw, string file_path, long start, long duration, double rate, IntPtr title);

		public void AddSegment(string filePath, long start, long duration, double rate, string title) {
			gst_video_capturer_add_segment(Handle, filePath, start, duration, rate, GLib.Marshaller.StringToPtrGStrdup(title));
		}

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_capturer_start(IntPtr raw);

		public void Start() {
			gst_video_capturer_start(Handle);
		}

		[DllImport("libcesarplayer.dll")]
		static extern void gst_video_capturer_init_backend(out int argc, IntPtr argv);

		public static int InitBackend(string argv) {
			int argc;
			gst_video_capturer_init_backend(out argc, GLib.Marshaller.StringToPtrGStrdup(argv));
			return argc;
		}
		
		#endregion

		#region Interface Implementation
		
		public bool EnableAudio{
			//TODO not implemented
			set{}
		}
		
		public VideoQuality VideoQuality{
			set {
				VideoBitrate = (uint)value;
			}
		}
		
		public AudioQuality AudioQuality{
			set{
				VideoBitrate = (uint)value;
			}
		}
		
				
		public void Cancel(){
			//TODO not implemented
		}
		
		#endregion

	}
}
