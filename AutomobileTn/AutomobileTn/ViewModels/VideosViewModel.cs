using AutomobileTn.Models;
using AutomobileTn.Services;
using AutomobileTn.UI;
using AutomobileTn.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutomobileTn.ViewModels
{
    public class VideosViewModel : INotifyPropertyChanged
    {

        private List<Video> _videosList;
        public List<Video> VideosList
        {
            get
            {
                return _videosList;
            }
            set
            {
                _videosList = value;
                OnPropertyChanged();
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand { get; set; }

        public ICommand SendEmployeeMessageCommand { get; set; }

        public VideosViewModel()
        {
            RefreshCommand = new RelayCommand(async () => await DownloadDataAsync());

            DownloadDataAsync();
        }

        private async Task DownloadDataAsync()
        {
            IsBusy = true;

            var videosService = new VideosService();

            VideosList = await videosService.GetYoutubeVideosAsync();

            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}