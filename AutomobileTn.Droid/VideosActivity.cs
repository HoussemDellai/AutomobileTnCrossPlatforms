
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
using AutomobileTn.Views;
using Xamarin.Forms;

namespace AutomobileTn.Droid
{
	[Activity (Label = "Videos")]			
	public class VideosActivity : Activity
	{
	    protected override void OnPostCreate(Bundle savedInstanceState)
	    {
            MessagingCenter.Subscribe<VideoPlayerView>(this, "Hi", OnMessageReceived);

            base.OnPostCreate(savedInstanceState);
	    }

	    protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.VideosLayout);

            var videoView = FindViewById<VideoView>(Resource.Id.SampleVideoView);

            var uri = Android.Net.Uri.Parse("http://video.ch9.ms/ch9/d207/4590f20e-3565-43cc-851e-f4334dbdd207/apiapps.mp4");

            videoView.SetVideoURI(uri);

            videoView.Start();

            //var button = FindViewById<Button> (Resource.Id.myButton);

            //button.Click += (sender, e) => {
            //	Finish(); // back to the previous activity
            //};
        }

	    private void OnMessageReceived(VideoPlayerView obj)
	    {
	        
	    }
	}
}

