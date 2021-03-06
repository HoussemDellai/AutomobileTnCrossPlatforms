﻿using AutomobileTn.Models;
using AutomobileTn.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutomobileTn.Utils;

namespace AutomobileTn.ViewModels
{
	public class TweetsViewModel : INotifyPropertyChanged
	{

		private List<Tweet> _tweetsList;

		public List<Tweet> TweetsList
		{
			get
			{
				return _tweetsList;
			}
			set
			{
				_tweetsList = value;
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

        public TweetsViewModel()
		{
            RefreshCommand = new RelayCommand(async () => await DownloadDataAsync());

            DownloadDataAsync();
		}

		private async Task DownloadDataAsync()
		{
		    IsBusy = true;

			var tweetsSrvice = new TweetsService();

			TweetsList = await tweetsSrvice.GetTweetsAsync();

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
