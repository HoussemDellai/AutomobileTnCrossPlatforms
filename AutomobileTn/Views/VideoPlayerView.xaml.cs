using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileTn.Models;
using Xamarin.Forms;

namespace AutomobileTn.Views
{
    public partial class VideoPlayerView : ContentPage
    {
        public VideoPlayerView(Video video)
        {
            InitializeComponent();

            BindingContext = video;

            // MessagengingCenter : http://developer.xamarin.com/guides/cross-platform/xamarin-forms/messaging-center/
            MessagingCenter.Send(video.VideoLink, "video");
        }
    }
}
