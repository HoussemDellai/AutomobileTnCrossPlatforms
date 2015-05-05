using AutomobileTn.Models;
using AutomobileTn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AutomobileTn.Views
{
    public partial class VideosView : ContentPage
    {
        public VideosView()
        {
            InitializeComponent();

            var videosViewModel = new VideosViewModel();

            //var video = new Video
            //{
            //    Title = "Azure App Service API Apps with Scott Hunter",
            //    MediumThumbnail = "http://video.ch9.ms/ch9/5357/aba224d2-9feb-4c63-8df4-379618295357/20150327TWC9_512.jpg",
            //    VideoLink = "http://video.ch9.ms/ch9/d207/4590f20e-3565-43cc-851e-f4334dbdd207/apiapps.mp4",
            //    PubDate = DateTime.Now,
            //};

            //vm.VideosList = new List<Video>
            //{
            //    video, video, video,
            //};

            BindingContext = videosViewModel;

            var refresh = new ToolbarItem
            {
                Icon = "refresh.png",
                Text = "Refresh",
                Command = new Command(() =>
                {
                    videosViewModel.RefreshCommand.Execute(null);
                })
            };

            ToolbarItems.Add(refresh);
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var video = e.Item as Video;
            await Navigation.PushAsync(new VideoPlayerView(video));

            MessagingCenter.Send<Video, string>(video, "Hi", video.VideoLink);
        }
    }
}