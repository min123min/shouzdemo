using Android.App;
using Android.OS;
using Android.Widget;
using System.Timers;
using System;
using Android.Media;
namespace App2
{
    [Activity(Label = "TakeVideo", Icon = "@drawable/icon")]
    class TakeVideo : Activity
    {
        MediaRecorder recorder;
        private int StartCount = 10;
        private Timer StartTimer;
        public string CountDown;
        private Button StartVid, ReplyVid;
        public VideoView video;
        public string sampleVideo;
        public string path;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.TakeVideoPage);
            StartVid = FindViewById<Button>(Resource.Id.Record);
            ReplyVid = FindViewById<Button>(Resource.Id.Reply);
            CountDown = (string)FindViewById<TextView>(Resource.Id.TextCountDown);
            video = FindViewById<VideoView>(Resource.Id.SampleVideoView);
            path = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath + "/test/testwork.mp4";
            StartVid.Click += StartFilimg;
            ReplyVid.Click += replyTheVideo;
        }

        private void replyTheVideo(object sender, EventArgs e)
        {
            if (recorder != null)
            {
                recorder.Stop();
                recorder.Release();
            }
            var uri = Android.Net.Uri.Parse(path);
            video.SetVideoURI(uri);
            video.Start();
        }

        private void StartFilimg(object sender, EventArgs e)
        {
            base.OnResume();
            StartTimer = new Timer();
            StartTimer.Interval = 1000;
            StartTimer.Elapsed += Timer_Elapsed;
            StartTimer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            while (StartCount > 0)
            {
                sampleVideo = " " + StartCount;

                if (StartCount == 1)
                {
                    RunOnUiThread(() =>
                    {
                        video.StopPlayback();

                        recorder = new MediaRecorder();
                        recorder.SetVideoSource(VideoSource.Camera);
                        recorder.SetAudioSource(AudioSource.Mic);
                        recorder.SetOutputFormat(OutputFormat.Default);
                        recorder.SetVideoEncoder(VideoEncoder.Default);
                        recorder.SetAudioEncoder(AudioEncoder.Default);
                        recorder.SetOutputFile(path);
                        recorder.SetPreviewDisplay(video.Holder.Surface);
                        recorder.SetOrientationHint(90);
                        recorder.Prepare();
                        recorder.Start();
                    });
                }
                StartCount--;
            }
        }
    }
}