
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AutomobileTn.Models;
using AutomobileTn.Views;
using Xamarin.Forms;

namespace AutomobileTn.Droid
{
	[Activity (Label = "Videos")]			
	public class VideoPlayerActivity : Activity
	{
	    protected override void OnPostCreate(Bundle savedInstanceState)
	    {
            MessagingCenter.Subscribe<Video, string>(this, "Hi", (sender, arg) =>
            {
                // do something whenever the "Hi" message is sent
                // using the 'arg' parameter which is a string
                PlayVideo(arg);
            });

            base.OnPostCreate(savedInstanceState);
	    }

	    protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.VideoPlayerLayout);

            //var button = FindViewById<Button> (Resource.Id.myButton);

            //button.Click += (sender, e) => {
            //	Finish(); // back to the previous activity
            //};
        }

	    private void PlayVideo(string videoUri)
	    {
            var videoView = FindViewById<VideoView>(Resource.Id.SampleVideoView);

            var uri = Android.Net.Uri.Parse(videoUri);

            videoView.SetVideoURI(uri);

            videoView.Start();
        }
	}
}

